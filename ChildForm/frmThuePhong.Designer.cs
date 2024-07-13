namespace Ass_prn_QLPT
{
    partial class frmThuePhong
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
            txtSearchRentalRoom = new TextBox();
            label1 = new Label();
            btnAddRoom = new Button();
            btnSearch = new Button();
            dgvRentalRoom = new DataGridView();
            txtNamRoom = new DataGridViewTextBoxColumn();
            GiaPhong = new DataGridViewTextBoxColumn();
            txtDeposit = new DataGridViewTextBoxColumn();
            txtCheckin = new DataGridViewTextBoxColumn();
            txtCheckout = new DataGridViewTextBoxColumn();
            CSD_Cu = new DataGridViewTextBoxColumn();
            CSD_Moi = new DataGridViewTextBoxColumn();
            DonGiaDien = new DataGridViewTextBoxColumn();
            ElectricityNumber = new DataGridViewTextBoxColumn();
            CSN_Cu = new DataGridViewTextBoxColumn();
            CSN_Moi = new DataGridViewTextBoxColumn();
            DonGiaNuoc = new DataGridViewTextBoxColumn();
            SoNuoc = new DataGridViewTextBoxColumn();
            Wifi = new DataGridViewTextBoxColumn();
            VS = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Paid = new DataGridViewTextBoxColumn();
            Remainder = new DataGridViewTextBoxColumn();
            btnThanhToan = new DataGridViewButtonColumn();
            ID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRentalRoom).BeginInit();
            SuspendLayout();
            // 
            // txtSearchRentalRoom
            // 
            txtSearchRentalRoom.Location = new Point(25, 38);
            txtSearchRentalRoom.Name = "txtSearchRentalRoom";
            txtSearchRentalRoom.Size = new Size(185, 23);
            txtSearchRentalRoom.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 12;
            label1.Text = "Room Rental Management";
            label1.Click += label1_Click;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.DimGray;
            btnAddRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(297, 38);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(75, 23);
            btnAddRoom.TabIndex = 10;
            btnAddRoom.Text = "Add";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DimGray;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(216, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvRentalRoom
            // 
            dgvRentalRoom.AllowUserToAddRows = false;
            dgvRentalRoom.AllowUserToDeleteRows = false;
            dgvRentalRoom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRentalRoom.BackgroundColor = Color.DarkGray;
            dgvRentalRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalRoom.Columns.AddRange(new DataGridViewColumn[] { txtNamRoom, GiaPhong, txtDeposit, txtCheckin, txtCheckout, CSD_Cu, CSD_Moi, DonGiaDien, ElectricityNumber, CSN_Cu, CSN_Moi, DonGiaNuoc, SoNuoc, Wifi, VS, Total, Paid, Remainder, btnThanhToan, ID });
            dgvRentalRoom.GridColor = Color.Gray;
            dgvRentalRoom.Location = new Point(-1, 67);
            dgvRentalRoom.MultiSelect = false;
            dgvRentalRoom.Name = "dgvRentalRoom";
            dgvRentalRoom.ReadOnly = true;
            dgvRentalRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentalRoom.Size = new Size(803, 383);
            dgvRentalRoom.TabIndex = 8;
            dgvRentalRoom.CellClick += dgvRentalRoom_CellClick;
            dgvRentalRoom.CellContentClick += dgvRentalRoom_CellContentClick;
            // 
            // txtNamRoom
            // 
            txtNamRoom.DataPropertyName = "NameRoom";
            txtNamRoom.HeaderText = "Name Room";
            txtNamRoom.Name = "txtNamRoom";
            txtNamRoom.ReadOnly = true;
            // 
            // GiaPhong
            // 
            GiaPhong.DataPropertyName = "GiaPhong";
            GiaPhong.HeaderText = "Room Price";
            GiaPhong.Name = "GiaPhong";
            GiaPhong.ReadOnly = true;
            // 
            // txtDeposit
            // 
            txtDeposit.DataPropertyName = "DatCoc";
            txtDeposit.HeaderText = "Deposit";
            txtDeposit.Name = "txtDeposit";
            txtDeposit.ReadOnly = true;
            // 
            // txtCheckin
            // 
            txtCheckin.DataPropertyName = "Checkin";
            txtCheckin.HeaderText = "Check-in Date";
            txtCheckin.Name = "txtCheckin";
            txtCheckin.ReadOnly = true;
            // 
            // txtCheckout
            // 
            txtCheckout.DataPropertyName = "checkout";
            txtCheckout.HeaderText = "Check-out Date";
            txtCheckout.Name = "txtCheckout";
            txtCheckout.ReadOnly = true;
            // 
            // CSD_Cu
            // 
            CSD_Cu.DataPropertyName = "CSD_Cu";
            CSD_Cu.HeaderText = "Old Electricity Number";
            CSD_Cu.Name = "CSD_Cu";
            CSD_Cu.ReadOnly = true;
            // 
            // CSD_Moi
            // 
            CSD_Moi.DataPropertyName = "CSD_Moi";
            CSD_Moi.HeaderText = "New Electricity Number";
            CSD_Moi.Name = "CSD_Moi";
            CSD_Moi.ReadOnly = true;
            // 
            // DonGiaDien
            // 
            DonGiaDien.DataPropertyName = "DonGiaDien";
            DonGiaDien.HeaderText = "Electricity Cost";
            DonGiaDien.Name = "DonGiaDien";
            DonGiaDien.ReadOnly = true;
            // 
            // ElectricityNumber
            // 
            ElectricityNumber.DataPropertyName = "dientieuthu";
            ElectricityNumber.HeaderText = "Electricity Number";
            ElectricityNumber.Name = "ElectricityNumber";
            ElectricityNumber.ReadOnly = true;
            // 
            // CSN_Cu
            // 
            CSN_Cu.DataPropertyName = "CSN_Cu";
            CSN_Cu.HeaderText = "Old Water Number";
            CSN_Cu.Name = "CSN_Cu";
            CSN_Cu.ReadOnly = true;
            // 
            // CSN_Moi
            // 
            CSN_Moi.DataPropertyName = "CSN_Moi";
            CSN_Moi.HeaderText = "New Water Number";
            CSN_Moi.Name = "CSN_Moi";
            CSN_Moi.ReadOnly = true;
            // 
            // DonGiaNuoc
            // 
            DonGiaNuoc.DataPropertyName = "DonGiaNuoc";
            DonGiaNuoc.HeaderText = "Water Cost";
            DonGiaNuoc.Name = "DonGiaNuoc";
            DonGiaNuoc.ReadOnly = true;
            // 
            // SoNuoc
            // 
            SoNuoc.DataPropertyName = "SoNuoc";
            SoNuoc.HeaderText = "Water Number";
            SoNuoc.Name = "SoNuoc";
            SoNuoc.ReadOnly = true;
            // 
            // Wifi
            // 
            Wifi.DataPropertyName = "TienMang";
            Wifi.HeaderText = "Wifi";
            Wifi.Name = "Wifi";
            Wifi.ReadOnly = true;
            // 
            // VS
            // 
            VS.DataPropertyName = "TienVS";
            VS.HeaderText = "VS";
            VS.Name = "VS";
            VS.ReadOnly = true;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // Paid
            // 
            Paid.DataPropertyName = "DaThanhToan";
            Paid.HeaderText = "Paid";
            Paid.Name = "Paid";
            Paid.ReadOnly = true;
            // 
            // Remainder
            // 
            Remainder.DataPropertyName = "Remainder";
            Remainder.HeaderText = "Remainder";
            Remainder.Name = "Remainder";
            Remainder.ReadOnly = true;
            // 
            // btnThanhToan
            // 
            btnThanhToan.HeaderText = "#";
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.ReadOnly = true;
            btnThanhToan.Text = "Payment";
            btnThanhToan.UseColumnTextForButtonValue = true;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // frmThuePhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearchRentalRoom);
            Controls.Add(label1);
            Controls.Add(btnAddRoom);
            Controls.Add(btnSearch);
            Controls.Add(dgvRentalRoom);
            Name = "frmThuePhong";
            Text = "frmThuePhong";
            Load += frmThuePhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentalRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchRentalRoom;
        private Label label1;
        private Button btnDeleteRoom;
        private Button btnAddRoom;
        private Button btnSearch;
        private DataGridView dgvRentalRoom;
        private DataGridViewTextBoxColumn txtNamRoom;
        private DataGridViewTextBoxColumn GiaPhong;
        private DataGridViewTextBoxColumn txtDeposit;
        private DataGridViewTextBoxColumn txtCheckin;
        private DataGridViewTextBoxColumn txtCheckout;
        private DataGridViewTextBoxColumn CSD_Cu;
        private DataGridViewTextBoxColumn CSD_Moi;
        private DataGridViewTextBoxColumn DonGiaDien;
        private DataGridViewTextBoxColumn ElectricityNumber;
        private DataGridViewTextBoxColumn CSN_Cu;
        private DataGridViewTextBoxColumn CSN_Moi;
        private DataGridViewTextBoxColumn DonGiaNuoc;
        private DataGridViewTextBoxColumn SoNuoc;
        private DataGridViewTextBoxColumn Wifi;
        private DataGridViewTextBoxColumn VS;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Paid;
        private DataGridViewTextBoxColumn Remainder;
        private DataGridViewButtonColumn btnThanhToan;
        private DataGridViewTextBoxColumn ID;
    }
}