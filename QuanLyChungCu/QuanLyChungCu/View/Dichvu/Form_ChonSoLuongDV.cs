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

    public partial class Form_ChonSoLuongDV : Form
    {
        int maHD;
        int maDV;

        public Form_ChonSoLuongDV(int mahd, int madv)
        {
            InitializeComponent();
            maHD = mahd;
            maDV = madv;
        }

        void ThemDichVuVaoHoaDon()
        {
            chitiethoadon cthd = new chitiethoadon
            {
                mahoadon = maHD,
                madichvu = maDV,
                soluong = Convert.ToInt32(txtSoLuong.Text),
            };
            HoadonBLL.Instance.ThemDichVuVaoHD(cthd);
            this.Close();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ThemDichVuVaoHoaDon();
        }

        private void Form_ChonSoLuongDV_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = maHD.ToString();
            txtMaDV.Text = maDV.ToString();
            txtSoLuong.Text = "1";
        }

        void KeyPressOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Không cho nhập kí tự khác số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressOnlyNumber(sender, e);
        }
    }
}