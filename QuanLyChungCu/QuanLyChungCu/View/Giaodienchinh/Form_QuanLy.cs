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
    public partial class Form_QuanLy : Form
    {
        taikhoan tk = null;
        Form_ChoThue ChoThue = null;
        Form_Dichvu Dichvu = null;
        Form_Hopdong Hopdong = null;
        Form_Nhanvien Nhanvien = null;
        Form_Canho Canho = null;
        Form_Thongtin Thongtin = null;
        public Form_QuanLy(taikhoan tk)
        {
            this.tk = tk;
            CreateForms();
            InitializeComponent(); 
        }
        #region Function
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach(Form i in this.MdiChildren)
            {
                if(i.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form i in this.MdiChildren)
            {
                if (i.Name == name)
                {
                    i.Activate();
                    break;
                }
            }
        }
        private void CreateForms()
        {
            ChoThue = new Form_ChoThue(TaikhoanBLL.Instance.GetTimeLanCuoi());
            Dichvu = new Form_Dichvu(tk);
            Hopdong = new Form_Hopdong();
            Nhanvien = new Form_Nhanvien();
            Canho = new Form_Canho();
            Thongtin = new Form_Thongtin(tk);
        }
        private void LoadTaiKhoan()
        {
            this.tk = TaikhoanBLL.Instance.GetTaikhoan(tk.tendangnhap);
            Dichvu.Close();
            Thongtin.Close();
            Dichvu = new Form_Dichvu(tk);
            Thongtin = new Form_Thongtin(tk);
        }
        private void SetbtnColor(Button btn)
        {
            lb_Tieude.Text = btn.Text;
            foreach(Control i in pnl_btnChucNang.Controls)
            {
                i.BackColor = pnl_btnChucNang.BackColor;
            }
            btn_help.BackColor = pnl_btnChucNang.BackColor;
            btn.BackColor = Color.Fuchsia;
        }
        #endregion
        #region Event
        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel);
            if (t == DialogResult.OK)
            {
                if(TaikhoanBLL.Instance.SetTimeDangNhaplancuoi(this.tk.tendangnhap,DateTime.Now)) this.Dispose();
            }
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            panel1.Width = (panel1.Width == 375) ? 50 : 375;
            panel5.Width = (panel5.Width == 0) ? 325 : 0;
        }
        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_ChoThue_Click(object sender, EventArgs e)
        {
            SetbtnColor(sender as Button);
            if (!CheckExistForm("Form_ChoThue"))
            {
                ChoThue.MdiParent = this;
                ChoThue.StartPosition = FormStartPosition.Manual;
                ChoThue.Width = 1156;
                ChoThue.Height = 802;
                ChoThue.Show();
            }
            else ActiveChildForm("Form_ChoThue");
        }
        private void btn_Dichvu_Click(object sender, EventArgs e)
        {
            SetbtnColor(sender as Button);
            if (!CheckExistForm("Form_Dichvu"))
            {
                Dichvu.MdiParent = this;
                Dichvu.StartPosition = FormStartPosition.Manual;
                Dichvu.Width = 1156;
                Dichvu.Height = 802;
                Dichvu.Show();
            }
            else ActiveChildForm("Form_Dichvu");
        }
        private void btn_Hopdong_Click(object sender, EventArgs e)
        {
            SetbtnColor(sender as Button);
            if (!CheckExistForm("Form_Hopdong"))
            {
                Hopdong.MdiParent = this;
                Hopdong.StartPosition = FormStartPosition.Manual;
                Hopdong.Width = 1156;
                Hopdong.Height = 802;
                Hopdong.Show();
            }
            else ActiveChildForm("Form_Hopdong");
        }
        private void btn_help_Click(object sender, EventArgs e)
        {
            SetbtnColor(sender as Button);
        }
        private void btn_Nhanvien_Click(object sender, EventArgs e)
        {
            SetbtnColor(sender as Button);
            if (!CheckExistForm("Form_Nhanvien"))
            {
                Nhanvien.MdiParent = this;
                Nhanvien.StartPosition = FormStartPosition.Manual;
                Nhanvien.Width = 1156;
                Nhanvien.Height = 802;
                Nhanvien.Show();
            }
            else ActiveChildForm("Form_Nhanvien");
        }
        private void btn_Canho_Click(object sender, EventArgs e)
        {
            SetbtnColor(sender as Button);
            if (!CheckExistForm("Form_Canho"))
            {
                Canho.MdiParent = this;
                Canho.StartPosition = FormStartPosition.Manual;
                Canho.Width = 1156;
                Canho.Height = 802;
                Canho.mydel += new Form_Canho.Mydel(ChoThue.LoadCanho);
                Canho.Show();
            }
            else ActiveChildForm("Form_Canho");
        }

        private void btn_Thongtin_Click(object sender, EventArgs e)
        {
            SetbtnColor(sender as Button);
            if (!CheckExistForm("Form_Thongtin"))
            {
                Thongtin.MdiParent = this;
                Thongtin.StartPosition = FormStartPosition.Manual;
                Thongtin.Width = 1156;
                Thongtin.Height = 802;
                Thongtin.Show();
            }
            else ActiveChildForm("Form_Thongtin");
        }
        private void Form_QuanLy_Load(object sender, EventArgs e)
        {
            if(this.tk.nhanvien.machucvu == 2)
            {
                btn_Canho.Hide();
                btn_Nhanvien.Hide();
                btn_Dichvu.Hide();
                btn_ChoThue.PerformClick();
            }
            else if(this.tk.nhanvien.machucvu == 3)
            {
                btn_ChoThue.Hide();
                btn_Canho.Hide();
                btn_Hopdong.Hide();
                btn_Nhanvien.Hide();
                btn_Dichvu.PerformClick();
            }
            else btn_ChoThue.PerformClick();
        }

        #endregion

        
    }
}
