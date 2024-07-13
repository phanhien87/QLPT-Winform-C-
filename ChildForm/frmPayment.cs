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
    public partial class frmPayment : Form
    {
        private string idThuePhong;
        private Database db;
        private int csdcu, csncu;
        DataRow dt;
        public frmPayment(string id)
        {
           
            this.idThuePhong = id;
            InitializeComponent();
        }


        private void frmPayment_Load(object sender, EventArgs e)
        {
            loadPayMent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void grpContent_Enter(object sender, EventArgs e)
        {

        }

        private void loadPayMent()
        {
            db = new Database();
            var list = new List<CustomerParameter>()
            {
                new CustomerParameter()
                {
                    key = "@id",
                    value = idThuePhong

                }
            };
            dt = db.SelectData("loadPayment", list).Rows[0];

            lblNameRoom.Text = dt["TenPhong"].ToString();
            lblPriceRoom.Text = dt["GiaPhong"].ToString();
            lblPriceRoom.Text = string.Format("{0:N0} VND", int.Parse(dt["GiaPhong"].ToString()));
            lblWaterprice.Text = string.Format("{0:N0} VND", int.Parse(dt["TienNuoc"].ToString()));
            lblEprice.Text = string.Format("{0:N0} VND", int.Parse(dt["TienDien"].ToString()));
            lblWifi.Text = string.Format("{0:N0} VND", int.Parse(dt["TienMang"].ToString()));
            lblccPrice.Text = string.Format("{0:N0} VND", int.Parse(dt["TienVS"].ToString()));
            lblAccPay.Text = string.Format("{0:N0} VND", int.Parse(dt["TongTienPhaiTra"].ToString()));
            lblDebit.Text = string.Format("{0:N0} VND", int.Parse(dt["SoNoPhaiTra"].ToString()));
            lblTotalPrice.Text = string.Format("{0:N0} VND", int.Parse(dt["Total"].ToString()));
        }

        private void txtPayment_KeyUp(object sender, KeyEventArgs e)
        {
            lblRemainder.Text = string.Format("{0:N0} VND", int.Parse(dt["TongTienPhaiTra"].ToString()) - int.Parse(txtPayment.Text));
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            db = new Database();
            var list = new List<CustomerParameter>()
            {
                new CustomerParameter()
                {
                    key = "id",
                    value = idThuePhong
                },
                new CustomerParameter()
                {
                    key = "money",
                    value = txtPayment.Text
                }
            };
            var rs = db.ExeCute("Payment", list);
            if (rs == 1)
            {
                var listKH = new List<CustomerParameter>()
                {
                    new CustomerParameter()
                    {
                        key = "@id",
                        value = idThuePhong
                    },
                    new CustomerParameter()
                    {
                        key = "@dien",
                        value = dt["TienDien"].ToString()
                    },
                    new CustomerParameter()
                    {
                        key = "@nuoc",
                        value = dt["TienNuoc"].ToString()
                    },
                    new CustomerParameter()
                    {
                        key = "@vs",
                        value = dt["TienVS"].ToString()
                    },
                    new CustomerParameter()
                    {
                        key = "@wifi",
                        value = dt["TienMang"].ToString()
                    },
                    new CustomerParameter()
                    {
                        key = "@paid",
                        value = txtPayment.Text
                    },
                    new CustomerParameter()
                    {
                        key = "@total",
                        value = dt["Total"].ToString()
                    },
                    
                };
                if (db.ExeCute("Bill", listKH) >= 1) {
                    var list2 = new List<CustomerParameter>()
                {
                    new CustomerParameter()
                    {
                        key = "@id",
                        value = idThuePhong
                    }
                };
                    var rs2 = db.ExeCute("Extend", list2);
                    if (rs2 == 1)
                    {
                        MessageBox.Show("Extend has been successful!", "Sucessfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Extending has been fail!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Bill has been fail!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Dispose();
                }



                

               
            }
            else
            {
                MessageBox.Show("Payment has been fail!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] money = lblAccPay.Text.Split(' ');
            new FrmCheck_out(idThuePhong, int.Parse(money[0].Replace(",", "")), dt["TienDien"].ToString(), dt["TienNuoc"].ToString()
                , dt["TienMang"].ToString(), dt["TienVS"].ToString(), dt["Total"].ToString()).ShowDialog();
        }
    }
}
