using System;
using System.Windows.Forms;
using QuanLyChungCu.BLL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;


namespace QuanLyChungCu.View
{
    public partial class Form_ThemHoaDonDV : Form
    {
        public delegate void HienThi_delegate();
        public HienThi_delegate On_HienThi;

        int maHD;
        taikhoan tk;
        public Form_ThemHoaDonDV(int mahd,taikhoan tk)
        {
            InitializeComponent();
            maHD = mahd;
            txtMaHD.Text = mahd.ToString();
            txtMaNV.Text = tk.manhanvien.ToString();
            nhanvien nv = NhanvienBLL.Instance.LayThongTin1NhanVien((int)tk.manhanvien);
            txtTenNV.Text = nv.tennhanvien;
        }

        public void HienThiDSDichVuDaChon()
        {
            dgvDSDichVu.DataSource = HoadonBLL.Instance.HienThiDSDichVuDaChon(maHD);
            TongTien();
        }
        void ThemHD()
        {
            hoadondichvu hd = new hoadondichvu
            {
                mahoadon = maHD,
                manhanvien = Convert.ToInt32(txtMaNV.Text),
                macanho = Convert.ToInt32(txtMaCH.Text),
                tongtien = Convert.ToDouble(lbTT.Text),
                dathanhtoan = false,
                ngaylap = dtpNgayLap.Value,


            };
            HoadonBLL.Instance.ThemHoaDonDV(hd);
        }

        private void TongTien()
        {
            int sum = 0;
            for (int i = 0; i < dgvDSDichVu.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvDSDichVu["thanhtien", i].Value);
            }
            lbTT.Text = sum.ToString();
        }

        public int SuaHoaDonDV()
        {
            hoadondichvu hd = new hoadondichvu
            {
                mahoadon = Convert.ToInt32(txtMaHD.Text),
                macanho = Convert.ToInt32(txtMaCH.Text),
                manhanvien = Convert.ToInt32(txtMaNV.Text),
                tongtien = Convert.ToDouble(lbTT.Text),
                ngaylap = dtpNgayLap.Value,
                dathanhtoan = (rdRoi.Checked ? true : false),

            };
            HoadonBLL.Instance.SuaHoaDonDV(hd);
            MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
        }

        void GUI()
        {
            btnChonDV.Visible = true;
            btnThemDon.Visible = false;
            dgvDSDichVu.DataSource = HoadonBLL.Instance.HienThiDSDichVuDaChon(maHD);
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        }

        void XuatPDF()
        {
            BaseFont bf = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\\fonts\\tahoma.ttf", BaseFont.IDENTITY_H, true);
            iTextSharp.text.Font textFontVLC = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD, BaseColor.BLUE);
            iTextSharp.text.Font textFontHeader = new iTextSharp.text.Font(bf, 25, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font textFont = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font damNghieng = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLDITALIC);
            iTextSharp.text.Font nhatNghieng = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.ITALIC);

            Paragraph pr = new Paragraph("CHUNG CƯ Phạm Nguyễn Hoàng Phan", textFontVLC);
            Paragraph diachi = new Paragraph("Địa chỉ: 54 Nguyễn Lương Bằng, phường Hòa Khánh Bắc, quận Liên Chiểu, Tp. Đà Nẵng\n", damNghieng);
            Paragraph sdt = new Paragraph("Số điện thoại: 0937581934\n", damNghieng);
            Paragraph mahd = new Paragraph("Mã hóa đơn: " + maHD, textFont);
            Paragraph header = new Paragraph("HÓA ĐƠN DỊCH VỤ", textFontHeader);

            string StrHD = @"Tên chủ hộ đang thuê: " + CanhoBLL.Instance.LayThongTin1CanHo(Convert.ToInt32(txtMaCH.Text)).hogiadinh.tenchuho + "\n" +
                "Mã căn hộ: " + txtMaCH.Text + "\n" +
                "Khu: " + CanhoBLL.Instance.LayThongTin1CanHo(Convert.ToInt32(txtMaCH.Text)).khu.tenkhu + "\n" +
                "Mã nhân viên: " + txtMaNV.Text + "\n" +
                "Ngày làm đơn: " + dtpNgayLap.Value.ToShortDateString() + "\n";
            Paragraph trong = new Paragraph("\n");
            Paragraph doanDau = new Paragraph(StrHD, textFont);
            PdfPTable ptable = new PdfPTable(dgvDSDichVu.ColumnCount);
            Paragraph tongtien = new Paragraph("Tổng tiền: " + lbTT.Text, textFont);
            tongtien.Alignment = 2;

            ptable.DefaultCell.Padding = 5;
            ptable.WidthPercentage = 100;
            ptable.HorizontalAlignment = Element.ALIGN_CENTER;
            ptable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn col in dgvDSDichVu.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, textFont));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                ptable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgvDSDichVu.Rows)
            {
                foreach (DataGridViewCell c in row.Cells)
                {
                    ptable.AddCell(new Phrase(c.Value.ToString(), textFont));
                }
            }

            var saveDia = new SaveFileDialog();
            saveDia.FileName = "HD" + maHD;

            saveDia.DefaultExt = ".pdf";

            if (saveDia.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fstream = new FileStream(saveDia.FileName, FileMode.Create))
                {
                    Document pdoc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                    PdfWriter pwr = PdfWriter.GetInstance(pdoc, fstream);
                    pdoc.Open();
                    pdoc.Add(pr);
                    pdoc.Add(diachi);
                    pdoc.Add(sdt);
                    pdoc.Add(mahd);
                    pdoc.Add(header);
                    pdoc.Add(doanDau);
                    pdoc.Add(trong);
                    pdoc.Add(ptable);
                    pdoc.Add(trong);
                    pdoc.Add(trong);
                    pdoc.Add(tongtien);
                    pdoc.Close();
                }
                Process.Start(saveDia.FileName);
            }
        }
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            SuaHoaDonDV();
            dgvDSDichVu.Columns.Remove("madichvu");
            dgvDSDichVu.Columns.Remove("btn");
            XuatPDF();
            Form_Dichvu f = new Form_Dichvu(this.tk);
            f.HienThiDanhSachHoaDon();
        }
        private void btnChonDV_Click(object sender, EventArgs e)
        {
            Form_QuanLyDichVu f = new Form_QuanLyDichVu(maHD);
            f.On_HienThi += HienThiDSDichVuDaChon;
            f.ShowDialog();
        }

        private void btnThemDon_Click(object sender, EventArgs e)
        {
            if (txtMaCH.Text == "")
            {
                MessageBox.Show("Cần nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            canho ch = CanhoBLL.Instance.LayThongTin1CanHo(Convert.ToInt32(txtMaCH.Text));
            if (ch.maho.Equals(null))
            {
                MessageBox.Show("Căn hộ chưa có người thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaCH.Text = "";
            }
            else
            {
                ThemHD();
                GUI();
                txtMaCH.Enabled = false;
            }
        }

        public void XoaDVKhoiHD()
        {
            int index = dgvDSDichVu.CurrentCell.RowIndex;
            int mahd = Convert.ToInt32(txtMaHD.Text);
            int madv = Convert.ToInt32(dgvDSDichVu.Rows[index].Cells["madichvu"].Value);
            HoadonBLL.Instance.XoaDichVuKhoiHD(mahd, madv);
            HienThiDSDichVuDaChon();
        }

        private void dgvDSDichVu_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvDSDichVu.Rows.Count <= 0)
            {
                btnHoanThanh.Enabled = false;
            }
            else
            {
                btnHoanThanh.Enabled = true;
            }
        }

        private void dgvDSDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.dgvDSDichVu.NewRowIndex)
                return;
            if (dgvDSDichVu.Columns[e.ColumnIndex].Name == "btn")
            {
                XoaDVKhoiHD();
            }
            else return;
        }

        private void txtMaCH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaCH.Text == "")
            {
                btnThemDon.Enabled = false;
                txtKhu.Clear();
                txtTenCH.Clear();
                lbCheck.Visible = false;
                return;
            }
            else if (HoadonBLL.Instance.KiemTraCanHoTonTai(Convert.ToInt32(txtMaCH.Text)) == false)
            {
                lbCheck.Visible = true;
                txtKhu.Clear();
                txtTenCH.Clear();
                lbCheck.Text = "Không tồn tại căn hộ này";
                btnThemDon.Enabled = false;
            }
            else
            {
                canho ch = CanhoBLL.Instance.LayThongTin1CanHo(Convert.ToInt32(txtMaCH.Text));
                if (ch.maho.Equals(null))
                {
                    lbCheck.Visible = true;
                    txtKhu.Clear();
                    txtTenCH.Clear();
                    lbCheck.Text = "Căn hộ chưa có người sở hữu";
                    btnThemDon.Enabled = false;
                }
                else
                {
                    btnThemDon.Enabled = true;
                    txtKhu.Text = ch.khu.tenkhu.ToString();
                    txtTenCH.Text = ch.hogiadinh.tenchuho.ToString();
                }
            }


        }

        void KeyPressOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Không cho nhập kí tự khác số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaCH_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressOnlyNumber(sender, e);
        }
    }
}