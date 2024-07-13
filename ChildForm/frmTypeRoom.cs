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
    public partial class frmTypeRoom : Form
    {
        Database db = new Database();
        private int idType;
        private int confirm = 0;

        public frmTypeRoom()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddType_Click(object sender, EventArgs e)
        {

            confirm = 1;
            txtNameTypeRoom.Text = null;
            txtPriceTypeRoom.Text = "0";

            txtNameTypeRoom.ReadOnly = false;
            txtPriceTypeRoom.ReadOnly = false;

            btnAddType.Enabled = btnUpdate.Enabled = false;
            btnSave.Enabled = true;

        }

        private void LoadTypeRoom()
        {

            dgvLoadTypeRoom.DataSource = db.SelectData("loadTypeRoom");
        }

        private void frmLoadRoom_Load(object sender, EventArgs e)
        {
            btnAddType.Enabled = btnUpdate.Enabled = true;
            btnSave.Enabled = false;

            LoadTypeRoom();
            dgvLoadTypeRoom.Columns[0].Width = 100;
            dgvLoadTypeRoom.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLoadTypeRoom.Columns[0].HeaderText = "ID Type";

            dgvLoadTypeRoom.Columns[2].Width = 200;
            dgvLoadTypeRoom.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLoadTypeRoom.Columns[2].DefaultCellStyle.Format = "N0";
            dgvLoadTypeRoom.Columns[2].HeaderText = "Price";

            dgvLoadTypeRoom.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLoadTypeRoom.Columns[1].HeaderText = "Room type name";

            txtNameTypeRoom.ReadOnly = true;
            txtPriceTypeRoom.ReadOnly = true;
        }

        private void dgvLoadTypeRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLoadTypeRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idType = int.Parse(dgvLoadTypeRoom.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNameTypeRoom.Text = dgvLoadTypeRoom.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPriceTypeRoom.Text = dgvLoadTypeRoom.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            confirm = 0;
            txtNameTypeRoom.ReadOnly = false;
            txtPriceTypeRoom.ReadOnly = false;

            btnAddType.Enabled = btnUpdate.Enabled = false;
            btnSave.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            var name = txtNameTypeRoom.Text;
            var price = int.Parse(txtPriceTypeRoom.Text);

            if (idType == 0 || idType == null)
            {
                MessageBox.Show("Please, choose one to execute function", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please, enter again room name", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (price < 0)
            {

                MessageBox.Show("Please, enter again price room", "Must more than 0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var list = new List<CustomerParameter>();

            if (confirm == 1)
            {
                list.Add(new CustomerParameter
                {
                    key = "@name",
                    value = name

                });
                list.Add(new CustomerParameter
                {
                    key = "@price",
                    value = price.ToString()

                });
                var rs = db.ExeCute("addTypeRoom", list);
                if (rs == 1)
                {
                    MessageBox.Show("Added successfully!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else if (confirm == 0)
            {
                list.Add(new CustomerParameter
                {
                    key = "@id",
                    value = idType.ToString(),

                });
                list.Add(new CustomerParameter
                {
                    key = "@name",
                    value = name

                });
                list.Add(new CustomerParameter
                {
                    key = "@price",
                    value = price.ToString()

                });
                var rs = db.ExeCute("updateTypeRoom", list);
                if (rs == 1)
                {
                    MessageBox.Show("updated successfully!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            LoadTypeRoom();
            txtNameTypeRoom.Text = null;
            txtPriceTypeRoom.Text = "0";

            btnAddType.Enabled = btnUpdate.Enabled = true;
            btnSave.Enabled = false;





        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (idType == 0)
            {
                MessageBox.Show("Please,choose one to delete","hehe",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(MessageBox.Show("Are you sure your decision","Wacth out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var list = new List<CustomerParameter>
                {
                    new CustomerParameter()
                    {
                        key = "@id",
                        value = idType.ToString(),
                    }
                };
                var rs = db.ExeCute("deleteTypeRoom", list);
                if (rs == 1)
                {
                    MessageBox.Show("Deleted successfully!","Successfully!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadTypeRoom();
                    idType = 0;
                    txtNameTypeRoom.Text = null;
                    txtPriceTypeRoom.Text = "0";
                }
            }
        }
    }
}
