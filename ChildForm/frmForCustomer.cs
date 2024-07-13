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
    public partial class frmForCustomer : Form
    {
        private string idCustomer;
        private Database db;
        public frmForCustomer(string idCustomerr)
        {
            this.idCustomer = idCustomerr;

            InitializeComponent();

        }

        private void grpContent_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            db = new Database();
            var firstname = txtFirst.Text.Trim();
            var lastname = txtLast.Text.Trim();
            var midname = txtMid.Text.Trim();
            var cmnd = txtCMND.Text.Trim();
            var numberphone = txtDT.Text.Trim();
            var address = txtQQ.Text.Trim();
            var PA = txtHk.Text.Trim();
            if (string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(midname) ||
                    string.IsNullOrEmpty(PA) || string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(numberphone)
                    )
            {
                MessageBox.Show("Plsease, fill full !", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(idCustomer))
            {

                var list = new List<CustomerParameter>() {
                    new CustomerParameter()
                    {
                        key = "@ho",
                        value = lastname
                    },
                    new CustomerParameter()
                    {
                        key = "@dem",
                        value = midname
                    },
                    new CustomerParameter()
                    {
                        key = "@ten",
                        value = firstname
                    },
                    new CustomerParameter()
                    {
                        key = "@cmnd",
                        value = cmnd
                    },
                    new CustomerParameter()
                    {
                        key = "@sdt",
                        value = numberphone
                    },
                    new CustomerParameter()
                    {
                        key = "@qq",
                        value = address
                    },
                    new CustomerParameter()
                    {
                        key = "@hk",
                        value = PA
                    },
                };
                var rs = db.ExeCute("addCustomer", list);
                if (rs == 1)
                {
                    MessageBox.Show("Added successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {

                var list = new List<CustomerParameter>() {
                     new CustomerParameter()
                    {
                        key = "@id",
                        value = idCustomer
                    },
                    new CustomerParameter()
                    {
                        key = "@ho",
                        value = lastname
                    },
                    new CustomerParameter()
                    {
                        key = "@dem",
                        value = midname
                    },
                    new CustomerParameter()
                    {
                        key = "@ten",
                        value = firstname
                    },
                    new CustomerParameter()
                    {
                        key = "@cmnd",
                        value = cmnd
                    },
                    new CustomerParameter()
                    {
                        key = "@sdt",
                        value = numberphone
                    },
                    new CustomerParameter()
                    {
                        key = "@qq",
                        value = address
                    },
                    new CustomerParameter()
                    {
                        key = "@hk",
                        value = PA
                    },
                };
                var rs = db.ExeCute("updateCustomer", list);
                if (rs == 1)
                {
                    MessageBox.Show("updated successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        private void labelCustomer_Click(object sender, EventArgs e)
        {

        }

        private void frmForCustomer_Load(object sender, EventArgs e)
        {
            db = new Database();
            if (string.IsNullOrEmpty(idCustomer))
            {
                labelCustomer.Text = "Adding Customer";
            }
            else
            {
                labelCustomer.Text = "Updating Customer";
                var list = new List<CustomerParameter>()
                {
                    new CustomerParameter()
                    {
                        key = "@id",
                        value = idCustomer
                    }
                };
                var rs = db.SelectData("findCustomerById", list).Rows[0];
                txtFirst.Text = rs["ten"].ToString();
                txtLast.Text = rs["ho"].ToString();
                txtMid.Text = rs["tendem"].ToString();
                txtCMND.Text = rs["cmnd_cancuoc"].ToString();
                txtDT.Text = rs["dienthoai"].ToString();
                txtQQ.Text = rs["quequan"].ToString();
                txtHk.Text = rs["hktt"].ToString();
            }
        }
    }
}