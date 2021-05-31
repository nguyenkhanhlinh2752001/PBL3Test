using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class TaikhoanBLL
    {
        private static TaikhoanBLL _Instance;
        public static TaikhoanBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new TaikhoanBLL();
                return _Instance;
            }
            private set { }
        }
        public bool Add_TK(taikhoan tk)
        {
            try
            {
                CSDL db = new CSDL();
                var query = db.taikhoans.Where(p => p.tendangnhap == tk.tendangnhap).Count();
                if (query == 0)
                {
                    db.taikhoans.Add(tk);
                    db.SaveChanges();

                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Edit_TK(taikhoan tk)
        {
            try
            {
                CSDL db = new CSDL();
                var l = (from p in db.taikhoans
                         where p.tendangnhap == tk.tendangnhap
                         select p).SingleOrDefault();
                l.tendangnhap = tk.tendangnhap;
                l.matkhau = tk.matkhau;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void Delete_TK(int manv)
        {
            CSDL db = new CSDL();
            var tk = db.taikhoans.Where(p => p.manhanvien == manv).SingleOrDefault();
            db.taikhoans.Remove(tk);
            db.SaveChanges();
        }
        public bool Login(string tentaikhoan,string matkhau)
        {
            try
            {
                CSDL db = new CSDL();
                taikhoan l = db.taikhoans.Find(tentaikhoan);
                if (l != null && l.matkhau.CompareTo(matkhau) == 0) return true;
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public taikhoan GetTaikhoan(string tentaikhoan)
        {
            try
            {
                CSDL db = new CSDL();
                taikhoan l = db.taikhoans.Find(tentaikhoan);
                return l;
            }
            catch(Exception e)
            {
                return null;
            }
        }
        public bool Doimatkhau(string tentaikhoan,string matkhau)
        {
            try
            {
                CSDL db = new CSDL();
                taikhoan l = db.taikhoans.Find(tentaikhoan);
                l.matkhau = matkhau;
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool SetTimeDangNhaplancuoi(string tentaikhoan,DateTime dt)
        {
            try
            {
                CSDL db = new CSDL();
                taikhoan l = db.taikhoans.Find(tentaikhoan);
                l.dangnhaplancuoi = dt;
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public DateTime GetTimeLanCuoi()
        {
            try
            {
                CSDL db = new CSDL();
                var l = db.taikhoans.Max(p => p.dangnhaplancuoi);
                return Convert.ToDateTime(l);
            }
            catch(Exception e)
            {
                return default(DateTime);
            }
        }
    }
}
