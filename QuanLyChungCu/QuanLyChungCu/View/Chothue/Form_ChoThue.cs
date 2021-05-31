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
    public partial class Form_ChoThue : Form
    {
        private static Button btnBefore = null;
        DateTime dt;
        public Form_ChoThue(DateTime dt)
        {
            this.dt = dt;
            InitializeComponent();
            pnl_canho.Width = 756;
            LoadCanho();
            Setlistview();
        }
        #region Function
        public void LoadCanho()
        {
            pnl_canho.Controls.Clear();
            List<khu> listkhu = KhuBLL.Instance.GetAllKhu();
            listkhu.Reverse();
            int z = 0;
            foreach (khu i in listkhu)
            {
                GroupBox k = new GroupBox();
                FlowLayoutPanel flp = new FlowLayoutPanel();
                k.Text = i.tenkhu;
                k.Font = new Font("Comic Sans MS", 14F);
                k.ForeColor = Color.Purple;
                k.Dock = DockStyle.Top;
                k.Height = 160;
                k.Controls.Add(flp);
                flp.Dock = DockStyle.Fill;
                flp.BackColor = Color.Plum;
                int o = 1;
                foreach (canho j in CanhoBLL.Instance.GetListCanhoByKhu(i.makhu))
                {
                    Button btn = new Button();
                    btn.Width = 60;
                    btn.Height = 60;
                    btn.Text = o.ToString(); o++;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
                    btn.FlatAppearance.MouseOverBackColor = Color.Violet;
                    btn.BackColor = Color.Plum;
                    if(HopdongBLL.Instance.GetHopdongDavao(j.macanho) != null)
                    {
                        btn.Image = Properties.Resources.home_2855790__1_;
                        btn.ForeColor = Color.MediumVioletRed;
                    }
                    else
                    {
                        if (HopdongBLL.Instance.GetListHopdongChuavao(j.macanho).Count == 0)
                        {
                            btn.Image = Properties.Resources.home;
                            z++;
                        }
                        else
                        {
                            btn.Image = Properties.Resources.home_2855790;
                            btn.ForeColor = Color.BlueViolet;
                        }
                    }
                    btn.Click += Btn_Click;
                    btn.Tag = j.macanho;
                    if (btnBefore != null && j.macanho == Convert.ToInt32(btnBefore.Tag))
                    {
                        SetbtnColor(btn);
                        btnBefore = btn;
                        SetVatdung(Convert.ToInt32(btn.Tag));
                    }
                    flp.Controls.Add(btn);
                }
                pnl_canho.Controls.Add(k);
                lb_trong.Text = "Còn " + z + " căn hộ trống";
            }
        }
        private void SetbtnColor(Button btn)
        {
            if (btnBefore != null && btnBefore != btn) btnBefore.BackColor = pnl_canho.BackColor;
            btn.BackColor = Color.Fuchsia;
        }
        private void SetGUI(int macanho)
        {
            cb_nguoidoi.Items.Clear();
            pnl_canho.Tag = macanho;
            canho ch = CanhoBLL.Instance.GetCanhoByMacanho(macanho);
            hopdong hd = HopdongBLL.Instance.GetHopdongDavao(macanho);
            List<hopdong> Listhd = HopdongBLL.Instance.GetListHopdongChuavao(macanho);
            lb_infomacanho.Text = ch.macanho.ToString();
            lb_infoloaicanho.Text = ch.loaicanho.ToString();
            if (hd == null)
            {
                lb_infonguoithue.Text = "Chưa có";
                lb_infothoigian.Text = "Trống";
                btn_huy.Enabled = false;
                btn_tieptheo.Enabled = true;
                if (Listhd.Count == 0)
                {                  
                    lb_infotrangthai.Text = "Trống";
                    lb_songuoidoi.Text = "Còn 0 chủ hộ đang đợi: ";
                }
                else
                {
                    lb_infotrangthai.Text = "Đang đợi";
                    lb_songuoidoi.Text = "Còn " + Listhd.Count + " chủ hộ đang đợi: ";
                    foreach (hopdong i in Listhd) cb_nguoidoi.Items.Add(new CBBHopdong { Value = i.mahopdong, Text = i.hogiadinh.tenchuho.ToString() });
                }
            }
            else
            {
                lb_infonguoithue.Text = hd.hogiadinh.tenchuho;
                lb_infotrangthai.Text = "Đã thuê";
                lb_infothoigian.Text = hd.thoihan + " tháng";
                lb_songuoidoi.Text = "Còn " + Listhd.Count + " chủ hộ đang đợi: ";
                foreach (hopdong i in Listhd) cb_nguoidoi.Items.Add(new CBBHopdong { Value = i.mahopdong, Text = i.hogiadinh.tenchuho.ToString() });
                btn_huy.Enabled = true;
                btn_tieptheo.Enabled = false;
            }
        }
        private void Setlistview()
        {
            lv_vatdung.Columns.Add("Vật dụng");
            lv_vatdung.Columns.Add("Số lượng");
            lv_vatdung.Columns.Add("Giá");
            lv_vatdung.Items.Add(new ListViewItem(new string[] { "Vật dụng", "Số lượng", "Giá" }));
            lv_vatdung.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_vatdung.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lv_vatdung.HeaderStyle = ColumnHeaderStyle.None;
        }
        private void SetVatdung(int macanho)
        {
            lv_vatdung.Items.Clear();
            lv_vatdung.Items.Add(new ListViewItem(new string[] { "Vật dụng", "Số lượng", "Giá" }));
            foreach (chitietcanho i in ChitietcanhoBLL.Instance.GetListVatdungByMacanho(macanho))
            {
                lv_vatdung.Items.Add(new ListViewItem(new string[] { i.vatdung, i.soluong.ToString(), i.dongia.ToString() }));
            }
        }
        private void CheckDangNhap()
        {
            double k = DateTime.Now.Subtract(this.dt).TotalMilliseconds;
            foreach (hopdong i in HopdongBLL.Instance.GetListHopdongDaVao())
            {
                if (k >= timer1.Interval * i.thoigianconlai)
                {
                    if (HopdongBLL.Instance.HuyHopdong(i.mahopdong) == true)
                    {
                        MessageBox.Show("Thời gian thuê của chủ hộ " + i.hogiadinh.tenchuho + " ở căn hộ số: " + i.macanho + " "+i.canho.khu.tenkhu + " đã hết.\nVui lòng chọn chủ hộ tiếp theo!", "Thông báo");
                        LoadCanho();
                    }
                    else
                    {
                        MessageBox.Show("Hủy hợp đồng thất bại", "Thông báo");
                    }
                }
                else
                {
                    HopdongBLL.Instance.Giamthoigian((int)(k / (timer1.Interval * i.thoigianconlai)));
                }
            }
        }
        #endregion
        #region Event
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            SetbtnColor(btn);
            btnBefore = btn;
            SetGUI(Convert.ToInt32(btn.Tag));
            SetVatdung(Convert.ToInt32(btn.Tag));
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có muốn hủy?", "Thông báo", MessageBoxButtons.OKCancel);
            if (t == DialogResult.OK)
            {
                if (HopdongBLL.Instance.HuyHopdong(HopdongBLL.Instance.GetHopdongDavao(Convert.ToInt32(pnl_canho.Tag)).mahopdong) == false)
                {
                    MessageBox.Show("Hủy thất bại", "Thông báo");
                }
                else
                {
                    LoadCanho();
                    SetGUI(Convert.ToInt32(pnl_canho.Tag));
                }
            }
        }

        private void btn_tieptheo_Click(object sender, EventArgs e)
        {
            if (cb_nguoidoi.SelectedItem == null) MessageBox.Show("Vui long chon chu ho tiep theo");
            else
            {
                DialogResult t = MessageBox.Show("Bạn muốn cho chủ hộ này cho thuê tiếp theo?", "Thông báo", MessageBoxButtons.OKCancel);
                if(t == DialogResult.OK)
                {
                    if (HopdongBLL.Instance.NhanHopDongTiepTheo(((CBBHopdong)cb_nguoidoi.SelectedItem).Value) == false)
                    {
                        MessageBox.Show("Thêm thất bại","Thông báo");
                    }
                    else
                    {
                        LoadCanho();
                        SetGUI(Convert.ToInt32(pnl_canho.Tag));
                        timer1.Enabled = true;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (HopdongBLL.Instance.GetListHopdongDaVao().Count == 0) timer1.Enabled = false;
            HopdongBLL.Instance.Giamthoigian(1);
            foreach(hopdong i in HopdongBLL.Instance.GetListHopdongDaVao())
            {
                if(i.thoigianconlai == 0)
                {
                    if(HopdongBLL.Instance.HuyHopdong(i.mahopdong) == true)
                    {
                        MessageBox.Show("Thời gian thuê của chủ hộ " + i.hogiadinh.tenchuho + " ở căn hộ số: " + i.macanho + " " + i.canho.khu.tenkhu + " đã hết.\nVui lòng chọn chủ hộ tiếp theo!", "Thông báo");
                        LoadCanho();
                    }
                    else
                    {
                        MessageBox.Show("Hủy hợp đồng thất bại","Thông báo");
                    }
                }
            }
        }

        private void Form_ChoThue_Load(object sender, EventArgs e)
        {
            CheckDangNhap();
            timer1.Enabled = true;
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadCanho();
        }
        #endregion


    }
}
