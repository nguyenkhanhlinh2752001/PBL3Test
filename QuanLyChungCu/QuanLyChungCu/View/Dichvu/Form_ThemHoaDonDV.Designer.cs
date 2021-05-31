namespace QuanLyChungCu.View
{
    partial class Form_ThemHoaDonDV
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSDichVu = new System.Windows.Forms.DataGridView();
            this.madichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.grHD = new System.Windows.Forms.GroupBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdRoi = new System.Windows.Forms.RadioButton();
            this.rdChua = new System.Windows.Forms.RadioButton();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChonDV = new System.Windows.Forms.Button();
            this.btnThemDon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCheck = new System.Windows.Forms.Label();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.txtKhu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDichVu)).BeginInit();
            this.grHD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(1229, 24);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 38);
            this.btnHelp.TabIndex = 18;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.dgvDSDichVu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(39, 493);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1298, 204);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Dịch Vụ";
            // 
            // dgvDSDichVu
            // 
            this.dgvDSDichVu.AllowUserToAddRows = false;
            this.dgvDSDichVu.AllowUserToDeleteRows = false;
            this.dgvDSDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSDichVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvDSDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madichvu,
            this.tendichvu,
            this.soluong,
            this.gia,
            this.thanhtien,
            this.btn});
            this.dgvDSDichVu.EnableHeadersVisualStyles = false;
            this.dgvDSDichVu.Location = new System.Drawing.Point(13, 25);
            this.dgvDSDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSDichVu.Name = "dgvDSDichVu";
            this.dgvDSDichVu.ReadOnly = true;
            this.dgvDSDichVu.RowHeadersWidth = 51;
            this.dgvDSDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDichVu.Size = new System.Drawing.Size(1264, 171);
            this.dgvDSDichVu.TabIndex = 10;
            this.dgvDSDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDichVu_CellClick);
            this.dgvDSDichVu.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvDSDichVu_RowStateChanged);
            // 
            // madichvu
            // 
            this.madichvu.DataPropertyName = "madichvu";
            this.madichvu.HeaderText = "Mã dịch vụ";
            this.madichvu.MinimumWidth = 6;
            this.madichvu.Name = "madichvu";
            this.madichvu.ReadOnly = true;
            // 
            // tendichvu
            // 
            this.tendichvu.DataPropertyName = "tendichvu";
            this.tendichvu.HeaderText = "Tên dịch vụ";
            this.tendichvu.MinimumWidth = 6;
            this.tendichvu.Name = "tendichvu";
            this.tendichvu.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Đơn giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // btn
            // 
            this.btn.DataPropertyName = "btn";
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn.HeaderText = "          Xóa";
            this.btn.MinimumWidth = 6;
            this.btn.Name = "btn";
            this.btn.ReadOnly = true;
            this.btn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn.Text = "X";
            this.btn.UseColumnTextForButtonValue = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(419, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(494, 46);
            this.label7.TabIndex = 14;
            this.label7.Text = "TẠO HÓA ĐƠN DỊCH VỤ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grHD
            // 
            this.grHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grHD.AutoSize = true;
            this.grHD.BackColor = System.Drawing.Color.Snow;
            this.grHD.Controls.Add(this.dtpNgayLap);
            this.grHD.Controls.Add(this.label8);
            this.grHD.Controls.Add(this.label5);
            this.grHD.Controls.Add(this.label4);
            this.grHD.Controls.Add(this.label2);
            this.grHD.Controls.Add(this.rdRoi);
            this.grHD.Controls.Add(this.rdChua);
            this.grHD.Controls.Add(this.txtTenNV);
            this.grHD.Controls.Add(this.txtMaNV);
            this.grHD.Controls.Add(this.txtMaHD);
            this.grHD.Controls.Add(this.label9);
            this.grHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHD.ForeColor = System.Drawing.Color.Indigo;
            this.grHD.Location = new System.Drawing.Point(39, 84);
            this.grHD.Margin = new System.Windows.Forms.Padding(4);
            this.grHD.Name = "grHD";
            this.grHD.Padding = new System.Windows.Forms.Padding(4);
            this.grHD.Size = new System.Drawing.Size(1290, 221);
            this.grHD.TabIndex = 15;
            this.grHD.TabStop = false;
            this.grHD.Text = "Hóa đơn";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Enabled = false;
            this.dtpNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(189, 91);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(272, 34);
            this.dtpNgayLap.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thanh toán";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên nhân viên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhân viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdRoi
            // 
            this.rdRoi.AutoSize = true;
            this.rdRoi.Checked = true;
            this.rdRoi.Location = new System.Drawing.Point(189, 153);
            this.rdRoi.Margin = new System.Windows.Forms.Padding(4);
            this.rdRoi.Name = "rdRoi";
            this.rdRoi.Size = new System.Drawing.Size(74, 33);
            this.rdRoi.TabIndex = 7;
            this.rdRoi.TabStop = true;
            this.rdRoi.Text = "Rồi";
            this.rdRoi.UseVisualStyleBackColor = true;
            // 
            // rdChua
            // 
            this.rdChua.AutoSize = true;
            this.rdChua.Location = new System.Drawing.Point(367, 153);
            this.rdChua.Margin = new System.Windows.Forms.Padding(4);
            this.rdChua.Name = "rdChua";
            this.rdChua.Size = new System.Drawing.Size(94, 33);
            this.rdChua.TabIndex = 8;
            this.rdChua.Text = "Chưa";
            this.rdChua.UseVisualStyleBackColor = true;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(857, 93);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(315, 34);
            this.txtTenNV.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(857, 36);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(315, 34);
            this.txtMaNV.TabIndex = 5;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(189, 33);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(272, 34);
            this.txtMaHD.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày lập";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChonDV
            // 
            this.btnChonDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonDV.Image = global::QuanLyChungCu.Properties.Resources.icons8_add_property_55;
            this.btnChonDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonDV.Location = new System.Drawing.Point(1025, 45);
            this.btnChonDV.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonDV.Name = "btnChonDV";
            this.btnChonDV.Size = new System.Drawing.Size(223, 67);
            this.btnChonDV.TabIndex = 30;
            this.btnChonDV.Text = "Thêm dịch vụ";
            this.btnChonDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChonDV.UseVisualStyleBackColor = true;
            this.btnChonDV.Visible = false;
            this.btnChonDV.Click += new System.EventHandler(this.btnChonDV_Click);
            // 
            // btnThemDon
            // 
            this.btnThemDon.Enabled = false;
            this.btnThemDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDon.Image = global::QuanLyChungCu.Properties.Resources.icons8_checked_checkbox_48;
            this.btnThemDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDon.Location = new System.Drawing.Point(1025, 45);
            this.btnThemDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDon.Name = "btnThemDon";
            this.btnThemDon.Size = new System.Drawing.Size(223, 67);
            this.btnThemDon.TabIndex = 10;
            this.btnThemDon.Text = "Tiếp tục";
            this.btnThemDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDon.UseVisualStyleBackColor = true;
            this.btnThemDon.Click += new System.EventHandler(this.btnThemDon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(56, 738);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tổng Tiền";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.BackColor = System.Drawing.Color.Transparent;
            this.btnHoanThanh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHoanThanh.Enabled = false;
            this.btnHoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.ForeColor = System.Drawing.Color.Indigo;
            this.btnHoanThanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoanThanh.Location = new System.Drawing.Point(558, 738);
            this.btnHoanThanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(236, 65);
            this.btnHoanThanh.TabIndex = 17;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.lbCheck);
            this.groupBox2.Controls.Add(this.txtMaCH);
            this.groupBox2.Controls.Add(this.btnChonDV);
            this.groupBox2.Controls.Add(this.btnThemDon);
            this.groupBox2.Controls.Add(this.txtTenCH);
            this.groupBox2.Controls.Add(this.txtKhu);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox2.Location = new System.Drawing.Point(39, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1298, 149);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Căn hộ";
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheck.ForeColor = System.Drawing.Color.Red;
            this.lbCheck.Location = new System.Drawing.Point(19, 90);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(75, 25);
            this.lbCheck.TabIndex = 31;
            this.lbCheck.Text = "kiemtra";
            this.lbCheck.Visible = false;
            // 
            // txtMaCH
            // 
            this.txtMaCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCH.Location = new System.Drawing.Point(174, 40);
            this.txtMaCH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(78, 34);
            this.txtMaCH.TabIndex = 6;
            this.txtMaCH.TextChanged += new System.EventHandler(this.txtMaCH_TextChanged);
            this.txtMaCH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaCH_KeyPress);
            // 
            // txtTenCH
            // 
            this.txtTenCH.Enabled = false;
            this.txtTenCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCH.Location = new System.Drawing.Point(570, 34);
            this.txtTenCH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(315, 34);
            this.txtTenCH.TabIndex = 5;
            // 
            // txtKhu
            // 
            this.txtKhu.Enabled = false;
            this.txtKhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhu.Location = new System.Drawing.Point(570, 100);
            this.txtKhu.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhu.Name = "txtKhu";
            this.txtKhu.Size = new System.Drawing.Size(153, 34);
            this.txtKhu.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 45);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 29);
            this.label11.TabIndex = 3;
            this.label11.Text = "Mã căn hộ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên chủ hộ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Khu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.BackColor = System.Drawing.Color.Transparent;
            this.lbTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTT.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTT.Location = new System.Drawing.Point(219, 735);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(27, 29);
            this.lbTT.TabIndex = 33;
            this.lbTT.Text = "0";
            // 
            // Form_ThemHoaDonDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::QuanLyChungCu.Properties.Resources._78d27defaed1369f866e7e21feadcbd9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1388, 836);
            this.Controls.Add(this.lbTT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grHD);
            this.Controls.Add(this.btnHoanThanh);
            this.Name = "Form_ThemHoaDonDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_ThemHoaDonDV";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDichVu)).EndInit();
            this.grHD.ResumeLayout(false);
            this.grHD.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSDichVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grHD;
        private System.Windows.Forms.Button btnChonDV;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Button btnThemDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdRoi;
        private System.Windows.Forms.RadioButton rdChua;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.TextBox txtTenCH;
        private System.Windows.Forms.TextBox txtKhu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCheck;
        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn madichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewButtonColumn btn;
    }
}