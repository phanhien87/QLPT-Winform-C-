using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass_prn_QLPT.ChildForm
{

    public partial class frmInforToExtend : Form
    {
        private int rowIndex = -1;
        private string idContractt, nameRomm;
        private Database db;
        public frmInforToExtend(string idContract, string nameRoom)
        {
            InitializeComponent();
            this.idContractt = idContract;
            this.nameRomm = nameRoom;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void loadCustomer()
        {
            lblNameRoom.Text = nameRomm;
            db = new Database();
            var dt = db.SelectData("loadCustomerforRent");
            cbbCustomer.DataSource = dt;
            cbbCustomer.DisplayMember = "Name";
            cbbCustomer.ValueMember = "ID";
        }
        private void loadMember()
        {
            db = new Database();
            var list = new List<CustomerParameter>() {
                new CustomerParameter()
                {
                    key = "@idContract",
                    value = idContractt
                }
            };
            dgvMember.DataSource = db.SelectData("loadMember", list);
        }

        private void frmInforToExtend_Load(object sender, EventArgs e)
        {
            loadCustomer();
            loadMember();
            dgvMember.Columns["ID"].Visible = false;
            dgvMember.Columns["IDContract"].Visible = false;
            dgvMember.Columns["IDCustomer"].Visible = false;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            db = new Database();
            var list = new List<CustomerParameter>() {
                new CustomerParameter()
                {
                    key = "@idContract",
                    value = idContractt
                },
                new CustomerParameter()
                {
                    key = "@idCustomer",
                    value = cbbCustomer.SelectedValue.ToString()
                }
            };
            var rs = db.ExeCute("addMember", list);
            if (rs == 1)
            {
                MessageBox.Show("Added successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmInforToExtend_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(rowIndex < 0)
            {
                MessageBox.Show("Please, choose one to delete!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if(dgvMember.Rows.Count<=1){
                MessageBox.Show("It needs at least person!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                db = new Database();
                var list = new List<CustomerParameter>() {
                new CustomerParameter()
                {
                    key = "@idContract",
                    value = idContractt
                },
                new CustomerParameter()
                {
                    key = "@idCustomer",
                    value = dgvMember.Rows[rowIndex].Cells["ID"].Value.ToString()
                }

            };
                var rs = db.ExeCute("MoveOnMem", list);
                if (rs == 1)
                {
                    MessageBox.Show("Moved on successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmInforToExtend_Load(sender, e);

                }
                else
                {
                    MessageBox.Show("Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
    }
}
