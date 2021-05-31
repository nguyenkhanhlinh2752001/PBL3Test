using QuanLyChungCu.BLL;
using QuanLyChungCu.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            lb_sai.Hide();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hay mật khẩu", "Cảnh báo");
            }
            else
            {
                if(TaikhoanBLL.Instance.Login(txt_username.Text, txt_password.Text))
                {
                    taikhoan tk = TaikhoanBLL.Instance.GetTaikhoan(txt_username.Text);
                    Form_QuanLy f = new Form_QuanLy(tk);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    lb_sai.Hide();
                    if (checkbox_remember.Checked)
                    {
                        Properties.Settings.Default.username = txt_username.Text;
                        Properties.Settings.Default.check = true;
                    }
                    else
                    {
                        Properties.Settings.Default.username = "";
                        Properties.Settings.Default.check = false;
                    } 
                    Properties.Settings.Default.Save();
                }
                else
                {
                    lb_sai.Show();
                }
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            txt_username.Text = Properties.Settings.Default.username;
            checkbox_remember.Checked = Properties.Settings.Default.check;
        }
    }
}
