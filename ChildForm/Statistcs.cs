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
    public partial class Statistcs : Form
    {
        private Database db = new Database();
        private DataTable dt = new DataTable();
        public Statistcs()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateValue();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            updateValue();
        }
        private void updateValue()
        {
            db = new Database();
            dt = new DataTable();
            var list = new List<CustomerParameter>()
            {
                new CustomerParameter()
                {
                    key = "@in",
                    value = dtpStart.Value.ToString("yyyy-MM-dd")
                },
                new CustomerParameter()
                {
                    key = "@out",
                    value = dtpEnd.Value.ToString("yyyy-MM-dd")
                }
            };
            dt = db.SelectData("Revenue", list);
            var dt2 = db.SelectData("Statistics",list);
            if(dt.Rows.Count > 0 )
            {
                if(!string.IsNullOrEmpty(dt.Rows[0]["TotalSpent"].ToString()))
                lblRevenue.Text = string.Format("{0:N0} VND", int.Parse(dt.Rows[0]["TotalSpent"].ToString()));
                else lblRevenue.Text = string.Format("{0:N0} VND", "0");
            }
            else
            {
                lblRevenue.Text = string.Format("{0:N0} VND", "0");

            }
            if(dt2.Rows.Count > 0)
            {
                if(!string.IsNullOrEmpty(dt2.Rows[0]["TotalSpent"].ToString()))
                lbltop1.Text = string.Format("{0:N0} VND", int.Parse(dt2.Rows[0]["TotalSpent"].ToString()));
                else lbltop1.Text = string.Format("{0:N0} VND", "0");

                if(dt2.Rows.Count > 1)
                {
                    if (!string.IsNullOrEmpty(dt2.Rows[1]["TotalSpent"].ToString()))
                        lbltop2.Text = string.Format("{0:N0} VND", int.Parse(dt2.Rows[1]["TotalSpent"].ToString()));
                    else lbltop2.Text = string.Format("{0:N0} VND", "0");
                    lblCus2.Text = dt2.Rows[1]["Customer"].ToString();
                }

                if(dt2.Rows.Count > 2)
                {
                    if (!string.IsNullOrEmpty(dt2.Rows[2]["TotalSpent"].ToString()))
                        lblTop3.Text = string.Format("{0:N0} VND", int.Parse(dt2.Rows[2]["TotalSpent"].ToString()));
                    else lblTop3.Text = string.Format("{0:N0} VND", "0");
                    lblCus3.Text = dt2.Rows[2]["Customer"].ToString();
                }


                lblCus1.Text = dt2.Rows[0]["Customer"].ToString();
               
                
            }
            else
            {

                lbltop1.Text = string.Format("{0:N0} VND","0");
                lbltop2.Text = string.Format("{0:N0} VND", "0");
                lblTop3.Text = string.Format("{0:N0} VND", "0");
                lblCus1.Text = "???";
                lblCus2.Text = "???";
                lblCus3.Text = "???";
            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Statistcs_Load(sender, e);
        }

        private void Statistcs_Load(object sender, EventArgs e)
        {
              dt = db.SelectData("LoadStatistics");

            lblRevenue.Text = string.Format("{0:N0} VND", int.Parse(dt.Rows[0]["TotalSpent"].ToString()));
            lbltop1.Text = string.Format("{0:N0} VND", int.Parse(dt.Rows[1]["TotalSpent"].ToString()));
            lbltop2.Text = string.Format("{0:N0} VND", int.Parse(dt.Rows[2]["TotalSpent"].ToString()));
            lblTop3.Text = string.Format("{0:N0} VND", int.Parse(dt.Rows[3]["TotalSpent"].ToString()));
            lblCus1.Text = dt.Rows[1]["Customer"].ToString();
            lblCus2.Text = dt.Rows[2]["Customer"].ToString();
            lblCus3.Text = dt.Rows[3]["Customer"].ToString();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            updateValue();
        }
    }
}
