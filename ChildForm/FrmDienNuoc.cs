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
    public partial class FrmDienNuoc : Form
    {
        private string idRoom;
        private int csdcu, csncu;
        private Database db;
        public FrmDienNuoc(string idRoomm, int csd_cu, int csn_cu)
        {
            
            InitializeComponent();
            this.idRoom = idRoomm;
            this.csdcu = csd_cu;
            this.csncu = csn_cu;
            this.Enabled = true;
            this.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            db = new Database();
            int CSD_Moi = int.Parse(txtNewE.Text.Trim());
            int CSN_Moi = int.Parse(txtNewW.Text.Trim());
            if (CSD_Moi < csdcu)
            {
                MessageBox.Show("New electricity must be greater than the old electricity number!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewE.Select();
            }
            if (CSN_Moi < csncu)
            {
                MessageBox.Show("New water must be greater than the old water number!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewE.Select();
            }
            var list = new List<CustomerParameter>() { 
                new CustomerParameter()
                {
                    key = "@id",
                    value = idRoom.ToString(),
                },
                new CustomerParameter()
                {
                    key = "@dien",
                    value = CSD_Moi.ToString()
                },
                new CustomerParameter()
                {
                    key = "@nuoc",
                    value = CSN_Moi.ToString()
                }
            };
            var rs = db.ExeCute("DienNuoc", list);
            if (rs == 1) { 
            
                this.Dispose();
                new frmPayment(idRoom).ShowDialog();
            }
            else
            {
                MessageBox.Show("Failed!","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
        }

        private void FrmDienNuoc_Load(object sender, EventArgs e)
        {
           txtOldE.Text = csdcu.ToString();
            txtOldW.Text = csncu.ToString();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
