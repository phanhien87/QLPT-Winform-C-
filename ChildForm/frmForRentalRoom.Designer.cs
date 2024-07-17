namespace Ass_prn_QLPT
{
    partial class frmForRentalRoom
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
            label2 = new Label();
            btnConfirm = new Button();
            btnCancle = new Button();
            panelBottom = new Panel();
            panelRight = new Panel();
            panelTop = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ptbState = new PictureBox();
            ptbClose = new PictureBox();
            ptbMinimize = new PictureBox();
            panelLeft = new Panel();
            grpContent = new GroupBox();
            lblTotalprice = new Label();
            label12 = new Label();
            txttTraTienphong = new TextBox();
            label11 = new Label();
            txtWifiFee = new TextBox();
            txtCCfee = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txten = new TextBox();
            txtwn = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dtpCheckOut = new DateTimePicker();
            cbbCustomer = new ComboBox();
            label4 = new Label();
            dtpRentalDate = new DateTimePicker();
            txtDeposit = new TextBox();
            label3 = new Label();
            label1 = new Label();
            cbbRentalRoom = new ComboBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimize).BeginInit();
            grpContent.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(110, 99);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Name Room";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Gray;
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirm.ForeColor = SystemColors.ControlLightLight;
            btnConfirm.Location = new Point(415, 312);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(87, 23);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.Gray;
            btnCancle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancle.ForeColor = SystemColors.ControlLightLight;
            btnCancle.Location = new Point(508, 312);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(87, 23);
            btnCancle.TabIndex = 10;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // panelBottom
            // 
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(3, 383);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(708, 10);
            panelBottom.TabIndex = 14;
            // 
            // panelRight
            // 
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(701, 19);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(10, 364);
            panelRight.TabIndex = 11;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(pictureBox2);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(label5);
            panelTop.Controls.Add(ptbState);
            panelTop.Controls.Add(ptbClose);
            panelTop.Controls.Add(ptbMinimize);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(3, 19);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(698, 24);
            panelTop.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.close;
            pictureBox2.Location = new Point(672, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.i2;
            pictureBox1.Location = new Point(1132, 4);
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
            label5.Size = new Size(156, 15);
            label5.TabIndex = 3;
            label5.Text = "Room Rental Management";
            // 
            // ptbState
            // 
            ptbState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbState.Cursor = Cursors.Hand;
            ptbState.Image = Properties.Resources.maxx;
            ptbState.Location = new Point(1696, 7);
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
            ptbClose.Location = new Point(1722, 7);
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
            ptbMinimize.Location = new Point(1670, 7);
            ptbMinimize.Name = "ptbMinimize";
            ptbMinimize.Size = new Size(20, 20);
            ptbMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMinimize.TabIndex = 0;
            ptbMinimize.TabStop = false;
            // 
            // panelLeft
            // 
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(3, 43);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 340);
            panelLeft.TabIndex = 12;
            // 
            // grpContent
            // 
            grpContent.Controls.Add(lblTotalprice);
            grpContent.Controls.Add(label12);
            grpContent.Controls.Add(txttTraTienphong);
            grpContent.Controls.Add(label11);
            grpContent.Controls.Add(txtWifiFee);
            grpContent.Controls.Add(txtCCfee);
            grpContent.Controls.Add(label9);
            grpContent.Controls.Add(label10);
            grpContent.Controls.Add(txten);
            grpContent.Controls.Add(txtwn);
            grpContent.Controls.Add(label8);
            grpContent.Controls.Add(label7);
            grpContent.Controls.Add(label6);
            grpContent.Controls.Add(dtpCheckOut);
            grpContent.Controls.Add(cbbCustomer);
            grpContent.Controls.Add(label4);
            grpContent.Controls.Add(dtpRentalDate);
            grpContent.Controls.Add(txtDeposit);
            grpContent.Controls.Add(label3);
            grpContent.Controls.Add(label1);
            grpContent.Controls.Add(cbbRentalRoom);
            grpContent.Controls.Add(panelLeft);
            grpContent.Controls.Add(panelTop);
            grpContent.Controls.Add(panelRight);
            grpContent.Controls.Add(panelBottom);
            grpContent.Controls.Add(btnCancle);
            grpContent.Controls.Add(btnConfirm);
            grpContent.Controls.Add(label2);
            grpContent.Dock = DockStyle.Fill;
            grpContent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpContent.Location = new Point(0, 0);
            grpContent.Name = "grpContent";
            grpContent.Size = new Size(714, 396);
            grpContent.TabIndex = 14;
            grpContent.TabStop = false;
            // 
            // lblTotalprice
            // 
            lblTotalprice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalprice.ForeColor = SystemColors.ControlLightLight;
            lblTotalprice.Location = new Point(467, 270);
            lblTotalprice.Name = "lblTotalprice";
            lblTotalprice.Size = new Size(128, 15);
            lblTotalprice.TabIndex = 36;
            lblTotalprice.Text = "0";
            lblTotalprice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(350, 270);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 35;
            label12.Text = "Total";
            // 
            // txttTraTienphong
            // 
            txttTraTienphong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txttTraTienphong.Location = new Point(213, 267);
            txttTraTienphong.Name = "txttTraTienphong";
            txttTraTienphong.Size = new Size(128, 23);
            txttTraTienphong.TabIndex = 34;
            txttTraTienphong.Text = "0";
            txttTraTienphong.TextAlign = HorizontalAlignment.Right;
            txttTraTienphong.KeyUp += textBox1_KeyUp;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(111, 270);
            label11.Name = "label11";
            label11.Size = new Size(101, 15);
            label11.TabIndex = 33;
            label11.Text = "Total Room Price\r\n";
            // 
            // txtWifiFee
            // 
            txtWifiFee.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtWifiFee.Location = new Point(470, 226);
            txtWifiFee.Name = "txtWifiFee";
            txtWifiFee.Size = new Size(125, 23);
            txtWifiFee.TabIndex = 32;
            txtWifiFee.Text = "0";
            txtWifiFee.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCCfee
            // 
            txtCCfee.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCCfee.Location = new Point(213, 226);
            txtCCfee.Name = "txtCCfee";
            txtCCfee.Size = new Size(128, 23);
            txtCCfee.TabIndex = 31;
            txtCCfee.Text = "0";
            txtCCfee.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(350, 229);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 30;
            label9.Text = "Wifi Fee";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(111, 229);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 29;
            label10.Text = "CC Fee";
            // 
            // txten
            // 
            txten.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txten.Location = new Point(470, 193);
            txten.Name = "txten";
            txten.Size = new Size(125, 23);
            txten.TabIndex = 28;
            txten.Text = "0";
            txten.TextAlign = HorizontalAlignment.Right;
            // 
            // txtwn
            // 
            txtwn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtwn.Location = new Point(213, 193);
            txtwn.Name = "txtwn";
            txtwn.Size = new Size(128, 23);
            txtwn.TabIndex = 27;
            txtwn.Text = "0";
            txtwn.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(350, 196);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 26;
            label8.Text = "Electricity Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(111, 196);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 25;
            label7.Text = "Water Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(350, 168);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 24;
            label6.Text = "Check-out Date";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(470, 162);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(125, 23);
            dtpCheckOut.TabIndex = 4;
            dtpCheckOut.ValueChanged += dtpCheckOut_ValueChanged;
            dtpCheckOut.KeyUp += dtpCheckOut_KeyUp;
            // 
            // cbbCustomer
            // 
            cbbCustomer.FormattingEnabled = true;
            cbbCustomer.Location = new Point(213, 127);
            cbbCustomer.Name = "cbbCustomer";
            cbbCustomer.Size = new Size(187, 23);
            cbbCustomer.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(111, 167);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 21;
            label4.Text = "Rental Date";
            // 
            // dtpRentalDate
            // 
            dtpRentalDate.Location = new Point(213, 162);
            dtpRentalDate.Name = "dtpRentalDate";
            dtpRentalDate.Size = new Size(128, 23);
            dtpRentalDate.TabIndex = 3;
            dtpRentalDate.ValueChanged += dtpRentalDate_ValueChanged;
            // 
            // txtDeposit
            // 
            txtDeposit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDeposit.Location = new Point(470, 127);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(125, 23);
            txtDeposit.TabIndex = 2;
            txtDeposit.Text = "0";
            txtDeposit.TextAlign = HorizontalAlignment.Right;
            txtDeposit.TextChanged += txtDeposit_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(416, 132);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 18;
            label3.Text = "Deposit";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(110, 130);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 16;
            label1.Text = "Name Customer";
            // 
            // cbbRentalRoom
            // 
            cbbRentalRoom.FormattingEnabled = true;
            cbbRentalRoom.Location = new Point(213, 96);
            cbbRentalRoom.Name = "cbbRentalRoom";
            cbbRentalRoom.Size = new Size(382, 23);
            cbbRentalRoom.TabIndex = 0;
            cbbRentalRoom.SelectionChangeCommitted += cbbRentalRoom_SelectionChangeCommitted;
            cbbRentalRoom.KeyUp += cbbRentalRoom_KeyUp;
            // 
            // frmForRentalRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(714, 396);
            Controls.Add(grpContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmForRentalRoom";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmForRentalRoom";
            Load += frmForRentalRoom_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
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

        private Label label2;
        private Button btnConfirm;
        private Button btnCancle;
        private Panel panelBottom;
        private Panel panelRight;
        private Panel panelTop;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private PictureBox ptbState;
        private PictureBox ptbClose;
        private PictureBox ptbMinimize;
        private Panel panelLeft;
        private GroupBox grpContent;
        private TextBox txtWifiFee;
        private ComboBox cbbRentalRoom;
        private DateTimePicker dtpRentalDate;
        private TextBox txtDeposit;
        private Label label3;
        private Label label4;
        private Label label6;
        private DateTimePicker dtpCheckOut;
        private ComboBox cbbCustomer;
        private Label label1;
        private TextBox txten;
        private TextBox txtwn;
        private Label label8;
        private Label label7;
        private TextBox txtCCfee;
        private Label label9;
        private Label label10;
        private Label label12;
        private TextBox txttTraTienphong;
        private Label label11;
        private Label lblTotalprice;
    }
}