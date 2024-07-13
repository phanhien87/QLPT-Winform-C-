namespace Ass_prn_QLPT.ChildForm
{
    partial class frmTypeRoom
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
            label1 = new Label();
            dgvLoadTypeRoom = new DataGridView();
            label2 = new Label();
            txtNameTypeRoom = new TextBox();
            txtPriceTypeRoom = new TextBox();
            label3 = new Label();
            btnAddType = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLoadTypeRoom).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 0;
            label1.Text = "Room type management";
            // 
            // dgvLoadTypeRoom
            // 
            dgvLoadTypeRoom.AllowUserToAddRows = false;
            dgvLoadTypeRoom.AllowUserToDeleteRows = false;
            dgvLoadTypeRoom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLoadTypeRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoadTypeRoom.Location = new Point(0, 85);
            dgvLoadTypeRoom.MultiSelect = false;
            dgvLoadTypeRoom.Name = "dgvLoadTypeRoom";
            dgvLoadTypeRoom.ReadOnly = true;
            dgvLoadTypeRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoadTypeRoom.Size = new Size(802, 365);
            dgvLoadTypeRoom.TabIndex = 1;
            dgvLoadTypeRoom.CellClick += dgvLoadTypeRoom_CellClick;
            dgvLoadTypeRoom.CellContentClick += dgvLoadTypeRoom_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 2;
            label2.Text = "Room type name";
            // 
            // txtNameTypeRoom
            // 
            txtNameTypeRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNameTypeRoom.Location = new Point(120, 53);
            txtNameTypeRoom.Name = "txtNameTypeRoom";
            txtNameTypeRoom.Size = new Size(178, 23);
            txtNameTypeRoom.TabIndex = 3;
            // 
            // txtPriceTypeRoom
            // 
            txtPriceTypeRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPriceTypeRoom.Location = new Point(345, 53);
            txtPriceTypeRoom.Name = "txtPriceTypeRoom";
            txtPriceTypeRoom.Size = new Size(76, 23);
            txtPriceTypeRoom.TabIndex = 5;
            txtPriceTypeRoom.Text = "0";
            txtPriceTypeRoom.TextAlign = HorizontalAlignment.Right;
            txtPriceTypeRoom.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(304, 56);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // btnAddType
            // 
            btnAddType.BackColor = Color.Silver;
            btnAddType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddType.ForeColor = SystemColors.ControlLightLight;
            btnAddType.Location = new Point(437, 53);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(75, 23);
            btnAddType.TabIndex = 6;
            btnAddType.Text = "Add";
            btnAddType.UseVisualStyleBackColor = false;
            btnAddType.Click += btnAddType_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Silver;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(518, 52);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Silver;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(599, 52);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Confirm";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Silver;
            btndelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btndelete.ForeColor = SystemColors.ControlLightLight;
            btndelete.Location = new Point(680, 52);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 9;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // frmLoadRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btndelete);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddType);
            Controls.Add(txtPriceTypeRoom);
            Controls.Add(label3);
            Controls.Add(txtNameTypeRoom);
            Controls.Add(label2);
            Controls.Add(dgvLoadTypeRoom);
            Controls.Add(label1);
            Name = "frmLoadRoom";
            Text = "frmTypeRoom";
            Load += frmLoadRoom_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoadTypeRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvLoadTypeRoom;
        private Label label2;
        private TextBox txtNameTypeRoom;
        private TextBox txtPriceTypeRoom;
        private Label label3;
        private Button btnAddType;
        private Button btnUpdate;
        private Button btnSave;
        private Button btndelete;
    }
}