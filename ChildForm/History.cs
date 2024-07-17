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
    public partial class History : Form
    {
        Database db = new Database();
        public History()
        {
            InitializeComponent();
        }
        private void loadHistory()
        {
            db = new Database();
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
            var dt = db.SelectData("loadHistory", list);
            dgvHistory.ForeColor = Color.Black;
            dgvHistory.DataSource = dt;

        }

        private void History_Load(object sender, EventArgs e)
        {
            loadHistory();
            dgvHistory.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHistory.Columns["Total"].DefaultCellStyle.Format = "N0";
            dgvHistory.Columns["Paid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHistory.Columns["Paid"].DefaultCellStyle.Format = "N0";
            dgvHistory.Columns["RoomPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHistory.Columns["RoomPrice"].DefaultCellStyle.Format = "N0";
            dgvHistory.Columns["UpfrontPayment"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHistory.Columns["UpfrontPayment"].DefaultCellStyle.Format = "N0";
            dgvHistory.Columns["IDContractDetail"].Width = 40;
            dgvHistory.Columns["ID"].Width = 40;
            dgvHistory.Columns["Dien"].Width = 50;
            dgvHistory.Columns["Nuoc"].Width = 50;
            dgvHistory.Columns["VS"].Width = 50;
            dgvHistory.Columns["Wifi"].Width = 50;
            dgvHistory.Columns["customer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            if (dtpIn.Value <= dtpOut.Value)
            {
                db = new Database();
                var list = new List<CustomerParameter>()
            {
                new CustomerParameter()
                {
                    key = "@in",
                    value = dtpIn.Value.ToString("yyyy-MM-dd"),
                },
                new CustomerParameter()
                {
                    key="@out",
                    value = dtpOut.Value.ToString("yyyy-MM-dd"),
                }
            };
                dgvHistory.DataSource = db.SelectData("searchByTime", list);
                dgvHistory.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Check-in date must be less than Check-out date!", "???", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            if (dtpIn.Value <= dtpOut.Value)
            {
                db = new Database();
                var list = new List<CustomerParameter>()
            {
                new CustomerParameter()
                {
                    key = "@in",
                    value = dtpIn.Value.ToString("yyyy-MM-dd"),
                },
                new CustomerParameter()
                {
                    key="@out",
                    value = dtpOut.Value.ToString("yyyy-MM-dd"),
                }
            };
                dgvHistory.DataSource = db.SelectData("searchByTime", list);
                dgvHistory.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Check-in date must be less than Check-out date!", "???", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadHistory();
        }
    }
}
