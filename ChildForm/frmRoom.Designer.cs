namespace Ass_prn_QLPT.ChildForm
{
    partial class frmRoom
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
            dgvRoom = new DataGridView();
            btnSearch = new Button();
            btnAddRoom = new Button();
            btnDeleteRoom = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            SuspendLayout();
            // 
            // dgvRoom
            // 
            dgvRoom.AllowUserToAddRows = false;
            dgvRoom.AllowUserToDeleteRows = false;
            dgvRoom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoom.BackgroundColor = Color.DarkGray;
            dgvRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoom.GridColor = Color.Gray;
            dgvRoom.Location = new Point(-1, 71);
            dgvRoom.MultiSelect = false;
            dgvRoom.Name = "dgvRoom";
            dgvRoom.ReadOnly = true;
            dgvRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoom.Size = new Size(803, 378);
            dgvRoom.TabIndex = 0;
            dgvRoom.CellClick += dgvRoom_CellClick;
            dgvRoom.CellContentClick += dgvRoom_CellContentClick;
            dgvRoom.CellDoubleClick += dgvRoom_CellDoubleClick;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.DimGray;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(557, 42);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAddRoom
            // 
            btnAddRoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddRoom.BackColor = Color.DimGray;
            btnAddRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(638, 42);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(75, 23);
            btnAddRoom.TabIndex = 4;
            btnAddRoom.Text = "Add";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteRoom.BackColor = Color.DimGray;
            btnDeleteRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteRoom.ForeColor = Color.White;
            btnDeleteRoom.Location = new Point(719, 42);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(75, 23);
            btnDeleteRoom.TabIndex = 5;
            btnDeleteRoom.Text = "Note";
            btnDeleteRoom.UseVisualStyleBackColor = false;
            btnDeleteRoom.Click += btnDeleteRoom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 6;
            label1.Text = "Room Management";
            label1.Click += label1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(366, 42);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(185, 23);
            txtSearch.TabIndex = 7;
            // 
            // frmRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnAddRoom);
            Controls.Add(btnSearch);
            Controls.Add(dgvRoom);
            ForeColor = SystemColors.Control;
            Name = "frmRoom";
            Text = "frmRoom";
            Load += frmRoom_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRoom;
        private TextBox textBox1;
        private Button btnSearch;
        private Button btnAddRoom;
        private Button btnDeleteRoom;
        private Label label1;
        private TextBox txtSearch;
    }
}