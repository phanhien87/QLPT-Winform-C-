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
        DataTable data;
        int totalPriceRoom, monthsDifference;

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
            db = new Database();
            
        }
        private void loadRoomforRent()
        {
            db = new Database();
            var dt = db.SelectData("loadRoomForRent");
            cbbRentalRoom.DataSource = dt;
            cbbRentalRoom.DisplayMember = "Room";
            cbbRentalRoom.ValueMember = "ID";
            cbbRentalRoom.SelectedIndex = 0;
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
            if ( int.Parse(txttTraTienphong.Text) > totalPriceRoom)
            {
                MessageBox.Show("Your payment need less than required upfront payment!", "???", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            if (db.ExeCute("AddNewContract", list) < 1)
            {
                MessageBox.Show("Add failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db = new Database();
            if (db.ExeCute("AddContractCustomer", listCustomer) != 1)
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
                  new CustomerParameter()
                  {
                      key ="@tienphong",
                      value = txttTraTienphong.Text.ToString()
                  }

                 };

            db = new Database();
            if (db.ExeCute("AddNewDetailContract", list) == 1)
            {
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


        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void dtpCheckOut_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cbbRentalRoom_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cbbRentalRoom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var list = new List<CustomerParameter>()
            {
                new CustomerParameter()
                {
                    key ="@idRoom",
                    value = cbbRentalRoom.SelectedValue.ToString()
                }
            };
            data = db.SelectData("RoomPrice", list);
            monthsDifference = ((dtpCheckOut.Value.Year - dtpRentalDate.Value.Year) * 12) + dtpCheckOut.Value.Month - dtpRentalDate.Value.Month + 1;
            totalPriceRoom = int.Parse(data.Rows[0]["DonGia"].ToString()) * monthsDifference;
            lblTotalprice.Text = string.Format("{0:N0} VND", totalPriceRoom);
            //MessageBox.Show(data.Rows[0]["DonGia"].ToString());

        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
           
            monthsDifference = ((dtpCheckOut.Value.Year - dtpRentalDate.Value.Year) * 12) + dtpCheckOut.Value.Month - dtpRentalDate.Value.Month + 1;
            totalPriceRoom = int.Parse(data.Rows[0]["DonGia"].ToString()) * monthsDifference;
            lblTotalprice.Text = string.Format("{0:N0} VND", totalPriceRoom);
           

        }

        private void dtpRentalDate_ValueChanged(object sender, EventArgs e)
        {
            
            monthsDifference = ((dtpCheckOut.Value.Year - dtpRentalDate.Value.Year) * 12) + dtpCheckOut.Value.Month - dtpRentalDate.Value.Month + 1;
            totalPriceRoom = int.Parse(data.Rows[0]["DonGia"].ToString()) * monthsDifference;
            lblTotalprice.Text = string.Format("{0:N0} VND", totalPriceRoom);
           

        }
    }
}