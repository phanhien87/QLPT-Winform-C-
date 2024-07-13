using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass_prn_QLPT
{
    public partial class frmForRentalRoom : Form
    {
        private Database db;

        public frmForRentalRoom()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmForRentalRoom_Load(object sender, EventArgs e)
        {
            loadRoomforRent();
            LoadCustomerforRent();
        }
        private void loadRoomforRent()
        {
            db = new Database();
            var dt = db.SelectData("loadRoomForRent");
            cbbRentalRoom.DataSource = dt;
            cbbRentalRoom.DisplayMember = "Room";
            cbbRentalRoom.ValueMember = "ID";
        }
        private void LoadCustomerforRent()
        {
            db = new Database();
            var dt = db.SelectData("loadCustomerforRent");
            cbbCustomer.DataSource = dt;
            cbbCustomer.DisplayMember = "Name";
            cbbCustomer.ValueMember = "ID";
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            db = new Database();
            if (cbbCustomer.SelectedIndex < 0 || cbbRentalRoom.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose one!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            var room = cbbRentalRoom.SelectedValue.ToString();
            var customer = cbbCustomer.SelectedValue.ToString();
            var tiencoc = txtDeposit.Text;

            if (tiencoc.Length <= 0 || string.IsNullOrEmpty(tiencoc))
            {
                MessageBox.Show("Please enter deposit!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var rentalDate = dtpRentalDate.Value;
            var checkout = dtpCheckOut.Value;
            if (rentalDate >= checkout)
            {
                MessageBox.Show("Check-out Date must be set after Rental date!", "???", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int wn = int.Parse(txtwn.Text);
            int en = int.Parse(txten.Text);
            int wf = int.Parse(txtWifiFee.Text);
            int ccFee = int.Parse(txtCCfee.Text);

            var list = new List<CustomerParameter>()
            {
                new CustomerParameter()
                {
                    key="@idRoom",
                    value= room
                },

                new CustomerParameter()
                {
                    key="@deposit",
                    value= tiencoc
                },
                     new CustomerParameter()
                {
                    key="@ccf",
                    value= ccFee.ToString()
                },
                     new CustomerParameter()
                {
                    key="@wifiFee",
                    value= wf.ToString()
                },

            };

            var listCustomer = new List<CustomerParameter>()
            {
                
                 new CustomerParameter()
                {
                    key="@idCustomer",
                    value= customer
                },


            };
            if (db.ExeCute("AddNewContract", list) <1)
            {
                MessageBox.Show("Add failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            db = new Database();
            if(db.ExeCute("AddContractCustomer", listCustomer) != 1)
            {
                MessageBox.Show("Failed Detail!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            list = new List<CustomerParameter>()
            {
                new CustomerParameter()
                {
                    key="@ci",
                    value= rentalDate.ToString("dd/MM/yyyy")
                },

                new CustomerParameter()
                {
                    key="@co",
                    value= checkout.ToString("dd/MM/yyyy")
                },
                 new CustomerParameter()
                {
                    key="@wn",
                    value= wn.ToString()
                },
                  new CustomerParameter()
                {
                    key="@en",
                    value= en.ToString()
                },
               
                

                 };
            
            db = new Database();
            if (db.ExeCute("AddNewDetailContract", list) == 1) {
                MessageBox.Show("Rented room successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
           
        }


        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}