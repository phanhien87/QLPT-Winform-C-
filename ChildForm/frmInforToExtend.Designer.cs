namespace Ass_prn_QLPT.ChildForm
{
    partial class frmInforToExtend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirm = new Button();
            btnDelete = new Button();
            panelBottom = new Panel();
            panelRight = new Panel();
            panelLeft = new Panel();
            lblNewWater = new Label();
            cbbCustomer = new ComboBox();
            dgvMember = new DataGridView();
            label1 = new Label();
            lblNameRoom = new Label();
            panelTop = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ptbState = new PictureBox();
            ptbClose = new PictureBox();
            ptbMinimize = new PictureBox();
            grpContent = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimize).BeginInit();
            grpContent.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Gray;
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirm.ForeColor = SystemColors.ControlLightLight;
            btnConfirm.Location = new Point(252, 147);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(87, 23);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Gray;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(345, 147);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Move on";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panelBottom
            // 
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(3, 341);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(581, 10);
            panelBottom.TabIndex = 14;
            // 
            // panelRight
            // 
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(574, 19);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(10, 322);
            panelRight.TabIndex = 11;
            // 
            // panelLeft
            // 
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(3, 19);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 322);
            panelLeft.TabIndex = 12;
            // 
            // lblNewWater
            // 
            lblNewWater.AutoSize = true;
            lblNewWater.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNewWater.ForeColor = SystemColors.ControlLightLight;
            lblNewWater.Location = new Point(121, 100);
            lblNewWater.Name = "lblNewWater";
            lblNewWater.Size = new Size(61, 15);
            lblNewWater.TabIndex = 27;
            lblNewWater.Text = "Customer";
            // 
            // cbbCustomer
            // 
            cbbCustomer.FormattingEnabled = true;
            cbbCustomer.Location = new Point(238, 97);
            cbbCustomer.Name = "cbbCustomer";
            cbbCustomer.Size = new Size(194, 23);
            cbbCustomer.TabIndex = 28;
            // 
            // dgvMember
            // 
            dgvMember.AllowUserToAddRows = false;
            dgvMember.AllowUserToDeleteRows = false;
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(12, 194);
            dgvMember.MultiSelect = false;
            dgvMember.Name = "dgvMember";
            dgvMember.ReadOnly = true;
            dgvMember.Size = new Size(562, 147);
            dgvMember.TabIndex = 29;
            dgvMember.CellClick += dgvMember_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(121, 61);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 30;
            label1.Text = "Room";
            // 
            // lblNameRoom
            // 
            lblNameRoom.AutoSize = true;
            lblNameRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNameRoom.ForeColor = SystemColors.ControlLightLight;
            lblNameRoom.Location = new Point(345, 61);
            lblNameRoom.Name = "lblNameRoom";
            lblNameRoom.Size = new Size(40, 15);
            lblNameRoom.TabIndex = 36;
            lblNameRoom.Text = "label4";
            lblNameRoom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(pictureBox5);
            panelTop.Controls.Add(pictureBox4);
            panelTop.Controls.Add(pictureBox3);
            panelTop.Controls.Add(pictureBox2);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(label5);
            panelTop.Controls.Add(ptbState);
            panelTop.Controls.Add(ptbClose);
            panelTop.Controls.Add(ptbMinimize);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(13, 19);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(561, 25);
            panelTop.TabIndex = 13;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.close;
            pictureBox5.Location = new Point(535, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.close;
            pictureBox4.Location = new Point(912, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.close;
            pictureBox3.Location = new Point(1418, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.i2;
            pictureBox2.Location = new Point(2002, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.i2;
            pictureBox1.Location = new Point(2462, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(9, 4);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 3;
            label5.Text = "Member";
            // 
            // ptbState
            // 
            ptbState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbState.Cursor = Cursors.Hand;
            ptbState.Image = Properties.Resources.maxx;
            ptbState.Location = new Point(3026, 7);
            ptbState.Name = "ptbState";
            ptbState.Size = new Size(20, 20);
            ptbState.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbState.TabIndex = 2;
            ptbState.TabStop = false;
            // 
            // ptbClose
            // 
            ptbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbClose.Cursor = Cursors.Hand;
            ptbClose.Image = Properties.Resources.i2;
            ptbClose.Location = new Point(3052, 7);
            ptbClose.Name = "ptbClose";
            ptbClose.Size = new Size(20, 20);
            ptbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbClose.TabIndex = 1;
            ptbClose.TabStop = false;
            // 
            // ptbMinimize
            // 
            ptbMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbMinimize.Cursor = Cursors.Hand;
            ptbMinimize.Image = Properties.Resources.min;
            ptbMinimize.Location = new Point(3000, 7);
            ptbMinimize.Name = "ptbMinimize";
            ptbMinimize.Size = new Size(20, 20);
            ptbMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMinimize.TabIndex = 0;
            ptbMinimize.TabStop = false;
            // 
            // grpContent
            // 
            grpContent.BackColor = Color.DimGray;
            grpContent.Controls.Add(panelTop);
            grpContent.Controls.Add(lblNameRoom);
            grpContent.Controls.Add(label1);
            grpContent.Controls.Add(dgvMember);
            grpContent.Controls.Add(cbbCustomer);
            grpContent.Controls.Add(lblNewWater);
            grpContent.Controls.Add(panelLeft);
            grpContent.Controls.Add(panelRight);
            grpContent.Controls.Add(panelBottom);
            grpContent.Controls.Add(btnDelete);
            grpContent.Controls.Add(btnConfirm);
            grpContent.Dock = DockStyle.Fill;
            grpContent.Location = new Point(0, 0);
            grpContent.Name = "grpContent";
            grpContent.Size = new Size(587, 354);
            grpContent.TabIndex = 17;
            grpContent.TabStop = false;
            // 
            // frmInforToExtend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 354);
            Controls.Add(grpContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInforToExtend";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInforToExtend";
            Load += frmInforToExtend_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbState).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimize).EndInit();
            grpContent.ResumeLayout(false);
            grpContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConfirm;
        private Button btnDelete;
        private Panel panelBottom;
        private Panel panelRight;
        private Panel panelLeft;
        private Label lblNewWater;
        private ComboBox cbbCustomer;
        private DataGridView dgvMember;
        private Label label1;
        private Label lblNameRoom;
        private Panel panelTop;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private PictureBox ptbState;
        private PictureBox ptbClose;
        private PictureBox ptbMinimize;
        private GroupBox grpContent;
    }
}