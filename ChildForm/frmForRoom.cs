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
    public partial class frmForRoom : Form
    {
        Database db;
        string idRoom;

        public frmForRoom(string idRoomm)
        {
            this.idRoom = idRoomm;
            InitializeComponent();

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void frmForRoom_Load(object sender, EventArgs e)
        {

        }
        private void LoadTypeRoom()
        {
            var dt = db.SelectData("loadTypeRoom");
            cbbTypeRoom.DataSource = dt;
            cbbTypeRoom.DisplayMember = "TenLoaiPhong";
            cbbTypeRoom.ValueMember = "ID";
        }
        private void grpContent_Enter(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbbTypeRoom.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose one!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            var idTypeRoom = cbbTypeRoom.SelectedValue.ToString();
            var name = txtNameRoom.Text;
            var status = ckbStatus.Checked ? 1 : 0;
            var note = 0;
            if (rdbHiding.Checked)
            {
                note = 0;
            }
            if (rdbShowing.Checked)
            {
                note = 1;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Plsease, fill name to input!", "hehe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(idRoom))
            {
                var list = new List<CustomerParameter>()
                {
                    new CustomerParameter()
                    {
                        key = "@id",
                        value = idTypeRoom
                    },
                    new CustomerParameter()
                    {
                        key = "@name",
                        value = name
                    },
                    new CustomerParameter()
                    {
                        key = "@status",
                        value = status.ToString()
                    },
                    new CustomerParameter()
                    {
                        key ="@note",
                        value = note.ToString()
                    }
                };
                var rs = db.ExeCute("AddNewRoom", list);
                if (rs == 1)
                {
                    MessageBox.Show("Added successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                var list = new List<CustomerParameter>()
                {
                    new CustomerParameter()
                    {
                        key = "@id",
                        value = idRoom
                    },
                    new CustomerParameter()
                    {
                        key = "@name",
                        value = name
                    },
                    new CustomerParameter()
                    {
                        key = "@status",
                        value = status.ToString()
                    },
                    new CustomerParameter()
                    {
                        key ="@idType",
                        value = idTypeRoom
                    }
                };
                var rs = db.ExeCute("updateRoom", list);
                if (rs == 1)
                {
                    MessageBox.Show("Updated successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
        }

        private void cbbTypeRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmForRoom_Load_1(object sender, EventArgs e)
        {
            db = new Database();
            LoadTypeRoom();
            if (string.IsNullOrEmpty(idRoom))
            {
                label5.Text = "Adding Room";
            }
            else
            {
                label5.Text = "Updaing Room";
                var list = new List<CustomerParameter>()
                {
                    new CustomerParameter()
                    {
                        key = "@id",
                        value = idRoom
                    }
                };
                var rs = db.SelectData("findRoomById", list).Rows[0];
                cbbTypeRoom.SelectedValue = rs["IDLoaiPhong"].ToString();
                txtNameRoom.Text = rs["TenPhong"].ToString();
                if (rs["TrangThai"].ToString() == "1")
                {
                    ckbStatus.Checked = true;
                }
                else
                {
                    ckbStatus.Checked = false;
                }
                if (rs["Note"].ToString() == "1")
                {
                    rdbShowing.Checked = true;
                }
                else
                {
                    rdbHiding.Checked = true;
                }


            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
