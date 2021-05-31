using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class DichvuBLL
    {
        private static DichvuBLL _Instance;
        public static DichvuBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DichvuBLL();
                return _Instance;
            }
            private set { }
        }
        public IEnumerable<object> HienThiDanhSachDichVu()
        {
            CSDL db = new CSDL();
            var query = from p in db.dichvus
                        select new
                        {
                            p.madichvu,
                            p.tendichvu,
                            p.gia,
                        };
            return query.ToList();
        }

        public int LayMaDichVuLonNhat()
        {
            CSDL db = new CSDL();
            var query = (from p in db.dichvus select p.madichvu);
            List<int> madv = new List<int>();
            foreach (int i in query)
            {
                madv.Add(i);
            }
            if (madv.Count == 0) return 0;
            return madv.Max();
        }
        public bool ThemDichVu(dichvu dv)
        {
            CSDL db = new CSDL();
            var query = db.dichvus.Where(p => p.madichvu == dv.madichvu).Count();
            if (query == 0)
            {
                db.dichvus.Add(dv);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool SuaDichVu(dichvu dv)
        {
            try
            {
                CSDL db = new CSDL();
                var query = (from p in db.dichvus
                             where p.madichvu == dv.madichvu
                             select p).SingleOrDefault();
                query.madichvu = dv.madichvu;
                query.tendichvu = dv.tendichvu;
                query.gia = dv.gia;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public void XoaDichVu(List<int> maList)
        {
            CSDL db = new CSDL();
            foreach (int i in maList)
            {
                var query = db.dichvus.Where(p => p.madichvu.Equals(i)).SingleOrDefault();
                db.dichvus.Remove(query);
                db.SaveChanges();
            }
        }

        public dichvu LayThongTin1DichVu(int madv)
        {
            CSDL db = new CSDL();
            dichvu query = db.dichvus.Where(p => p.madichvu == madv).SingleOrDefault();
            return query;
        }
    }
}
