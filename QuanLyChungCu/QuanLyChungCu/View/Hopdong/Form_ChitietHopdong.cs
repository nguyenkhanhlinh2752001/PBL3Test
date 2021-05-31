using QuanLyChungCu.BLL;
using QuanLyChungCu.DAL;
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
    public partial class Form_ChitietHopdong : Form
    {
        public delegate void mydel();
        public mydel d { get; set; }
        int MaHD;
        public Form_ChitietHopdong(int MAHD)
        {
            InitializeComponent();
            this.MaHD = MAHD;
            SetGUI();
        }
        public void SetGUI()
        {
            if (this.MaHD != 0)
            {
                this.Text = "Sửa hợp đồng";
                hopdong a = HopdongBLL.Instance.GetHDdetail(this.MaHD);
                txtMaHD.Text = (a.mahopdong).ToString();
                txtMaHD.Enabled = false;
                txtTenHD.Text = a.tenhopdong.ToString();
                txtThoiHan.Text = a.thoihan.ToString();
                txtGiaTien.Text = a.giatien.ToString();
                txtThoiHan.Text = a.thoihan.ToString();
                dateTimePicker1.Value = a.ngayki;
                foreach (nhanvien i in NhanvienBLL.Instance.GetALLNhanVien())
                {
                    if (i.machucvu != 3)
                    {
                        cbbMaNHv.Items.Add(new CBBNhanvien
                        {
                            Value = i.manhanvien,
                            Text = i.tennhanvien
                        });
                        if (i.manhanvien == a.manhanvien) cbbMaNHv.Text = i.tennhanvien;
                    }
                }
                foreach (canho i in CanhoBLL.Instance.GetAllCanho())
                {
                    cbbMaCanHo.Items.Add(i.macanho);
                    if (i.macanho == a.macanho) cbbMaCanHo.Text = i.macanho.ToString();
                }
                foreach (hogiadinh i in HogiadinhBLL.Instance.GetAllHogiadinh())
                {
                    cbbHogiadinh.Items.Add(new CBBHogiadinh
                    {
                        Text = i.tenchuho,
                        Value = i.maho
                    });
                    if (i.maho == a.maho) cbbHogiadinh.Text = i.tenchuho;
                }
            }
            else
            {
                this.Text = "S hợp đồng";
                foreach (nhanvien i in NhanvienBLL.Instance.GetALLNhanVien())
                {
                    if (i.machucvu != 3)
                    {
                        cbbMaNHv.Items.Add(new CBBNhanvien
                        {
                            Value = i.manhanvien,
                            Text = i.tennhanvien
                        });
                    }
                }
                foreach (canho i in CanhoBLL.Instance.GetAllCanho())
                {
                    cbbMaCanHo.Items.Add(i.macanho);
                }
                foreach (hogiadinh i in HogiadinhBLL.Instance.GetAllHogiadinh())
                {
                    cbbHogiadinh.Items.Add(new CBBHogiadinh
                    {
                        Text = i.tenchuho,
                        Value = i.maho
                    });
                }
            }
        }
        public bool Check()
        {
            double tien;

            if (txtMaHD.Enabled == false) //edit
            {
                if (double.TryParse(txtGiaTien.Text, out tien) && txtThoiHan.Text.All(char.IsDigit))
                {
                    return true;
                }
            }
            else // add
            {
                if (txtMaHD.Text.All(char.IsDigit) && HopdongBLL.Instance.GetHDdetail(Convert.ToInt32(txtMaHD.Text)) == null)
                {
                    if (double.TryParse(txtGiaTien.Text, out tien) && txtThoiHan.Text.All(char.IsDigit))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                try
                {
                    hopdong a = new hopdong();
                    a.mahopdong = Convert.ToInt32(txtMaHD.Text);
                    a.manhanvien = ((CBBNhanvien)cbbMaNHv.SelectedItem).Value;
                    a.macanho = Convert.ToInt32(cbbMaCanHo.SelectedItem);
                    a.maho = Convert.ToInt32(((CBBHogiadinh)cbbHogiadinh.SelectedItem).Value);
                    a.tenhopdong = txtTenHD.Text;
                    a.giatien = Convert.ToDouble(txtGiaTien.Text);
                    a.thoihan = Convert.ToInt32(txtThoiHan.Text);
                    a.ngayki = dateTimePicker1.Value;
                    a.dahuy = false;

                    HopdongBLL.Instance.AddorUpdate(a);
                    d();
                    this.Close();
                }
                catch (Exception t)
                {

                }
            }
            else
            {
                MessageBox.Show("sai Format or trung MaHD ");
                this.Close();
            }
        }

        private void btEixt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}