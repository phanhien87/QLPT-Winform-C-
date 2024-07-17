namespace Ass_prn_QLPT.ChildForm
{
    partial class History
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
            txtSearch = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            dgvHistory = new DataGridView();
            dtpIn = new DateTimePicker();
            dtpOut = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(522, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(185, 23);
            txtSearch.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 12;
            label1.Text = "Transaction history";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.DimGray;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(713, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistory.BackgroundColor = Color.DarkGray;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.GridColor = Color.Gray;
            dgvHistory.Location = new Point(-1, 67);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(803, 383);
            dgvHistory.TabIndex = 8;
            // 
            // dtpIn
            // 
            dtpIn.Location = new Point(81, 38);
            dtpIn.Name = "dtpIn";
            dtpIn.Size = new Size(152, 23);
            dtpIn.TabIndex = 14;
            dtpIn.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtpOut
            // 
            dtpOut.Location = new Point(309, 38);
            dtpOut.Name = "dtpOut";
            dtpOut.Size = new Size(152, 23);
            dtpOut.TabIndex = 15;
            dtpOut.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(239, 42);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 16;
            label2.Text = "Check-out";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(15, 42);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 17;
            label3.Text = "Check-in";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpOut);
            Controls.Add(dtpIn);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(dgvHistory);
            Name = "History";
            Text = "History";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label label1;
        private Button btnSearch;
        private DataGridView dgvHistory;
        private DateTimePicker dtpIn;
        private DateTimePicker dtpOut;
        private Label label2;
        private Label label3;
    }
}