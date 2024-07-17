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
    public partial class frmLogin : Form
    {
        private Database db = new Database();
        public frmLogin()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAcc.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Please, enter your account and password!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var list = new List<CustomerParameter>()
                {
                    new CustomerParameter()
                    {
                        key ="@acc",
                        value = txtAcc.Text,
                    },
                    new CustomerParameter()
                    {
                        key = "@pass",
                        value = txtPass.Text,
                    }
                };
                DataTable dt = db.SelectData("[login]", list);
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Your account and password are not valid !", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dt.Rows[0]["TaiKhoan"].ToString().Equals(txtAcc.Text) && dt.Rows[0]["MatKhau"].ToString().Equals(txtPass.Text))
                {
                    this.Dispose();
                }

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picshoweye.Visible = true;
            pictureBox1.Visible = false;
            txtPass.UseSystemPasswordChar = true;
        }

        private void picshoweye_Click(object sender, EventArgs e)
        {
            picshoweye.Visible = false;
            pictureBox1.Visible = true;
            txtPass.UseSystemPasswordChar = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
