using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class HogiadinhBLL
    {
        private static HogiadinhBLL _Instance;
        public static HogiadinhBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new HogiadinhBLL();
                return _Instance;
            }
            private set { }
        }
        public List<hogiadinh> GetAllHogiadinh()
        {
            CSDL db = new CSDL();
            var l1 = db.hogiadinhs.Select(p => p);
            return l1.ToList();
        }
        public hogiadinh GetHoGiaDinhByid(int ID)
        {
            CSDL db = new CSDL();
            hogiadinh l1 = db.hogiadinhs.Where(p => p.maho.Equals(ID)).Select(p => p).FirstOrDefault();
            return l1;
        }
        public void Themhogiadinh(hogiadinh a)
        {
            CSDL db = new CSDL();
            db.hogiadinhs.Add(a);
            db.SaveChanges();
        }
    }
}
