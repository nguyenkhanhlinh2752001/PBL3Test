using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class CanhoBLL
    {
        private static CanhoBLL _Instance;
        public static CanhoBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CanhoBLL();
                return _Instance;
            }
            private set { }
        }
        public List<canho> GetAllCanho()
        {
            CSDL db = new CSDL();
            var l1 = db.canhoes.Select(p => p);
            return l1.ToList();
        }
        public List<canho> GetListCanhoByKhu(int makhu)
        {
            CSDL db = new CSDL();
            var l2 = db.canhoes.Where(p => p.makhu == makhu);
            return l2.ToList();
        }
        public canho GetCanhoByMacanho(int macanho)
        {
            CSDL db = new CSDL();
            canho l1 = db.canhoes.Where(p => p.macanho == macanho).FirstOrDefault();
            return l1;
        }
        public int GetMaxMacanho()
        {
            CSDL db = new CSDL();
            var l1 = db.canhoes.Max(p => p.macanho);
            return Convert.ToInt32(l1);
        }
        public bool Themcanho(canho ch)
        {
            try
            {
                CSDL db = new CSDL();
                db.canhoes.Add(ch);
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool Xoacanho(int macanho)
        {
            try
            {
                CSDL db = new CSDL();
                db.canhoes.Remove(db.canhoes.Find(macanho));
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Suacanho(canho ch)
        {
            try
            {
                CSDL db = new CSDL();
                canho l =  db.canhoes.Find(ch.macanho);
                l.makhu = ch.makhu;
                l.loaicanho = ch.loaicanho;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public canho LayThongTin1CanHo(int maCH)
        {
            CSDL db = new CSDL();
            var query = db.canhoes.Where(p => p.macanho == maCH).SingleOrDefault();
            return query;
        }
    }
}
