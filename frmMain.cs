using Ass_prn_QLPT.ChildForm;
using System.ComponentModel;

namespace Ass_prn_QLPT
{

    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var f = new frmWelcome();
            AddForm(f);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbState_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                ptbState.Image = Properties.Resources.normal1;


            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                ptbState.Image = Properties.Resources.maxx;
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddForm(Form form)
        {
            this.grpContent.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.Text = form.Text;
            this.grpContent.Controls.Add(form);
            form.Show();
        }

        private void hệToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loaiphongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmTypeRoom();
            AddForm(f);
        }

        private void phongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmRoom();
            AddForm(f);
        }

        private void dichvuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmThuePhong();
            AddForm(f);
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmCustomer();
            AddForm(f);
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var f = new frmService();
            AddForm(f);
        }
    }
}
