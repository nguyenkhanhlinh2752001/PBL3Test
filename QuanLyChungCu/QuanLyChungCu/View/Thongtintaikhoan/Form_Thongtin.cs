using QuanLyChungCu.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.View
{
    public partial class Form_Thongtin : Form
    {
        taikhoan tk = null;
        public Form_Thongtin(taikhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
            SetGUI();
        }
        public void SetGUI()
        {
            lb_tendangnhap.Text = tk.tendangnhap;
            lb_ngaydangnhap.Text = DateTime.Now.ToString();
            lb_manhanvien.Text = tk.manhanvien.ToString();
            lb_chucvu.Text = tk.nhanvien.chucvu.tenchucvu;
            txt_tennhanvien.Text = tk.nhanvien.tennhanvien;
            txt_cmnd.Text = tk.nhanvien.cmnd;
            txt_sdt.Text = tk.nhanvien.sdt;
            if (tk.nhanvien.gioitinh) rdB_Nam.Checked = true;
            else rdB_Nu.Checked = true;
            dTP_ngaysinh.Value = tk.nhanvien.ngaysinh;
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            if(txt_matkhaucu.Text == "" || txt_matkhaumoi.Text == "" || txt_xacnhan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ trước khi xác nhận", "Cảnh báo");
            }
            else
            {
                if(txt_matkhaucu.Text.CompareTo(tk.matkhau) == 0)
                {
                    if (txt_matkhaumoi.Text.CompareTo(txt_xacnhan.Text) == 0)
                    {
                        if (TaikhoanBLL.Instance.Doimatkhau(tk.tendangnhap, txt_matkhaumoi.Text))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                            this.tk = TaikhoanBLL.Instance.GetTaikhoan(tk.tendangnhap);
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu không chính xác", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác", "Thông báo");
                }
            }
        }

        private void btn_huydoimatkhau_Click(object sender, EventArgs e)
        {
            txt_matkhaucu.Text = "";
            txt_matkhaumoi.Text = "";
            txt_xacnhan.Text = "";
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if(txt_tennhanvien.Text == "" || txt_sdt.Text == "" || txt_cmnd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ trước khi xác nhận", "Cảnh báo");
            }
            else
            {
                nhanvien nv = new nhanvien
                {
                    manhanvien = (int)tk.manhanvien,
                    machucvu = tk.nhanvien.machucvu,
                    tennhanvien = txt_tennhanvien.Text,
                    cmnd = txt_cmnd.Text,
                    sdt = txt_sdt.Text,
                    gioitinh = rdB_Nam.Checked,
                    ngaysinh = dTP_ngaysinh.Value
                };
                if (NhanvienBLL.Instance.SuaThongtinNhanvien(nv))
                {
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                    this.tk = TaikhoanBLL.Instance.GetTaikhoan(tk.tendangnhap);
                    SetGUI();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại", "Thông báo");
                }
            }
        }

        private void btn_huycapnhat_Click(object sender, EventArgs e)
        {
            SetGUI();
        }


    }
}
