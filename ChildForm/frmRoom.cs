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
    public partial class frmRoom : Form
    {
        private Database db;

        private int rowindext = -1;

        public frmRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            new frmForRoom(null).ShowDialog();

            loadroom();

        }

        private void loadroom()
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
            var dt = db.SelectData("LoadRoom", list);
            dgvRoom.ForeColor = Color.Black;
            dgvRoom.DataSource = dt;
            var dtSP = db.SelectData("statisticRoom");
            lblFull.Text = dtSP.Rows[1]["Room"].ToString();
            lblReady.Text = dtSP.Rows[0]["Room"].ToString();
            txtNote.Text = dtSP.Rows[2]["Room"].ToString();
            lblTotal.Text = (int.Parse(dtSP.Rows[1]["Room"].ToString()) + int.Parse(dtSP.Rows[0]["Room"].ToString())).ToString();
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            loadroom();
            dgvRoom.Columns["tenloaiphong"].HeaderText = "Type Room";
            dgvRoom.Columns["tenphong"].HeaderText = "Name";
            dgvRoom.Columns["dongia"].HeaderText = "Price";

            dgvRoom.Columns["id"].Width = 100;
            dgvRoom.Columns["tenloaiphong"].Width = 100;
            dgvRoom.Columns["dongia"].Width = 100;
            dgvRoom.Columns["status"].Width = 100;

            dgvRoom.Columns["tenphong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvRoom.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvRoom.Columns["dongia"].DefaultCellStyle.Format = "N0";

        }

        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvRoom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rentedRoom = dgvRoom.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            if (rentedRoom.ToLower().Equals("full"))
            {
                MessageBox.Show("Room is being full!!","hehe",MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            var idRoom = dgvRoom.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            new frmForRoom(idRoom).ShowDialog();

            loadroom();

        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (rowindext < 0)
            {
                MessageBox.Show("Please, choose one to delete!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Do you want change to " + btnDeleteRoom.Text.ToLower() + " for room " + dgvRoom.Rows[rowindext].Cells["tenphong"].Value.ToString() + "?", "hehe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var list = new List<CustomerParameter>() {

                    new CustomerParameter()
                    {
                        key = "@id",
                        value = dgvRoom.Rows[rowindext].Cells["ID"].Value.ToString()
                    }
                };
                var rs = db.ExeCute("Note", list);
                if (rs == 1)
                {
                    MessageBox.Show("Done successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadroom();
                }
                else
                {
                    MessageBox.Show("Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindext = e.RowIndex;

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtNote_Click(object sender, EventArgs e)
        {

        }
    }
}
