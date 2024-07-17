namespace Ass_prn_QLPT.ChildForm
{
    partial class frmLogin
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
            pnlTop = new Panel();
            label1 = new Label();
            ptbClose = new PictureBox();
            pnlBottom = new Panel();
            pnlLeft = new Panel();
            pnlRight = new Panel();
            groupBox1 = new GroupBox();
            picshoweye = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtPass = new TextBox();
            txtAcc = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picshoweye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(ptbClose);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(451, 25);
            pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // ptbClose
            // 
            ptbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbClose.Cursor = Cursors.Hand;
            ptbClose.Image = Properties.Resources.close;
            ptbClose.Location = new Point(405, 4);
            ptbClose.Name = "ptbClose";
            ptbClose.Size = new Size(20, 20);
            ptbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbClose.TabIndex = 2;
            ptbClose.TabStop = false;
            ptbClose.Click += ptbClose_Click;
            // 
            // pnlBottom
            // 
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 226);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(451, 25);
            pnlBottom.TabIndex = 1;
            // 
            // pnlLeft
            // 
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 25);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(20, 201);
            pnlLeft.TabIndex = 1;
            // 
            // pnlRight
            // 
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(431, 25);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(20, 201);
            pnlRight.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picshoweye);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtAcc);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(20, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 201);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // picshoweye
            // 
            picshoweye.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picshoweye.Cursor = Cursors.Hand;
            picshoweye.Image = Properties.Resources.noeye;
            picshoweye.Location = new Point(287, 105);
            picshoweye.Name = "picshoweye";
            picshoweye.Size = new Size(22, 21);
            picshoweye.SizeMode = PictureBoxSizeMode.StretchImage;
            picshoweye.TabIndex = 9;
            picshoweye.TabStop = false;
            picshoweye.Click += picshoweye_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.eyes;
            pictureBox1.Location = new Point(287, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(84, 30);
            label4.Name = "label4";
            label4.Size = new Size(225, 20);
            label4.TabIndex = 7;
            label4.Text = "Accommodation Management\r\n";
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(149, 151);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(234, 151);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPass.Location = new Point(149, 104);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(160, 23);
            txtPass.TabIndex = 1;
            // 
            // txtAcc
            // 
            txtAcc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAcc.Location = new Point(149, 69);
            txtAcc.Name = "txtAcc";
            txtAcc.Size = new Size(160, 23);
            txtAcc.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(77, 107);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(77, 72);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Account";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(451, 251);
            Controls.Add(groupBox1);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClose).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picshoweye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Panel pnlBottom;
        private Panel pnlLeft;
        private Panel pnlRight;
        private PictureBox ptbClose;
        private GroupBox groupBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox txtPass;
        private TextBox txtAcc;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox picshoweye;
    }
}