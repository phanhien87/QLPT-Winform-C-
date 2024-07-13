namespace Ass_prn_QLPT.ChildForm
{
    partial class frmService
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
            dgvSe = new DataGridView();
            txtNuoc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDien = new TextBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 12;
            label1.Text = "Service Management";
            // 
            // dgvSe
            // 
            dgvSe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSe.Location = new Point(0, 79);
            dgvSe.Name = "dgvSe";
            dgvSe.Size = new Size(801, 370);
            dgvSe.TabIndex = 17;
            dgvSe.CellClick += dgvSe_CellClick;
            dgvSe.CellContentClick += dgvSe_CellContentClick;
            // 
            // txtNuoc
            // 
            txtNuoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNuoc.Location = new Point(293, 36);
            txtNuoc.Name = "txtNuoc";
            txtNuoc.Size = new Size(130, 23);
            txtNuoc.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(247, 39);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 19;
            label2.Text = "Nuoc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(456, 39);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 21;
            label3.Text = "Dien";
            // 
            // txtDien
            // 
            txtDien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDien.Location = new Point(502, 36);
            txtDien.Name = "txtDien";
            txtDien.Size = new Size(130, 23);
            txtDien.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gray;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.ImageAlign = ContentAlignment.BottomLeft;
            btnSave.Location = new Point(666, 36);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(txtDien);
            Controls.Add(label2);
            Controls.Add(txtNuoc);
            Controls.Add(dgvSe);
            Controls.Add(label1);
            Name = "frmService";
            Text = "frmService";
            Load += frmService_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvSe;
        private TextBox txtNuoc;
        private Label label2;
        private Label label3;
        private TextBox txtDien;
        private Button btnSave;
    }
}