using Ass_prn_QLPT.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass_prn_QLPT
{
    public partial class frmThuePhong : Form
    {
        private Database db;
        public frmThuePhong()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            new frmForRentalRoom().ShowDialog();
            loadRentalRoom();

        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            loadRentalRoom();

            //dgvRentalRoom.Columns["tenphong"].Width = 50;
            //dgvRentalRoom.Columns["tenloaiphong"].Width = 80;
            //dgvRentalRoom.Columns["namecustomer"].Width = 100;
            //dgvRentalRoom.Columns["dienthoai"].Width = 100;
            //dgvRentalRoom.Columns["CMND_cancuoc"].Width = 100;
            //dgvRentalRoom.Columns["HKTT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvRentalRoom.Columns["ngaythue"].Width = 70;
            //dgvRentalRoom.Columns["ngaytraphong"].Width = 70;
            //dgvRentalRoom.Columns["dienthoai"].Width = 100;


            //dgvRentalRoom.Columns["tiendatcoc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvRentalRoom.Columns["tiendatcoc"].DefaultCellStyle.Format = "N0";
        }
        private void loadRentalRoom()
        {
            var list = new List<CustomerParameter>() {
                new CustomerParameter()
                {
                    key = "@keyword",
                    value = txtSearchRentalRoom.Text
                }

            };
            dgvRentalRoom.AutoGenerateColumns = false;
            dgvRentalRoom.DataSource = db.SelectData("LoadRentalRoom", list);
            dgvRentalRoom.ForeColor = Color.Black;
           
        }

        private void dgvRentalRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime d = DateTime.Now;
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == dgvRentalRoom.Columns["btnThanhToan"].Index)
                {
                    var idThuephong = dgvRentalRoom.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    var CSD_Cu = int.Parse(dgvRentalRoom.Rows[e.RowIndex].Cells["CSD_Cu"].Value.ToString());
                    var CSN_Cu = int.Parse(dgvRentalRoom.Rows[e.RowIndex].Cells["CSN_Cu"].Value.ToString());
                    var checkout = dgvRentalRoom.Rows[e.RowIndex].Cells["txtCheckout"].Value;
                    
                    //if(checkout != null && DateTime.TryParse(checkout.ToString(), out DateTime checkouttt))
                    //{
                    //    if (checkouttt <= d)
                    //    {
                            new FrmDienNuoc(idThuephong, CSD_Cu, CSN_Cu).ShowDialog();
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("The check-out date has not yet reached!","hehe",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    //    }
                       
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //}


                    loadRentalRoom();

                }
                if(e.ColumnIndex == dgvRentalRoom.Columns["addMember"].Index)
                {
                    var idContract = dgvRentalRoom.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    var nameRoom = dgvRentalRoom.Rows[e.RowIndex].Cells["txtNamRoom"].Value.ToString();

                    new frmInforToExtend(idContract,nameRoom).ShowDialog();
                }

            
                
            }
        }

        private void dgvRentalRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
