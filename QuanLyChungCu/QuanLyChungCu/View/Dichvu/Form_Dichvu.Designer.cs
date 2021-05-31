namespace QuanLyChungCu.View
{
    partial class Form_Dichvu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDonDV = new System.Windows.Forms.DataGridView();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dathanhtoan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbDen = new System.Windows.Forms.Label();
            this.lbVao = new System.Windows.Forms.Label();
            this.lbTu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxThoiGian = new System.Windows.Forms.ComboBox();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.dtpVao = new System.Windows.Forms.DateTimePicker();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.lbTongSoDon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxTimKiem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdRoi = new System.Windows.Forms.RadioButton();
            this.rdChua = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnThemHDDV = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonDV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Fuchsia;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(1460, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 902);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Fuchsia;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 900);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1460, 2);
            this.label2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHoaDonDV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(42, 362);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1394, 471);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvHoaDonDV
            // 
            this.dgvHoaDonDV.AllowUserToAddRows = false;
            this.dgvHoaDonDV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvHoaDonDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDonDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonDV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHoaDonDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDonDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHoaDonDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDonDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDonDV.ColumnHeadersHeight = 50;
            this.dgvHoaDonDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.macanho,
            this.tennhanvien,
            this.tongtien,
            this.ngaylap,
            this.dathanhtoan});
            this.dgvHoaDonDV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvHoaDonDV.Location = new System.Drawing.Point(16, 30);
            this.dgvHoaDonDV.Name = "dgvHoaDonDV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDonDV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDonDV.RowHeadersWidth = 51;
            this.dgvHoaDonDV.RowTemplate.Height = 24;
            this.dgvHoaDonDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonDV.Size = new System.Drawing.Size(1354, 420);
            this.dgvHoaDonDV.TabIndex = 0;
            this.dgvHoaDonDV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHoaDonDV_RowHeaderMouseDoubleClick);
            this.dgvHoaDonDV.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvHoaDonDV_RowStateChanged);
            // 
            // mahoadon
            // 
            this.mahoadon.DataPropertyName = "mahoadon";
            this.mahoadon.HeaderText = "Mã hóa đơn";
            this.mahoadon.MinimumWidth = 6;
            this.mahoadon.Name = "mahoadon";
            // 
            // macanho
            // 
            this.macanho.DataPropertyName = "macanho";
            this.macanho.HeaderText = "Mã căn hộ";
            this.macanho.MinimumWidth = 6;
            this.macanho.Name = "macanho";
            // 
            // tennhanvien
            // 
            this.tennhanvien.DataPropertyName = "tennhanvien";
            this.tennhanvien.HeaderText = "Nhân viên";
            this.tennhanvien.MinimumWidth = 6;
            this.tennhanvien.Name = "tennhanvien";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            // 
            // dathanhtoan
            // 
            this.dathanhtoan.DataPropertyName = "dathanhtoan";
            this.dathanhtoan.HeaderText = "Đã thanh toán";
            this.dathanhtoan.MinimumWidth = 6;
            this.dathanhtoan.Name = "dathanhtoan";
            this.dathanhtoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dathanhtoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDen.ForeColor = System.Drawing.Color.Indigo;
            this.lbDen.Location = new System.Drawing.Point(871, 120);
            this.lbDen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(60, 29);
            this.lbDen.TabIndex = 33;
            this.lbDen.Text = "Đến";
            // 
            // lbVao
            // 
            this.lbVao.AutoSize = true;
            this.lbVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVao.ForeColor = System.Drawing.Color.Purple;
            this.lbVao.Location = new System.Drawing.Point(531, 120);
            this.lbVao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVao.Name = "lbVao";
            this.lbVao.Size = new System.Drawing.Size(58, 29);
            this.lbVao.TabIndex = 34;
            this.lbVao.Text = "Vào";
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTu.ForeColor = System.Drawing.Color.Indigo;
            this.lbTu.Location = new System.Drawing.Point(531, 120);
            this.lbTu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(44, 29);
            this.lbTu.TabIndex = 35;
            this.lbTu.Text = "Từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(11, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Thời gian";
            // 
            // cbxThoiGian
            // 
            this.cbxThoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxThoiGian.FormattingEnabled = true;
            this.cbxThoiGian.Location = new System.Drawing.Point(219, 116);
            this.cbxThoiGian.Margin = new System.Windows.Forms.Padding(4);
            this.cbxThoiGian.Name = "cbxThoiGian";
            this.cbxThoiGian.Size = new System.Drawing.Size(264, 37);
            this.cbxThoiGian.TabIndex = 32;
            this.cbxThoiGian.SelectedIndexChanged += new System.EventHandler(this.cbxTimKiem_SelectedIndexChanged);
            // 
            // dtpDen
            // 
            this.dtpDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDen.Location = new System.Drawing.Point(939, 120);
            this.dtpDen.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(228, 34);
            this.dtpDen.TabIndex = 27;
            // 
            // dtpVao
            // 
            this.dtpVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVao.Location = new System.Drawing.Point(602, 120);
            this.dtpVao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVao.Name = "dtpVao";
            this.dtpVao.Size = new System.Drawing.Size(228, 34);
            this.dtpVao.TabIndex = 28;
            // 
            // dtpTu
            // 
            this.dtpTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTu.Location = new System.Drawing.Point(602, 120);
            this.dtpTu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(228, 34);
            this.dtpTu.TabIndex = 29;
            // 
            // lbTongSoDon
            // 
            this.lbTongSoDon.AutoSize = true;
            this.lbTongSoDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSoDon.ForeColor = System.Drawing.Color.Purple;
            this.lbTongSoDon.Location = new System.Drawing.Point(1329, 847);
            this.lbTongSoDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongSoDon.Name = "lbTongSoDon";
            this.lbTongSoDon.Size = new System.Drawing.Size(54, 29);
            this.lbTongSoDon.TabIndex = 24;
            this.lbTongSoDon.Text = "xuly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(1123, 847);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tổng số đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(53, 864);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 29);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tổng doanh thu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(391, 868);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "VNĐ";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTien.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTien.Location = new System.Drawing.Point(262, 865);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(26, 29);
            this.lbTien.TabIndex = 43;
            this.lbTien.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(7, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 29);
            this.label7.TabIndex = 44;
            this.label7.Text = "Tìm kiếm theo";
            // 
            // cbxTimKiem
            // 
            this.cbxTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimKiem.FormattingEnabled = true;
            this.cbxTimKiem.Location = new System.Drawing.Point(219, 28);
            this.cbxTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTimKiem.Name = "cbxTimKiem";
            this.cbxTimKiem.Size = new System.Drawing.Size(258, 37);
            this.cbxTimKiem.TabIndex = 45;
            this.cbxTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbxTimKiem_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(531, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 29);
            this.label8.TabIndex = 46;
            this.label8.Text = "Nhập từ khóa";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Enabled = false;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(732, 29);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(272, 36);
            this.txtTimKiem.TabIndex = 47;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // rdRoi
            // 
            this.rdRoi.AutoSize = true;
            this.rdRoi.Checked = true;
            this.rdRoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRoi.ForeColor = System.Drawing.Color.Indigo;
            this.rdRoi.Location = new System.Drawing.Point(746, 32);
            this.rdRoi.Name = "rdRoi";
            this.rdRoi.Size = new System.Drawing.Size(71, 33);
            this.rdRoi.TabIndex = 49;
            this.rdRoi.TabStop = true;
            this.rdRoi.Text = "Rồi";
            this.rdRoi.UseVisualStyleBackColor = true;
            this.rdRoi.Visible = false;
            // 
            // rdChua
            // 
            this.rdChua.AutoSize = true;
            this.rdChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChua.ForeColor = System.Drawing.Color.Indigo;
            this.rdChua.Location = new System.Drawing.Point(897, 32);
            this.rdChua.Name = "rdChua";
            this.rdChua.Size = new System.Drawing.Size(90, 33);
            this.rdChua.TabIndex = 50;
            this.rdChua.Text = "Chưa";
            this.rdChua.UseVisualStyleBackColor = true;
            this.rdChua.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxTimKiem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.rdChua);
            this.groupBox2.Controls.Add(this.dtpTu);
            this.groupBox2.Controls.Add(this.rdRoi);
            this.groupBox2.Controls.Add(this.dtpVao);
            this.groupBox2.Controls.Add(this.dtpDen);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.cbxThoiGian);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbTu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbVao);
            this.groupBox2.Controls.Add(this.lbDen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox2.Location = new System.Drawing.Point(58, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1370, 183);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimKiem.Enabled = false;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Purple;
            this.btnTimKiem.Image = global::QuanLyChungCu.Properties.Resources.icons8_search_64__2_;
            this.btnTimKiem.Location = new System.Drawing.Point(1255, 71);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(89, 75);
            this.btnTimKiem.TabIndex = 48;
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::QuanLyChungCu.Properties.Resources.icons8_customer_insight_100;
            this.button1.Location = new System.Drawing.Point(58, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 117);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTatCa
            // 
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.ForeColor = System.Drawing.Color.Indigo;
            this.btnTatCa.Image = global::QuanLyChungCu.Properties.Resources.icons8_eye_50;
            this.btnTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTatCa.Location = new System.Drawing.Point(869, 44);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(246, 69);
            this.btnTatCa.TabIndex = 52;
            this.btnTatCa.Text = "Hiển Thị Tất Cả";
            this.btnTatCa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnThemHDDV
            // 
            this.btnThemHDDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHDDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHDDV.ForeColor = System.Drawing.Color.Indigo;
            this.btnThemHDDV.Image = global::QuanLyChungCu.Properties.Resources.icons8_add_dollar_55;
            this.btnThemHDDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHDDV.Location = new System.Drawing.Point(1183, 44);
            this.btnThemHDDV.Name = "btnThemHDDV";
            this.btnThemHDDV.Size = new System.Drawing.Size(245, 69);
            this.btnThemHDDV.TabIndex = 39;
            this.btnThemHDDV.Text = "Thêm hóa đơn";
            this.btnThemHDDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHDDV.UseVisualStyleBackColor = true;
            this.btnThemHDDV.Click += new System.EventHandler(this.btnThemHDDV_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Image = global::QuanLyChungCu.Properties.Resources.icons8_add_dollar_55;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(544, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 69);
            this.button2.TabIndex = 54;
            this.button2.Text = "Dịch vụ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1462, 902);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTatCa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThemHDDV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTongSoDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dichvu";
            this.Text = "Form_DichVu";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonDV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.Label lbVao;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxThoiGian;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.DateTimePicker dtpVao;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.Label lbTongSoDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHoaDonDV;
        private System.Windows.Forms.Button btnThemHDDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdRoi;
        private System.Windows.Forms.RadioButton rdChua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn macanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dathanhtoan;
        private System.Windows.Forms.Button button2;
    }
}