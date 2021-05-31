using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class KhuBLL
    {
        private static KhuBLL _Instance;
        public static KhuBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new KhuBLL();
                return _Instance;
            }
            private set { }
        }
        public List<khu> GetAllKhu()
        {
            CSDL db = new CSDL();
            var l1 = db.khus.Select(p => p);
            return l1.ToList();
        }
    }
}

