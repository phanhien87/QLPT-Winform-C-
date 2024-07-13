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
    public partial class FrmCheck_out : Form
    {
        private string idContract,dienn,nuocc,wifii,vss,dtt,totall;
        private Database db;
        private int totalmoney;
        
        public FrmCheck_out(string id,int accpay,string dien,string nuoc,string wifi,string vs,string total)
        {
            InitializeComponent();
            this.dienn = dien;
            this.nuocc = nuoc;
            this.wifii = wifi;
            this.vss = vs;
            
            this.totall = total;
            this.idContract = id;
            this.totalmoney = accpay;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmCheck_out_Load(object sender, EventArgs e)
        {
            db = new Database();
            var list = new List<CustomerParameter>()
            {
                new CustomerParameter()
                {
                    key = "@id",
                    value = idContract
                },
                new CustomerParameter()
                {
                    key ="@accpay",
                    value = totalmoney.ToString()
                }
            };
            var dt = db.SelectData("chothopdong", list);
            //txtDebit.Text = dt.Rows[0]["debit"].ToString();
            txtDebit.Text = string.Format("{0:N0} VND", int.Parse(dt.Rows[0]["debit"].ToString()));
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            db = new Database();
            if (txtPayment.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter payment!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] debitt = txtPayment.Text.Split(' ');
            var debit = int.Parse(debitt[0].Replace(",", ""));
            var payment = int.Parse(txtPayment.Text);
            if (MessageBox.Show("Are you sure!", "hehe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK) ;
            {
                if (debit > payment)
                {
                    MessageBox.Show("The payment is not enough to repay the debt!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var list = new List<CustomerParameter>()
                    {
                        new CustomerParameter()
                        {
                            key = "@id",
                            value = idContract
                        },
                        new CustomerParameter()
                        {
                            key = "money",
                            value = payment.ToString()
                        }
                    };
                    var rs = db.ExeCute("payAndEnd", list);
                    if (rs >= 1)
                    {
                        var listKH = new List<CustomerParameter>()
                {
                    new CustomerParameter()
                    {
                        key = "@id",
                        value = idContract
                    },
                    new CustomerParameter()
                    {
                        key = "@dien",
                        value = dienn
                    },
                    new CustomerParameter()
                    {
                        key = "@nuoc",
                        value = nuocc
                    },
                    new CustomerParameter()
                    {
                        key = "@vs",
                        value = vss
                    },
                    new CustomerParameter()
                    {
                        key = "@wifi",
                        value = wifii
                    },
                    new CustomerParameter()
                    {
                        key = "@paid",
                        value = txtPayment.Text
                    },
                    new CustomerParameter()
                    {
                        key = "@total",
                        value = totall
                    },

                };

                        if (db.ExeCute("Bill", listKH) == 1)
                        {
                            MessageBox.Show("Done!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Bill has been fail!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Check-out has been fail!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
