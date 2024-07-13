namespace Ass_prn_QLPT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelRight = new Panel();
            panelBottom = new Panel();
            panelLeft = new Panel();
            panelTop = new Panel();
            label1 = new Label();
            ptbState = new PictureBox();
            ptbClose = new PictureBox();
            ptbMinimize = new PictureBox();
            grpContent = new GroupBox();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem1 = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            loaiphongToolStripMenuItem = new ToolStripMenuItem();
            phongToolStripMenuItem = new ToolStripMenuItem();
            dichvuToolStripMenuItem = new ToolStripMenuItem();
            tácVụToolStripMenuItem = new ToolStripMenuItem();
            thuêPhòngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            phòngĐangThuêToolStripMenuItem = new ToolStripMenuItem();
            phòngTrốngToolStripMenuItem = new ToolStripMenuItem();
            tiềnToolStripMenuItem = new ToolStripMenuItem();
            tiềnNướcToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            khachHangToolStripMenuItem = new ToolStripMenuItem();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimize).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelRight
            // 
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(790, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(10, 440);
            panelRight.TabIndex = 0;
            panelRight.Paint += panelRight_Paint;
            // 
            // panelBottom
            // 
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 440);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(800, 10);
            panelBottom.TabIndex = 1;
            // 
            // panelLeft
            // 
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 30);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 410);
            panelLeft.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(ptbState);
            panelTop.Controls.Add(ptbClose);
            panelTop.Controls.Add(ptbMinimize);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(790, 30);
            panelTop.TabIndex = 1;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 3;
            label1.Text = "Quan Ly phong Tro";
            label1.Click += label1_Click;
            // 
            // ptbState
            // 
            ptbState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbState.Cursor = Cursors.Hand;
            ptbState.Image = Properties.Resources.maxi1;
            ptbState.Location = new Point(738, 7);
            ptbState.Name = "ptbState";
            ptbState.Size = new Size(20, 20);
            ptbState.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbState.TabIndex = 2;
            ptbState.TabStop = false;
            ptbState.Click += ptbState_Click;
            // 
            // ptbClose
            // 
            ptbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbClose.Cursor = Cursors.Hand;
            ptbClose.Image = Properties.Resources.close;
            ptbClose.Location = new Point(764, 7);
            ptbClose.Name = "ptbClose";
            ptbClose.Size = new Size(20, 20);
            ptbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbClose.TabIndex = 1;
            ptbClose.TabStop = false;
            ptbClose.Click += ptbClose_Click;
            // 
            // ptbMinimize
            // 
            ptbMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbMinimize.Cursor = Cursors.Hand;
            ptbMinimize.Image = Properties.Resources.minimazar;
            ptbMinimize.Location = new Point(712, 7);
            ptbMinimize.Name = "ptbMinimize";
            ptbMinimize.Size = new Size(20, 20);
            ptbMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMinimize.TabIndex = 0;
            ptbMinimize.TabStop = false;
            ptbMinimize.Click += ptbMinimize_Click;
            // 
            // grpContent
            // 
            grpContent.Dock = DockStyle.Fill;
            grpContent.Location = new Point(10, 54);
            grpContent.Name = "grpContent";
            grpContent.Size = new Size(780, 386);
            grpContent.TabIndex = 2;
            grpContent.TabStop = false;
            grpContent.Enter += groupBox1_Enter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, tácVụToolStripMenuItem, thốngKêToolStripMenuItem, thôngTinToolStripMenuItem });
            menuStrip1.Location = new Point(10, 30);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(780, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "Hệ thóng";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, thoátToolStripMenuItem, thoátToolStripMenuItem1 });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(69, 20);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(180, 22);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(180, 22);
            thoátToolStripMenuItem.Text = "Cấu hình";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click_1;
            // 
            // thoátToolStripMenuItem1
            // 
            thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            thoátToolStripMenuItem1.Size = new Size(180, 22);
            thoátToolStripMenuItem1.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loaiphongToolStripMenuItem, phongToolStripMenuItem, dichvuToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(74, 20);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // loaiphongToolStripMenuItem
            // 
            loaiphongToolStripMenuItem.Name = "loaiphongToolStripMenuItem";
            loaiphongToolStripMenuItem.Size = new Size(180, 22);
            loaiphongToolStripMenuItem.Text = "Loại phòng";
            loaiphongToolStripMenuItem.Click += loaiphongToolStripMenuItem_Click;
            // 
            // phongToolStripMenuItem
            // 
            phongToolStripMenuItem.Name = "phongToolStripMenuItem";
            phongToolStripMenuItem.Size = new Size(180, 22);
            phongToolStripMenuItem.Text = "Phòng";
            phongToolStripMenuItem.Click += phongToolStripMenuItem_Click;
            // 
            // dichvuToolStripMenuItem
            // 
            dichvuToolStripMenuItem.Name = "dichvuToolStripMenuItem";
            dichvuToolStripMenuItem.Size = new Size(180, 22);
            dichvuToolStripMenuItem.Text = "Dịch vụ";
            dichvuToolStripMenuItem.Click += dichvuToolStripMenuItem_Click;
            // 
            // tácVụToolStripMenuItem
            // 
            tácVụToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thuêPhòngToolStripMenuItem });
            tácVụToolStripMenuItem.Name = "tácVụToolStripMenuItem";
            tácVụToolStripMenuItem.Size = new Size(52, 20);
            tácVụToolStripMenuItem.Text = "Tác vụ";
            // 
            // thuêPhòngToolStripMenuItem
            // 
            thuêPhòngToolStripMenuItem.Name = "thuêPhòngToolStripMenuItem";
            thuêPhòngToolStripMenuItem.Size = new Size(138, 22);
            thuêPhòngToolStripMenuItem.Text = "Thuê phòng";
            thuêPhòngToolStripMenuItem.Click += thuêPhòngToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phòngĐangThuêToolStripMenuItem, phòngTrốngToolStripMenuItem, tiềnToolStripMenuItem, tiềnNướcToolStripMenuItem, doanhThuToolStripMenuItem });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(68, 20);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // phòngĐangThuêToolStripMenuItem
            // 
            phòngĐangThuêToolStripMenuItem.Name = "phòngĐangThuêToolStripMenuItem";
            phòngĐangThuêToolStripMenuItem.Size = new Size(166, 22);
            phòngĐangThuêToolStripMenuItem.Text = "Phòng đang thuê";
            // 
            // phòngTrốngToolStripMenuItem
            // 
            phòngTrốngToolStripMenuItem.Name = "phòngTrốngToolStripMenuItem";
            phòngTrốngToolStripMenuItem.Size = new Size(166, 22);
            phòngTrốngToolStripMenuItem.Text = "Phòng Trống";
            // 
            // tiềnToolStripMenuItem
            // 
            tiềnToolStripMenuItem.Name = "tiềnToolStripMenuItem";
            tiềnToolStripMenuItem.Size = new Size(166, 22);
            tiềnToolStripMenuItem.Text = "Tiền điện";
            // 
            // tiềnNướcToolStripMenuItem
            // 
            tiềnNướcToolStripMenuItem.Name = "tiềnNướcToolStripMenuItem";
            tiềnNướcToolStripMenuItem.Size = new Size(166, 22);
            tiềnNướcToolStripMenuItem.Text = "Tiền nước";
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(166, 22);
            doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khachHangToolStripMenuItem });
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(70, 20);
            thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // khachHangToolStripMenuItem
            // 
            khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            khachHangToolStripMenuItem.Size = new Size(139, 22);
            khachHangToolStripMenuItem.Text = "Khach Hang";
            khachHangToolStripMenuItem.Click += khachHangToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(grpContent);
            Controls.Add(menuStrip1);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Controls.Add(panelRight);
            Controls.Add(panelBottom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phan Mem Quan Ly Tro";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbState).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimize).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRight;
        private Panel panelBottom;
        private Panel panelLeft;
        private Panel panelTop;
        private GroupBox grpContent;
        private PictureBox ptbState;
        private PictureBox ptbClose;
        private PictureBox ptbMinimize;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem1;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem loaiphongToolStripMenuItem;
        private ToolStripMenuItem phongToolStripMenuItem;
        private ToolStripMenuItem dichvuToolStripMenuItem;
        private ToolStripMenuItem tácVụToolStripMenuItem;
        private ToolStripMenuItem thuêPhòngToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem phòngĐangThuêToolStripMenuItem;
        private ToolStripMenuItem phòngTrốngToolStripMenuItem;
        private ToolStripMenuItem tiềnToolStripMenuItem;
        private ToolStripMenuItem tiềnNướcToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem khachHangToolStripMenuItem;
    }
}
