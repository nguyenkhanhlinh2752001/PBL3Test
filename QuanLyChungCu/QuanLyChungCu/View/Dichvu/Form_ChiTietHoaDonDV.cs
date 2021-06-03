using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChungCu.BLL;

namespace QuanLyChungCu.View
{
    public partial class Form_ChiTietHoaDonDV : Form
    {

        private int maHD;
        private int maCH;
        private int maNV;
        private taikhoan tk;


        public Form_ChiTietHoaDonDV(int mahd, int mach, taikhoan tk)
        {
            InitializeComponent();
            maHD = mahd;
            maCH = mach;
            this.tk = tk;
            maNV = (int)tk.manhanvien;
            SetGui();
            LoadDSDichVu();
        }
        void SetGui()
        {
            txtMaHD.Text = maHD.ToString();
            dtpNgayLap.Value = (DateTime)HoadonBLL.Instance.LayThongTin1HoaDon(maHD).ngaylap;
            txtTien.Text = HoadonBLL.Instance.LayThongTin1HoaDon(maHD).tongtien.ToString();
            bool thanhtoan = HoadonBLL.Instance.LayThongTin1HoaDon(maHD).dathanhtoan;
            if (thanhtoan == true) rdRoi.Checked = true; else rdChua.Checked = true;

            //canho
            canho ch = CanhoBLL.Instance.LayThongTin1CanHo(maCH);
            txtMaCH.Text = maCH.ToString();
            txtKhu.Text = ch.khu.tenkhu.ToString();
            txtTenCH.Text = ch.hogiadinh.tenchuho.ToString();
            txtLCH.Text = ch.loaicanho.ToString();

            //nhanvien
            nhanvien nv = NhanvienBLL.Instance.LayThongTin1NhanVien(maNV);
            txtMaNV.Text = nv.manhanvien.ToString();
            txtTenNV.Text = nv.tennhanvien;
            txtSDTNV.Text = nv.sdt;
            bool gender = nv.gioitinh;
            if (gender == true) rdbNam.Checked = true; else rdbNu.Checked = true;
        }

        public void SuaHoaDonDV()
        {
            hoadondichvu hd = new hoadondichvu
            {
                mahoadon = Convert.ToInt32(txtMaHD.Text),
                macanho = Convert.ToInt32(txtMaCH.Text),
                manhanvien = Convert.ToInt32(txtMaNV.Text),
                tongtien = Convert.ToDouble(txtTien.Text),
                ngaylap = dtpNgayLap.Value,
                dathanhtoan = (rdRoi.Checked ? true : false),

            };
            HoadonBLL.Instance.SuaHoaDonDV(hd);
            MessageBox.Show("Sửa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void LoadDSDichVu()
        {
            dgvDSTDichVu.DataSource = HoadonBLL.Instance.HienThiDanhSachDichVuDaSuDung(maHD);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SuaHoaDonDV();
            Form_Dichvu f = new Form_Dichvu(this.tk);
            this.Close();
        }

        
    }
}