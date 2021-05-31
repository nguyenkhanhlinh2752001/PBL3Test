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
using QuanLyChungCu.BLL;

namespace QuanLyChungCu.View
{
    public partial class Form_Hopdong : Form
    {
        public Form_Hopdong()
        {
            InitializeComponent();
            ShowAllHDViews();
        }
        void SetDGV()
        {
            dataGridView1.Columns[0].HeaderText = "Mã";
            dataGridView1.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView1.Columns[2].HeaderText = "Mã căn hộ";
            dataGridView1.Columns[3].HeaderText = "Tên chủ hộ";
            dataGridView1.Columns[4].HeaderText = "Tên hợp đồng";
            dataGridView1.Columns[5].HeaderText = "Giá tiền";
            dataGridView1.Columns[6].HeaderText = "Thời hạn(tháng)";
            dataGridView1.Columns[7].HeaderText = "Ngày kí";
            dataGridView1.Columns[8].HeaderText = "Hủy";
        }
        public void ShowAllHDViews()
        {
            dataGridView1.DataSource = HopdongBLL.Instance.GetALLHDViews();
            SetDGV();
        }
        private void BtsearchNameID_Click(object sender, EventArgs e)
        {
            if (TXTsearch.TextLength == 0)
            {
                ShowAllHDViews();
            }
            else
            {
                if (TXTsearch.Text.All(char.IsDigit))
                {
                    int value = Convert.ToInt32(TXTsearch.Text);
                    dataGridView1.DataSource = HopdongBLL.Instance.GetHDbyIDViews(value);
                }
                else
                {
                    string name = TXTsearch.Text;
                    dataGridView1.DataSource = HopdongBLL.Instance.GetHDByNameViews(name);
                }
                SetDGV();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form_ChitietHopdong a = new Form_ChitietHopdong(0);
            a.d += new Form_ChitietHopdong.mydel(ShowAllHDViews);
            a.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int IDHD = (int)dataGridView1.SelectedRows[0].Cells["mahopdong"].Value;
                Form_ChitietHopdong a = new Form_ChitietHopdong(IDHD);
                a.d += new Form_ChitietHopdong.mydel(ShowAllHDViews);
                a.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ chọn một hợp đồng", "Cảnh báo");
            }
        }

        private void btSearchdate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = HopdongBLL.Instance.GetHDViewsByTime(dateTimePickerNgayKi.Value.Date, dateTimePickerNgayHetHan.Value.Date);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    int MAHD = Convert.ToInt32(i.Cells["mahopdong"].Value);
                    HopdongBLL.Instance.Delete(MAHD);
                }
                ShowAllHDViews();
            }
        }
        public bool check1()
        {
            if (txtMAHO.Text.All(char.IsDigit) && HogiadinhBLL.Instance.GetHoGiaDinhByid(Convert.ToInt32(txtMAHO.Text)) == null)
            {
                return true;
            }
            return false;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            if (txtMAHO.TextLength > 0 && txtNamechuho.TextLength > 0 && cbbthanhvien.SelectedIndex >= 0)
            {
                if (check1() == true)
                {
                    hogiadinh a = new hogiadinh();
                    a.maho = Convert.ToInt32(txtMAHO.Text);
                    a.tenchuho = txtNamechuho.Text.ToString();
                    a.sothanhvien = Convert.ToInt32(cbbthanhvien.SelectedItem);
                    HogiadinhBLL.Instance.Themhogiadinh(a);
                    MessageBox.Show("Đăng kí thành công!","Thông báo");
                    btEdit_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã hộ bị trùng!");
                    var l1 = HogiadinhBLL.Instance.GetAllHogiadinh();
                    string dem = "ma so : ";
                    foreach (hogiadinh i in l1)
                    {
                        dem += " " + i.maho;
                    }
                    MessageBox.Show("Không được trùng các mã hộ:  " + dem);
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            txtMAHO.Clear();
            txtNamechuho.Clear();
            cbbthanhvien.SelectedIndex = -1;
        }


    }

}