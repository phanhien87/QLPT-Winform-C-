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
    public partial class frmService : Form
    {
        private Database db;
        int id = -1;
        public frmService()
        {
            db = new Database();
            InitializeComponent();
        }
        private void loadService()
        {
            //var keyword = txtSearch.Text.Trim();

            db = new Database();
            var dt = db.SelectData("LoadService");

            dgvSe.DataSource = dt;
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            loadService();
            dgvSe.Columns[1].HeaderText = "Name Service";
            dgvSe.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            // if (txtNameService.Text.Trim().Length == 0)
            // {
            //     MessageBox.Show("Please enter name !", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     return;
            // }
            // var list = new List<CustomerParameter>
            //{
            //    new CustomerParameter()
            //    {
            //        key = "@name",
            //        value = txtNameService.Text

            //    }
            //};
            // if (db.ExeCute("AddService", list) == 1)
            // {
            //     MessageBox.Show("Added successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //     loadService();
            // }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadService();
        }

        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            // if (id < 0)
            // {
            //     MessageBox.Show("Please choose one!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     return;
            // }
            // if (txtNameService.Text.Trim().Length == 0)
            // {
            //     MessageBox.Show("Please enter name !", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     return;
            // }
            // var list = new List<CustomerParameter>
            //{
            //     new CustomerParameter()
            //     {
            //         key = "@id",
            //         value = id.ToString()
            //     },
            //    new CustomerParameter()
            //    {
            //        key = "@name",
            //        value = txtNameService.Text

            //    }

            //};
            // if (db.ExeCute("UpdateService", list) == 1)
            // {
            //     MessageBox.Show("Updated successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //     loadService();
            //     txtNameService.Text = null;
            //     id = -1;
            // }
        }

        private void dgvSe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = int.Parse(dgvSe.Rows[e.RowIndex].Cells[5].Value.ToString());
                txtDien.Text = dgvSe.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNuoc.Text = dgvSe.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            // if (id < 0)
            // {
            //     MessageBox.Show("Please choose one!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     return;
            // }
            // if(MessageBox.Show("Do you want to delete "+txtNameService.Text  +" ?","hehe",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            // {
            //     var list = new List<CustomerParameter>
            //{
            //     new CustomerParameter()
            //     {
            //         key = "@id",
            //         value = id.ToString()
            //     },


            //};
            //     if (db.ExeCute("DeleteService", list) == 1)
            //     {
            //         MessageBox.Show("Deleted successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //         loadService();
            //         txtNameService.Text = null;
            //         id = -1;
            //     }
            // }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db = new Database();
            
             if (id < 0)
            {
                MessageBox.Show("Please choose one!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Are you sure ?", "hehe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var list = new List<CustomerParameter>
            {
                 new CustomerParameter()
                 {
                     key = "@id",
                     value = id.ToString()
                 },
                 new CustomerParameter()
                 {
                     key = "@dien",
                     value = txtDien.Text
                 },
                 new CustomerParameter()
                 {
                     key = "@nuoc",
                     value = txtNuoc.Text
                 },


            };
                if (db.ExeCute("UpdateService", list) == 1)
                {
                    MessageBox.Show("Successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadService();
                    txtNuoc.Text = null;
                    txtDien.Text = null;
                    id = -1;
                }
            }
        }
    }
}
