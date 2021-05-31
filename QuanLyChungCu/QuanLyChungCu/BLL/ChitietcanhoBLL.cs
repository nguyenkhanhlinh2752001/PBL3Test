using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class ChitietcanhoBLL
    {
        private static ChitietcanhoBLL _Instance;
        public static ChitietcanhoBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new ChitietcanhoBLL();
                return _Instance;
            }
            private set { }
        }
        public List<chitietcanho> GetListVatdungByMacanho(int macanho)
        {
            CSDL db = new CSDL();
            var l1 = db.chitietcanhoes.Where(p => p.macanho == macanho);
            return l1.ToList();
        }
        public int GetMaxMavatdung()
        {
            try
            {
                CSDL db = new CSDL();
                var l1 = db.chitietcanhoes.Max(p => p.mavatdung);
                return Convert.ToInt32(l1);
            }
            catch(Exception e)
            {
                return 0;
            }
        }
        public bool ThemVatdung(chitietcanho ctch)
        {
            try
            {
                CSDL db = new CSDL();
                chitietcanho l1 = db.chitietcanhoes.Where(p => p.macanho == ctch.macanho && p.vatdung == ctch.vatdung).FirstOrDefault();
                if (l1 == null)
                {
                    db.chitietcanhoes.Add(ctch);
                }
                else
                {
                    l1.soluong += ctch.soluong;
                    l1.dongia += ctch.dongia;  
                }
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool Xoavatdung(int mavatdung)
        {
            try
            {
                CSDL db = new CSDL();
                chitietcanho l1 = db.chitietcanhoes.Find(mavatdung);
                if (l1.soluong > 1)
                {
                    l1.soluong--;
                    l1.dongia -= l1.dongia / 2;
                }
                else db.chitietcanhoes.Remove(l1);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool SuaVatdung(chitietcanho ctch)
        {
            try
            {
                CSDL db = new CSDL();
                chitietcanho l1 = db.chitietcanhoes.Find(ctch.mavatdung);
                l1.vatdung = ctch.vatdung;
                l1.soluong = ctch.soluong;
                l1.dongia = ctch.dongia;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
