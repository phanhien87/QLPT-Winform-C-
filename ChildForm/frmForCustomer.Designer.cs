namespace Ass_prn_QLPT.ChildForm
{
    partial class frmForCustomer
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
            panelBottom = new Panel();
            pictureBox1 = new PictureBox();
            labelCustomer = new Label();
            ptbState = new PictureBox();
            ptbClose = new PictureBox();
            ptbMinimize = new PictureBox();
            panelLeft = new Panel();
            panelTop = new Panel();
            pictureBox2 = new PictureBox();
            panelRight = new Panel();
            btnCancle = new Button();
            btnConfirm = new Button();
            label1 = new Label();
            txtCMND = new TextBox();
            label2 = new Label();
            grpContent = new GroupBox();
            txtHk = new TextBox();
            label8 = new Label();
            txtQQ = new TextBox();
            label4 = new Label();
            txtDT = new TextBox();
            label3 = new Label();
            txtLast = new TextBox();
            label7 = new Label();
            txtMid = new TextBox();
            label6 = new Label();
            txtFirst = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimize).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            grpContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(3, 437);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(794, 10);
            panelBottom.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.i2;
            pictureBox1.Location = new Point(1218, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCustomer.ForeColor = SystemColors.ControlLightLight;
            labelCustomer.Location = new Point(9, 4);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(138, 15);
            labelCustomer.TabIndex = 3;
            labelCustomer.Text = "Customer Management";
            labelCustomer.Click += labelCustomer_Click;
            // 
            // ptbState
            // 
            ptbState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbState.Cursor = Cursors.Hand;
            ptbState.Image = Properties.Resources.maxx;
            ptbState.Location = new Point(1782, 7);
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
            ptbClose.Location = new Point(1808, 7);
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
            ptbMinimize.Location = new Point(1756, 7);
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
            panelLeft.Size = new Size(10, 394);
            panelLeft.TabIndex = 12;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(pictureBox2);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(labelCustomer);
            panelTop.Controls.Add(ptbState);
            panelTop.Controls.Add(ptbClose);
            panelTop.Controls.Add(ptbMinimize);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(3, 19);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(784, 24);
            panelTop.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.i2;
            pictureBox2.Location = new Point(761, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panelRight
            // 
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(787, 19);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(10, 418);
            panelRight.TabIndex = 11;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.Gray;
            btnCancle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancle.ForeColor = SystemColors.ControlLightLight;
            btnCancle.Location = new Point(610, 305);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(87, 23);
            btnCancle.TabIndex = 10;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Gray;
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirm.ForeColor = SystemColors.ControlLightLight;
            btnConfirm.Location = new Point(511, 305);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(87, 23);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(155, 144);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // txtCMND
            // 
            txtCMND.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCMND.Location = new Point(252, 170);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(445, 23);
            txtCMND.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(155, 173);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "CMNN";
            // 
            // grpContent
            // 
            grpContent.Controls.Add(txtHk);
            grpContent.Controls.Add(label8);
            grpContent.Controls.Add(txtQQ);
            grpContent.Controls.Add(label4);
            grpContent.Controls.Add(txtDT);
            grpContent.Controls.Add(label3);
            grpContent.Controls.Add(txtLast);
            grpContent.Controls.Add(label7);
            grpContent.Controls.Add(txtMid);
            grpContent.Controls.Add(label6);
            grpContent.Controls.Add(txtFirst);
            grpContent.Controls.Add(panelLeft);
            grpContent.Controls.Add(panelTop);
            grpContent.Controls.Add(panelRight);
            grpContent.Controls.Add(panelBottom);
            grpContent.Controls.Add(btnCancle);
            grpContent.Controls.Add(btnConfirm);
            grpContent.Controls.Add(label1);
            grpContent.Controls.Add(txtCMND);
            grpContent.Controls.Add(label2);
            grpContent.Dock = DockStyle.Fill;
            grpContent.Location = new Point(0, 0);
            grpContent.Name = "grpContent";
            grpContent.Size = new Size(800, 450);
            grpContent.TabIndex = 14;
            grpContent.TabStop = false;
            grpContent.Enter += grpContent_Enter;
            // 
            // txtHk
            // 
            txtHk.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtHk.Location = new Point(252, 257);
            txtHk.Name = "txtHk";
            txtHk.Size = new Size(445, 23);
            txtHk.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(155, 260);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 25;
            label8.Text = "PA";
            // 
            // txtQQ
            // 
            txtQQ.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtQQ.Location = new Point(252, 228);
            txtQQ.Name = "txtQQ";
            txtQQ.Size = new Size(445, 23);
            txtQQ.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(155, 231);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 23;
            label4.Text = "Address";
            label4.Click += label4_Click;
            // 
            // txtDT
            // 
            txtDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDT.Location = new Point(252, 199);
            txtDT.Name = "txtDT";
            txtDT.Size = new Size(445, 23);
            txtDT.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(155, 202);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 21;
            label3.Text = "Number Phone";
            // 
            // txtLast
            // 
            txtLast.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtLast.Location = new Point(614, 141);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(83, 23);
            txtLast.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(533, 144);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 18;
            label7.Text = "Last Name";
            // 
            // txtMid
            // 
            txtMid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMid.Location = new Point(436, 141);
            txtMid.Name = "txtMid";
            txtMid.Size = new Size(83, 23);
            txtMid.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(349, 144);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 16;
            label6.Text = "Middle Name";
            // 
            // txtFirst
            // 
            txtFirst.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFirst.Location = new Point(252, 141);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(83, 23);
            txtFirst.TabIndex = 15;
            // 
            // frmForCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(grpContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmForCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmForCustomer";
            Load += frmForCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbState).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimize).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            grpContent.ResumeLayout(false);
            grpContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private PictureBox pictureBox1;
        private Label labelCustomer;
        private PictureBox ptbState;
        private PictureBox ptbClose;
        private PictureBox ptbMinimize;
        private Panel panelLeft;
        private Panel panelTop;
        private Panel panelRight;
        private Button btnCancle;
        private Button btnConfirm;
        private Label label1;
        private TextBox txtCMND;
        private Label label2;
        private GroupBox grpContent;
        private TextBox txtFirst;
        private TextBox txtLast;
        private Label label7;
        private TextBox txtMid;
        private Label label6;
        private TextBox txtHk;
        private Label label8;
        private TextBox txtQQ;
        private Label label4;
        private TextBox txtDT;
        private Label label3;
        private PictureBox pictureBox2;
    }
}