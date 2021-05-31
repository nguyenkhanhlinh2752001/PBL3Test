using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class HopdongBLL
    {
        private static HopdongBLL _Instance;
        public static HopdongBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new HopdongBLL();
                return _Instance;
            }
            private set { }
        }
        public List<hopdong> GetListHopdongByMacanho(int macanho)
        {
            CSDL db = new CSDL();
            var l1 = db.hopdongs.Where(p => p.macanho == macanho);
            return l1.ToList();
        }
        public List<hopdong> GetListHopdongChuavao(int macanho)
        {
            List<hopdong> l1 = new List<hopdong>();
            foreach(hopdong i in GetListHopdongByMacanho(macanho))
            {
                if(i.dahuy == false && i.davao == false)
                {
                    l1.Add(i);
                }
            }
            return l1;
        }
        public List<hopdong> GetListHopdongDaVao()
        {
            CSDL db = new CSDL();
            var l1 = db.hopdongs.Where(p => p.dahuy == false && p.davao == true);
            return l1.ToList();
        }
        public hopdong GetHopdongDavao(int macanho)
        {
            CSDL db = new CSDL();
            hopdong l1 = db.hopdongs.Where(p => p.macanho == macanho && p.dahuy == false && p.davao == true).FirstOrDefault();
            return l1;
        }
        public bool HuyHopdong(int mahopdong)
        {
            try
            {
                CSDL db = new CSDL();
                hopdong l1 = db.hopdongs.Where(p => p.mahopdong == mahopdong).FirstOrDefault();
                l1.dahuy = true;
                l1.canho.maho = null;
                l1.thoigianconlai = 0;
                db.SaveChanges();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public bool NhanHopDongTiepTheo(int mahopdong)
        {
            try
            {
                CSDL db = new CSDL();
                hopdong l1 = db.hopdongs.Where(p => p.mahopdong == mahopdong).FirstOrDefault();
                l1.canho.maho = l1.maho;
                l1.davao = true;
                l1.thoigianconlai = l1.thoihan;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public void Giamthoigian(int tg)
        {
            CSDL db = new CSDL();
            var l1 = db.hopdongs.Where(p => p.dahuy == false && p.davao == true);
            foreach(hopdong i in l1)
            {
                i.thoigianconlai -= tg;
            }
            db.SaveChanges();
        }
        public List<hopdong> GetAllHD()
        {
            CSDL db = new CSDL();
            var l1 = db.hopdongs.Select(p => p);
            return l1.ToList();
        }
        public void AddorUpdate(hopdong a)
        {
            CSDL db = new CSDL();
            if (db.hopdongs.Where(p => p.mahopdong.Equals(a.mahopdong)).Select(p => p).FirstOrDefault() != null)
            {
                var l1 = db.hopdongs.Where(p => p.mahopdong.Equals(a.mahopdong)).Select(p => p).FirstOrDefault();
                l1.mahopdong = a.mahopdong;
                l1.maho = a.maho;
                l1.macanho = a.macanho;
                l1.giatien = a.giatien;
                l1.thoihan = a.thoihan;
                l1.manhanvien = a.manhanvien;
                l1.ngayki = a.ngayki;
                l1.dahuy = a.dahuy;
                l1.tenhopdong = a.tenhopdong;
                db.SaveChanges();
            }
            else
            {
                db.hopdongs.Add(a);
                db.SaveChanges();
            }
        }
        public Array GetALLHDViews()
        {
            CSDL db = new CSDL();
            var l1 = db.hopdongs.Select(p => new { p.mahopdong, p.nhanvien.tennhanvien, p.macanho, p.hogiadinh.tenchuho, p.tenhopdong, p.giatien, p.thoihan, p.ngayki, p.dahuy });
            return l1.ToArray();
        }
        public Array GetHDbyIDViews(int id)
        {
            CSDL db = new CSDL();
            var l1 = db.hopdongs.Where(p => p.mahopdong.Equals(id) == true).Select(p => new { p.mahopdong, p.nhanvien.tennhanvien, p.macanho, p.hogiadinh.tenchuho, p.tenhopdong, p.giatien, p.thoihan, p.ngayki, p.dahuy });
            return l1.ToArray();
        }
        public Array GetHDByNameViews(string name)
        {
            CSDL db = new CSDL();
            var l1 = db.hopdongs.Where(p => p.tenhopdong.Contains(name)).Select(p => new { p.mahopdong, p.nhanvien.tennhanvien, p.macanho, p.hogiadinh.tenchuho, p.tenhopdong, p.giatien, p.thoihan, p.ngayki, p.dahuy });
            return l1.ToArray();
        }
        public Array GetHDViewsByTime(DateTime a, DateTime b)
        {
            CSDL db = new CSDL();
            var l1 = db.hopdongs.Where(p => (p.ngayki <=b  && p.ngayki >= a)).Select(p => new { p.mahopdong, p.nhanvien.tennhanvien, p.macanho, p.hogiadinh.tenchuho, p.tenhopdong, p.giatien, p.thoihan, p.ngayki, p.dahuy });
            return l1.ToArray();
        }
        public hopdong GetHDdetail(int id)
        {
            CSDL db = new CSDL();
            hopdong l1 = db.hopdongs.Find(id);
            return l1;
        }
        public void Delete(int MAHD)
        {
            CSDL db = new CSDL();
            hopdong l1 = db.hopdongs.Where(p => p.mahopdong.Equals(MAHD)).Select(p => p).FirstOrDefault();
            db.hopdongs.Remove(l1);
            db.SaveChanges();
        }
    }
}
