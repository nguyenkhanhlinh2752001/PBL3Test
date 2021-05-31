using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChungCu.BLL;
namespace QuanLyChungCu.View
{
    public partial class Form_ThemDichVu : Form
    {
        public delegate void HienThi_delegate();
        public HienThi_delegate On_HienThi;
        int maDV;
        public Form_ThemDichVu(int madv)
        {
            InitializeComponent();
            maDV = madv;
            txtMaDV.Text = madv.ToString();
        }

        void ThemDichVu()
        {
            if (txtTenDV.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dichvu dv = new dichvu
                {
                    madichvu = maDV,
                    tendichvu = txtTenDV.Text,
                    gia = Convert.ToDouble(txtGia.Text),

                };
                DichvuBLL.Instance.ThemDichVu(dv);
                this.Close();
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            ThemDichVu();
            if (On_HienThi != null) On_HienThi();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressOnlyNumber(sender, e);
        }
    }
}