using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class CanhoInfoBLL
    {
        private static CanhoInfoBLL _Instance;
        public static CanhoInfoBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CanhoInfoBLL();
                return _Instance;
            }
            private set { }
        }
        public List<CanhoInfo> GetAllCanhoInfo()
        {
            List<CanhoInfo> list = new List<CanhoInfo>();
            foreach(canho i in CanhoBLL.Instance.GetAllCanho())
            {
                list.Add(new CanhoInfo
                {
                    macanho = i.macanho,
                    tenkhu = i.khu.tenkhu,
                    loaicanho = i.loaicanho
                });
            }
            return list;
        }
        public List<CanhoInfo> GetListCanhoInfoByKhu(int makhu)
        {
            List<CanhoInfo> list = new List<CanhoInfo>();
            if(makhu == 0)
            {
                return GetAllCanhoInfo();
            }
            else
            {
                foreach (canho i in CanhoBLL.Instance.GetListCanhoByKhu(makhu))
                {
                    list.Add(new CanhoInfo
                    {
                        macanho = i.macanho,
                        tenkhu = i.khu.tenkhu,
                        loaicanho = i.loaicanho
                    });
                }
            }
            return list;
        }
    }
}
