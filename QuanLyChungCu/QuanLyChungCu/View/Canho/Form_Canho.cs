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
    public partial class Form_Canho : Form
    {
        public delegate void Mydel();
        public Mydel mydel { get; set; }
        public Form_Canho()
        {
            InitializeComponent();
            pnl_canho.Width = 650;
            SetGUI();
        }
        void SetdgV_Canho()
        {
            dgV_canho.Columns[0].HeaderText = "Mã căn hộ";
            dgV_canho.Columns[1].HeaderText = "Khu";
            dgV_canho.Columns[2].HeaderText = "Loại căn hộ";
        }
        void SetdgV_Vatdung()
        {
            dgV_vatdung.Columns[2].HeaderText = "Vật dụng";
            dgV_vatdung.Columns[3].HeaderText = "Số lượng";
            dgV_vatdung.Columns[4].HeaderText = "Đơn giá";
            dgV_vatdung.Columns[0].Visible = false;
            dgV_vatdung.Columns[1].Visible = false;
            dgV_vatdung.Columns[5].Visible = false;
        }
        void Show_Canho(int makhu)
        {
            dgV_canho.DataSource = CanhoInfoBLL.Instance.GetListCanhoInfoByKhu(makhu);
            SetdgV_Canho();
        }
        void Show_Vatdung(int macanho)
        {
            dgV_vatdung.DataSource = ChitietcanhoBLL.Instance.GetListVatdungByMacanho(macanho);
            SetdgV_Vatdung();
        }
        void SetCBBKhu()
        {
            cb_khu.Items.Add(new CBBKhu { Value = 0, Text = "----- All -----" });
            
            foreach(khu i in KhuBLL.Instance.GetAllKhu())
            {
                cb_khu.Items.Add(new CBBKhu { Value = i.makhu, Text = i.tenkhu });
            }
            cb_khu.SelectedIndex = 0;
        }
        void SetCBBThemvaSua()
        {
            foreach (khu i in KhuBLL.Instance.GetAllKhu())
            {
                cb_them.Items.Add(new CBBKhu { Value = i.makhu, Text = i.tenkhu });
            }
            foreach (khu i in KhuBLL.Instance.GetAllKhu())
            {
                cb_sua.Items.Add(new CBBKhu { Value = i.makhu, Text = i.tenkhu });
            }
        }
        void SetCBBTxtSua(int makhu)
        {
            foreach (khu i in KhuBLL.Instance.GetAllKhu())
            {
                if (i.makhu == makhu) 
                {
                    cb_sua.Text = i.tenkhu;
                    break;
                }
            }
        }
        void SetGUI()
        {
            SetCBBKhu();
            SetCBBThemvaSua();
            canho ch = CanhoBLL.Instance.GetCanhoByMacanho(Convert.ToInt32(dgV_canho.Rows[0].Cells[0].Value));
            SetCBBTxtSua(ch.khu.makhu);
            txt_sua.Text = ch.loaicanho;
            Show_Canho(0);
            Show_Vatdung(Convert.ToInt32(dgV_canho.Rows[0].Cells[0].Value));
            if (dgV_vatdung.Rows.Count > 0)
            {
                txt_suavatdung.Text = dgV_vatdung.Rows[0].Cells[2].Value.ToString();
                txt_suadongia.Text = dgV_vatdung.Rows[0].Cells[4].Value.ToString();
                nUP_suasoluong.Value = Convert.ToInt32(dgV_vatdung.Rows[0].Cells[3].Value);
            }
            else
            {
                txt_suavatdung.Text = "";
                txt_suadongia.Text = "";
                nUP_suasoluong.Value = 0;
            }
        }

        private void cb_khu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Canho(((CBBKhu)cb_khu.SelectedItem).Value);
        }

        private void dgV_canho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            canho ch = CanhoBLL.Instance.GetCanhoByMacanho(Convert.ToInt32(dgV_canho.SelectedRows[0].Cells[0].Value));
            SetCBBTxtSua(ch.khu.makhu);
            txt_sua.Text = ch.loaicanho;

            Show_Vatdung(Convert.ToInt32(dgV_canho.SelectedRows[0].Cells[0].Value));
            if(dgV_vatdung.Rows.Count > 0)
            {
                txt_suavatdung.Text = dgV_vatdung.Rows[0].Cells[2].Value.ToString();
                txt_suadongia.Text = dgV_vatdung.Rows[0].Cells[4].Value.ToString();
                nUP_suasoluong.Value = Convert.ToInt32(dgV_vatdung.Rows[0].Cells[3].Value);
            }
            else
            {
                txt_suavatdung.Text = "";
                txt_suadongia.Text = "";
                nUP_suasoluong.Value = 0;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(cb_them.SelectedItem == null || txt_them.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
            }
            else
            {
                canho ch = new canho
                {
                    macanho = CanhoBLL.Instance.GetMaxMacanho() + 1,
                    makhu = ((CBBKhu)cb_them.SelectedItem).Value,
                    loaicanho = txt_them.Text,
                    maho = null,
                };
                if(CanhoBLL.Instance.Themcanho(ch) == false)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                    return;
                }
                Show_Canho(0);
                mydel();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có muốn xóa?", "Thông báo",MessageBoxButtons.OKCancel);
            if(t == DialogResult.OK)
            {
                for(int i= 0; i < dgV_canho.SelectedRows.Count; i++)
                {
                    if (CanhoBLL.Instance.Xoacanho(Convert.ToInt32(dgV_canho.SelectedRows[i].Cells[0].Value)) == false)
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo");
                        return;
                    }
                }
                Show_Canho(0);
                mydel();
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(dgV_canho.SelectedRows.Count != 1)
            {
                MessageBox.Show("Vui lòng chỉ chọn 1 căn hộ", "Cảnh báo");
            }
            else
            {
                if(cb_sua.Enabled == false)
                {
                    DialogResult t = MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.OKCancel);
                    if (t == DialogResult.OK)
                    {
                        cb_sua.Enabled = true;
                        txt_sua.ReadOnly = false;
                        btn_xoa.Enabled = false;
                        btn_them.Enabled = false;
                        dgV_canho.Enabled = false;
                        txt_sua.Focus();
                    }
                }
                else
                {
                    if(txt_sua.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Cảnh báo");
                    }
                    else
                    {
                        canho ch = new canho
                        {
                            macanho = Convert.ToInt32(dgV_canho.SelectedRows[0].Cells[0].Value),
                            makhu = ((CBBKhu)cb_sua.SelectedItem).Value,
                            loaicanho = txt_sua.Text,
                        };
                        if (CanhoBLL.Instance.Suacanho(ch) == false)
                        {
                            MessageBox.Show("Sửa thất bại", "Thông báo");
                            return;
                        }
                        cb_sua.Enabled = false;
                        txt_sua.ReadOnly = true;
                        btn_xoa.Enabled = true;
                        btn_them.Enabled = true;
                        dgV_canho.Enabled = true;
                        Show_Canho(0);
                        mydel();
                    }
                }
                
            }

        }

        private void btn_themvatdung_Click(object sender, EventArgs e)
        {
            if(txt_themvatdung.Text=="" || txt_themdongia.Text == "" || Convert.ToInt32(nUP_themsoluong.Value) == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
            }
            else
            {
                double dg;
                try
                {
                     dg = Convert.ToDouble(txt_themdongia.Text);
                }
                catch(Exception s)
                {
                    MessageBox.Show("Đơn giá không hợp lệ", "Cảnh báo");
                    return;
                }
                chitietcanho ctch = new chitietcanho
                {
                    mavatdung = ChitietcanhoBLL.Instance.GetMaxMavatdung() + 1,
                    macanho = Convert.ToInt32(dgV_canho.SelectedRows[0].Cells[0].Value),
                    vatdung = txt_themvatdung.Text,
                    soluong = Convert.ToInt32(nUP_themsoluong.Value),
                    dongia = dg
                };
                if (ChitietcanhoBLL.Instance.ThemVatdung(ctch) == false)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                    return;
                }
                Show_Vatdung(Convert.ToInt32(dgV_canho.SelectedRows[0].Cells[0].Value));
                mydel();
            }
        }

        private void btn_xoavatdung_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
            if (t == DialogResult.OK)
            {
                for (int i = 0; i < dgV_vatdung.SelectedRows.Count; i++)
                {
                    if (ChitietcanhoBLL.Instance.Xoavatdung(Convert.ToInt32(dgV_vatdung.SelectedRows[i].Cells[0].Value)) == false)
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo");
                        return;
                    }
                }
                Show_Vatdung(Convert.ToInt32(dgV_canho.SelectedRows[0].Cells[0].Value));
                mydel();
            }
        }

        private void btn_suavatdung_Click(object sender, EventArgs e)
        {
            if (dgV_vatdung.SelectedRows.Count != 1)
            {
                MessageBox.Show("Vui lòng chỉ chọn 1 vật dụng", "Cảnh báo");
            }
            else
            {
                if (txt_suavatdung.ReadOnly == true)
                {
                    DialogResult t = MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.OKCancel);
                    if (t == DialogResult.OK)
                    {
                        dgV_vatdung.Enabled = false;
                        btn_themvatdung.Enabled = false;
                        btn_xoavatdung.Enabled = false;
                        btn_xoa.Enabled = false;
                        btn_them.Enabled = false;
                        dgV_canho.Enabled = false;
                        txt_suavatdung.ReadOnly = false;
                        txt_suadongia.ReadOnly = false;
                        nUP_suasoluong.Enabled = true;
                        txt_suavatdung.Focus();
                    }
                }
                else
                {
                    if (txt_suadongia.Text == "" || txt_suavatdung.Text == "" || Convert.ToInt32(nUP_suasoluong.Value) == 0)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                    }
                    else
                    {
                        double dg;
                        try
                        {
                            dg = Convert.ToDouble(txt_suadongia.Text);
                        }
                        catch (Exception s)
                        {
                            MessageBox.Show("Đơn giá không hợp lệ", "Cảnh báo");
                            return;
                        }
                        chitietcanho ctch = new chitietcanho
                        {
                            mavatdung = Convert.ToInt32(dgV_vatdung.SelectedRows[0].Cells[0].Value),
                            macanho = Convert.ToInt32(dgV_vatdung.SelectedRows[0].Cells[1].Value),
                            vatdung = txt_suavatdung.Text,
                            soluong = Convert.ToInt32(nUP_suasoluong.Value),
                            dongia = dg,
                        };
                        if (ChitietcanhoBLL.Instance.SuaVatdung(ctch) == false)
                        {
                            MessageBox.Show("Sửa thất bại", "Thông báo");
                            return;
                        }
                        dgV_vatdung.Enabled = true;
                        btn_themvatdung.Enabled = true;
                        btn_xoavatdung.Enabled = true;
                        btn_xoa.Enabled = true;
                        btn_them.Enabled = true;
                        dgV_canho.Enabled = true;
                        txt_suavatdung.ReadOnly = true;
                        txt_suadongia.ReadOnly = true;
                        nUP_suasoluong.Enabled = false;
                        Show_Vatdung(Convert.ToInt32(dgV_canho.SelectedRows[0].Cells[0].Value));
                        mydel();
                    }
                }
            }
        }

        private void dgV_vatdung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_suavatdung.Text = dgV_vatdung.SelectedRows[0].Cells[2].Value.ToString();
            txt_suadongia.Text = dgV_vatdung.SelectedRows[0].Cells[4].Value.ToString();
            nUP_suasoluong.Value = Convert.ToInt32(dgV_vatdung.SelectedRows[0].Cells[3].Value);
        }
    }
}
