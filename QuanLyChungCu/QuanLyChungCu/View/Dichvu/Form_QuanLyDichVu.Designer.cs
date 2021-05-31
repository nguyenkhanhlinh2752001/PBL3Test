namespace QuanLyChungCu.View
{
    partial class Form_QuanLyDichVu
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
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvQuanLyDV = new System.Windows.Forms.DataGridView();
            this.madichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDV)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.BackColor = System.Drawing.Color.Transparent;
            this.gbDanhSach.Controls.Add(this.dgvQuanLyDV);
            this.gbDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDanhSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbDanhSach.Location = new System.Drawing.Point(39, 224);
            this.gbDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Padding = new System.Windows.Forms.Padding(4);
            this.gbDanhSach.Size = new System.Drawing.Size(898, 280);
            this.gbDanhSach.TabIndex = 42;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Kết quả tìm kiếm";
            // 
            // dgvQuanLyDV
            // 
            this.dgvQuanLyDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyDV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQuanLyDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuanLyDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvQuanLyDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvQuanLyDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madichvu,
            this.tendichvu,
            this.gia});
            this.dgvQuanLyDV.Location = new System.Drawing.Point(8, 31);
            this.dgvQuanLyDV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQuanLyDV.Name = "dgvQuanLyDV";
            this.dgvQuanLyDV.RowHeadersWidth = 51;
            this.dgvQuanLyDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLyDV.Size = new System.Drawing.Size(882, 241);
            this.dgvQuanLyDV.TabIndex = 3;
            this.dgvQuanLyDV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQuanLyDV_RowHeaderMouseDoubleClick);
            // 
            // madichvu
            // 
            this.madichvu.DataPropertyName = "madichvu";
            this.madichvu.HeaderText = "Mã dịch vụ";
            this.madichvu.MinimumWidth = 6;
            this.madichvu.Name = "madichvu";
            // 
            // tendichvu
            // 
            this.tendichvu.DataPropertyName = "tendichvu";
            this.tendichvu.HeaderText = "Tên dịch vụ";
            this.tendichvu.MinimumWidth = 6;
            this.tendichvu.Name = "tendichvu";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Đơn giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(257, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(484, 84);
            this.label5.TabIndex = 41;
            this.label5.Text = "QUẢN LÝ DỊCH VỤ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.White;
            this.btnChon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.Indigo;
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(726, 528);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(203, 67);
            this.btnChon.TabIndex = 45;
            this.btnChon.Text = "Chọn";
            this.btnChon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Indigo;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(647, 135);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(244, 60);
            this.btnDel.TabIndex = 38;
            this.btnDel.Text = "Xoá Dịch Vụ";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Indigo;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(85, 135);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(246, 60);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Thêm Dịch Vụ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form_QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 626);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Name = "Form_QuanLyDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyDichVu";
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.DataGridView dgvQuanLyDV;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn madichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
    }
}