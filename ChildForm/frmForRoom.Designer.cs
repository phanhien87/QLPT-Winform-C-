namespace Ass_prn_QLPT.ChildForm
{
    partial class frmForRoom
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
            rdbHiding = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            txtNameRoom = new TextBox();
            ckbStatus = new CheckBox();
            cbbTypeRoom = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            btnConfirm = new Button();
            rdbShowing = new RadioButton();
            btnCancle = new Button();
            grpContent = new GroupBox();
            panelLeft = new Panel();
            panelTop = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ptbState = new PictureBox();
            ptbClose = new PictureBox();
            ptbMinimize = new PictureBox();
            panelRight = new Panel();
            panelBottom = new Panel();
            grpContent.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimize).BeginInit();
            SuspendLayout();
            // 
            // rdbHiding
            // 
            rdbHiding.AutoSize = true;
            rdbHiding.Location = new Point(355, 199);
            rdbHiding.Name = "rdbHiding";
            rdbHiding.Size = new Size(61, 19);
            rdbHiding.TabIndex = 5;
            rdbHiding.TabStop = true;
            rdbHiding.Text = "Hiding";
            rdbHiding.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(171, 173);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Name Room";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(171, 201);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 6;
            label3.Text = "Note";
            // 
            // txtNameRoom
            // 
            txtNameRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNameRoom.Location = new Point(252, 170);
            txtNameRoom.Name = "txtNameRoom";
            txtNameRoom.Size = new Size(215, 23);
            txtNameRoom.TabIndex = 2;
            // 
            // ckbStatus
            // 
            ckbStatus.AutoSize = true;
            ckbStatus.Location = new Point(252, 224);
            ckbStatus.Name = "ckbStatus";
            ckbStatus.Size = new Size(15, 14);
            ckbStatus.TabIndex = 7;
            ckbStatus.UseVisualStyleBackColor = true;
            // 
            // cbbTypeRoom
            // 
            cbbTypeRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbbTypeRoom.FormattingEnabled = true;
            cbbTypeRoom.Location = new Point(252, 141);
            cbbTypeRoom.Name = "cbbTypeRoom";
            cbbTypeRoom.Size = new Size(215, 23);
            cbbTypeRoom.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(171, 224);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(171, 144);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Type Room";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Gray;
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirm.ForeColor = SystemColors.ControlLightLight;
            btnConfirm.Location = new Point(248, 267);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(87, 23);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // rdbShowing
            // 
            rdbShowing.AutoSize = true;
            rdbShowing.Location = new Point(252, 199);
            rdbShowing.Name = "rdbShowing";
            rdbShowing.Size = new Size(71, 19);
            rdbShowing.TabIndex = 4;
            rdbShowing.TabStop = true;
            rdbShowing.Text = "Showing";
            rdbShowing.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.Gray;
            btnCancle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancle.ForeColor = SystemColors.ControlLightLight;
            btnCancle.Location = new Point(380, 267);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(87, 23);
            btnCancle.TabIndex = 10;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // grpContent
            // 
            grpContent.Controls.Add(panelLeft);
            grpContent.Controls.Add(panelTop);
            grpContent.Controls.Add(panelRight);
            grpContent.Controls.Add(panelBottom);
            grpContent.Controls.Add(btnCancle);
            grpContent.Controls.Add(rdbShowing);
            grpContent.Controls.Add(btnConfirm);
            grpContent.Controls.Add(label1);
            grpContent.Controls.Add(label4);
            grpContent.Controls.Add(cbbTypeRoom);
            grpContent.Controls.Add(ckbStatus);
            grpContent.Controls.Add(txtNameRoom);
            grpContent.Controls.Add(label3);
            grpContent.Controls.Add(label2);
            grpContent.Controls.Add(rdbHiding);
            grpContent.Dock = DockStyle.Fill;
            grpContent.Location = new Point(0, 0);
            grpContent.Name = "grpContent";
            grpContent.Size = new Size(676, 428);
            grpContent.TabIndex = 13;
            grpContent.TabStop = false;
            grpContent.Enter += grpContent_Enter;
            // 
            // panelLeft
            // 
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(3, 43);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 372);
            panelLeft.TabIndex = 12;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(label5);
            panelTop.Controls.Add(ptbState);
            panelTop.Controls.Add(ptbClose);
            panelTop.Controls.Add(ptbMinimize);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(3, 19);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(660, 24);
            panelTop.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.i2;
            pictureBox1.Location = new Point(634, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(9, 4);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 3;
            label5.Text = "Room Management";
            // 
            // ptbState
            // 
            ptbState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbState.Cursor = Cursors.Hand;
            ptbState.Image = Properties.Resources.maxx;
            ptbState.Location = new Point(1198, 7);
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
            ptbClose.Location = new Point(1224, 7);
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
            ptbMinimize.Location = new Point(1172, 7);
            ptbMinimize.Name = "ptbMinimize";
            ptbMinimize.Size = new Size(20, 20);
            ptbMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMinimize.TabIndex = 0;
            ptbMinimize.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(663, 19);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(10, 396);
            panelRight.TabIndex = 11;
            // 
            // panelBottom
            // 
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(3, 415);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(670, 10);
            panelBottom.TabIndex = 14;
            // 
            // frmForRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(676, 428);
            Controls.Add(grpContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmForRoom";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmForRoom";
            Load += frmForRoom_Load_1;
            grpContent.ResumeLayout(false);
            grpContent.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbState).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rdbHiding;
        private Label label2;
        private Label label3;
        private TextBox txtNameRoom;
        private CheckBox ckbStatus;
        private ComboBox cbbTypeRoom;
        private Label label4;
        private Label label1;
        private Button btnConfirm;
        private RadioButton rdbShowing;
        private Button btnCancle;
        private GroupBox grpContent;
        private Panel panelLeft;
        private Panel panelTop;
        private Label label5;
        private PictureBox ptbState;
        private PictureBox ptbClose;
        private PictureBox ptbMinimize;
        private Panel panelRight;
        private Panel panelBottom;
        private PictureBox pictureBox1;
    }
}