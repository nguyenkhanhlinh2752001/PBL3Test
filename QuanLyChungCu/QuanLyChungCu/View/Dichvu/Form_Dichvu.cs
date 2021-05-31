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
    public partial class Form_Dichvu : Form
    {
        taikhoan tk = null;
        public Form_Dichvu(taikhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
            HienThiDanhSachHoaDon();
            LoadCbxThoiGian();
            LoadCbxTimKiem();
        }

        public void HienThiDanhSachHoaDon()
        {
            dgvHoaDonDV.DataSource = HoadonBLL.Instance.HienThiDanhSachHoaDon();
            lbTongSoDon.Text = HoadonBLL.Instance.TongSoHoaDon().ToString();
            DoanhThu();
        }

        private void DoanhThu()
        {
            int sum = 0;
            for (int i = 0; i < dgvHoaDonDV.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvHoaDonDV["tongtien", i].Value);
            }
            lbTien.Text = sum.ToString("0,00.##");
        }

        public void LoadCbxThoiGian()
        {
            cbxThoiGian.Items.AddRange(new string[] { "Toàn bộ", "Ngày", "Từ ngày đến ngày" });
            cbxThoiGian.SelectedIndex = 0;
        }

        public void LoadCbxTimKiem()
        {
            cbxTimKiem.Items.AddRange(new string[] { "None", "Mã hóa đơn", "Mã căn hộ", "Tên nhân viên", "Thanh Toán" });
            cbxTimKiem.SelectedIndex = 0;
        }
        void TimKiem()
        {
            if (cbxThoiGian.SelectedIndex == -1 || cbxThoiGian.SelectedIndex == 0)
            {
                lbTu.Visible = false;
                lbDen.Visible = false;
                dtpTu.Visible = false;
                dtpDen.Visible = false;

                lbVao.Visible = false;
                dtpVao.Visible = false;
            }
            else if (cbxThoiGian.SelectedIndex == 1)
            {
                lbTu.Visible = false;
                lbDen.Visible = false;
                dtpTu.Visible = false;
                dtpDen.Visible = false;

                lbVao.Visible = true;
                dtpVao.Visible = true;

            }
            else if (cbxThoiGian.SelectedIndex == 2)
            {
                lbTu.Visible = true;
                lbDen.Visible = true;
                dtpTu.Visible = true;
                dtpDen.Visible = true;

                lbVao.Visible = false;
                dtpVao.Visible = false;
            }
        }
        private void cbxTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }


        private void dgvHoaDonDV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int mahd = int.Parse(dgvHoaDonDV.SelectedRows[0].Cells["mahoadon"].Value.ToString());
            int mach = Convert.ToInt32(HoadonBLL.Instance.LayMaCanHoTuMaHoaDon(mahd).ToString());
            int manv = Convert.ToInt32(HoadonBLL.Instance.LayMaNhanVienTuMaHoaDon(mahd).ToString());

            Form_ChiTietHoaDonDV f = new Form_ChiTietHoaDonDV(mahd, mach, this.tk);
            f.Show();
            this.Show();
        }

        private void btnThemHDDV_Click(object sender, EventArgs e)
        {
            Form_ThemHoaDonDV f = new Form_ThemHoaDonDV(HoadonBLL.Instance.LayMaHDLonNhat() + 1 , this.tk);
            f.On_HienThi += HienThiDanhSachHoaDon;
            f.ShowDialog();
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                btnTimKiem.Enabled = false;
            }
            else btnTimKiem.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int choice = cbxTimKiem.SelectedIndex;
            if (choice == 0)
            {
                if (cbxThoiGian.SelectedIndex == 0)
                {
                    HienThiDanhSachHoaDon();
                    txtTimKiem.Clear();
                }
                else if (cbxThoiGian.SelectedIndex == 1)
                    dgvHoaDonDV.DataSource = HoadonBLL.Instance.DanhSachHoaDonVaoNgay(dtpVao.Value.Date);
                else
                    dgvHoaDonDV.DataSource = HoadonBLL.Instance.DanhSachHoaDonNgayDenNgay(dtpTu.Value.Date, dtpDen.Value.Date);
                txtTimKiem.Enabled = false;
            }
            else if (choice == 1)
            {
                dgvHoaDonDV.DataSource = HoadonBLL.Instance.HoaDonTheoMaHD(Convert.ToInt32(txtTimKiem.Text));
            }
            else if (choice == 2)
            {
                if (cbxThoiGian.SelectedIndex == 0)
                    dgvHoaDonDV.DataSource = HoadonBLL.Instance.DanhSachHoaDonTheoMaCH(Convert.ToInt32(txtTimKiem.Text));
                else if (cbxThoiGian.SelectedIndex == 1)
                    dgvHoaDonDV.DataSource = HoadonBLL.Instance.DanhSachHoaDonTheoMaCHVaoNgay(dtpVao.Value.Date, Convert.ToInt32(txtTimKiem.Text));
                else
                    dgvHoaDonDV.DataSource = HoadonBLL.Instance.DanhSachHoaDonTheoMaCHNgayDenNgay(dtpTu.Value.Date, dtpDen.Value.Date, Convert.ToInt32(txtTimKiem.Text));
            }
            else if (choice == 3)
            {
                if (cbxThoiGian.SelectedIndex == 0)
                    dgvHoaDonDV.DataSource = HoadonBLL.Instance.DanhSachHoaDonTheoTenNV(txtTimKiem.Text);
                else if (cbxThoiGian.SelectedIndex == 1)
                    dgvHoaDonDV.DataSource = HoadonBLL.Instance.DanhSachHoaDonTheoTenNVVaoNgay(dtpVao.Value.Date, txtTimKiem.Text);
                else
                    dgvHoaDonDV.DataSource = HoadonBLL.Instance.DanhSachHoaDonTheoTenNVNgayDenNgay(dtpTu.Value.Date, dtpDen.Value.Date, txtTimKiem.Text);
            }
            else if (choice == 4)
            {
                if (cbxThoiGian.SelectedIndex == 0)
                    dgvHoaDonDV.DataSource = HoadonBLL.Instance.DanhSachHoaDonTheoThanhToan(rdRoi.Checked ? true : false);
                else if (cbxThoiGian.SelectedIndex == 1)
                    dgvHoaDonDV.DataSource = HoadonBLL.Instance.DanhSachHoaDonTheoThanhToanVaoNgay(dtpVao.Value.Date, rdRoi.Checked ? true : false);
                else
                    dgvHoaDonDV.DataSource = HoadonBLL.Instance.DanhSachHoaDonTheoThanhToanNgayDenNgay(dtpTu.Value.Date, dtpDen.Value.Date, rdRoi.Checked ? true : false);
            }
            DoanhThu();

        }
        private void cbxTimKiem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxTimKiem.SelectedIndex == 0)
            {
                txtTimKiem.Enabled = false;
                txtTimKiem.Visible = true;
                rdChua.Visible = false;
                rdRoi.Visible = false;
                txtTimKiem.Clear();
                cbxThoiGian.Enabled = true;
                btnTimKiem.Enabled = true;
            }
            else if (cbxTimKiem.SelectedIndex == 1)
            {
                txtTimKiem.Enabled = true;
                cbxThoiGian.Enabled = false;
                cbxThoiGian.SelectedIndex = 0;
                if (txtTimKiem.Text == "")
                {
                    btnTimKiem.Enabled = false;
                }
                else
                {
                    btnTimKiem.Enabled = true;
                }
            }
            else if (cbxTimKiem.SelectedIndex == 4)
            {
                btnTimKiem.Enabled = true;
                txtTimKiem.Visible = false;
                rdChua.Visible = true;
                rdRoi.Visible = true;
                cbxThoiGian.Enabled = true;
            }
            else
            {
                if (txtTimKiem.Text == "")
                {
                    btnTimKiem.Enabled = false;
                }
                else
                {
                    btnTimKiem.Enabled = true;
                }
                txtTimKiem.Enabled = true;
                txtTimKiem.Visible = true;
                rdChua.Visible = false;
                rdRoi.Visible = false;
                cbxThoiGian.Enabled = true;
                txtTimKiem.Clear();
            }
        }

        private void dgvHoaDonDV_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int numRows = dgvHoaDonDV.Rows.Count;
            lbTongSoDon.Text = numRows.ToString();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            HienThiDanhSachHoaDon();
            cbxThoiGian.SelectedIndex = 0;
            cbxTimKiem.SelectedIndex = 0;
            txtTimKiem.Clear();
            btnTimKiem.Enabled = true;
        }

        void KeyPressOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Không cho nhập kí tự khác số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            int choice = cbxTimKiem.SelectedIndex;
            if (choice == 1 || choice == 2)
            {
                KeyPressOnlyNumber(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_QuanLyDichVu f = new Form_QuanLyDichVu();
            f.ShowDialog();
        }
    }
}