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
    public partial class frmCustomer : Form
    {
        private Database db;
        private int rowindext = -1;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            loadCustomer();

            dgvCustomer.Columns["id"].Width = 100;
            dgvCustomer.Columns["ho"].Width = 100;
            dgvCustomer.Columns["tendem"].Width = 100;
            dgvCustomer.Columns["ten"].Width = 100;
            dgvCustomer.Columns["cmnd_cancuoc"].Width = 100;
            dgvCustomer.Columns["dienthoai"].Width = 100;
            dgvCustomer.Columns["quequan"].Width = 100;
            dgvCustomer.Columns["hktt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }
        private void loadCustomer()
        {
            var keyword = txtSearch.Text.Trim();
            var list = new List<CustomerParameter>
            {
                new CustomerParameter()
                {
                    key = "@keyword",
                    value = keyword
                }
            };
            db = new Database();
            var dt = db.SelectData("loadCustomer", list);
            dgvCustomer.ForeColor = Color.Black;
            dgvCustomer.DataSource = dt;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindext = e.RowIndex;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (rowindext < 0)
            {
                MessageBox.Show("Please, choose one to delete!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Do you want to delete customer has numberphone: " + dgvCustomer.Rows[rowindext].Cells["dienthoai"].Value.ToString() + "?", "hehe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var list = new List<CustomerParameter>() {

                    new CustomerParameter()
                    {
                        key = "@id",
                        value = dgvCustomer.Rows[rowindext].Cells["ID"].Value.ToString()
                    }
                };
                var rs = db.ExeCute("deleteCustomer", list);
                if (rs == 1)
                {
                    MessageBox.Show("Done successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadCustomer();
                }
                else
                {
                    MessageBox.Show("Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadCustomer();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            new frmForCustomer(null).ShowDialog();
            loadCustomer();
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idCustomer = dgvCustomer.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            new frmForCustomer(idCustomer).ShowDialog();

            loadCustomer();
        }
    }
}
