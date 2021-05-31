using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class HoadonBLL
    {
        private static HoadonBLL _Instance;
        public static HoadonBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new HoadonBLL();
                return _Instance;
            }
            private set { }
        }
        public IEnumerable<object> HienThiDanhSachHoaDon()
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }

        public int TongSoHoaDon()
        {
            CSDL db = new CSDL();
            var query = (from p in db.hoadondichvus select p.mahoadon).Count();
            return query;
        }


        public IEnumerable<Object> DanhSachHoaDonVaoNgay(DateTime VaoNgay)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where p.ngaylap == VaoNgay
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonNgayDenNgay(DateTime TuNgay, DateTime DenNgay)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where (p.ngaylap <= DenNgay && p.ngaylap >= TuNgay)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }

        public IEnumerable<Object> DanhSachHoaDonTheoMaCH(int mach)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where p.macanho == mach
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonTheoMaCHVaoNgay(DateTime VaoNgay, int mach)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where p.ngaylap == VaoNgay && p.macanho == mach
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonTheoMaCHNgayDenNgay(DateTime TuNgay, DateTime DenNgay, int mach)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where (p.ngaylap <= DenNgay && p.ngaylap >= TuNgay) && p.macanho == mach
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }


        public IEnumerable<Object> DanhSachHoaDonTheoTenNV(string ten)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where p.nhanvien.tennhanvien.Contains(ten)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonTheoTenNVVaoNgay(DateTime VaoNgay, string ten)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where p.ngaylap == VaoNgay && p.nhanvien.tennhanvien.Contains(ten)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonTheoTenNVNgayDenNgay(DateTime TuNgay, DateTime DenNgay, string ten)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where (p.ngaylap <= DenNgay && p.ngaylap >= TuNgay) && p.nhanvien.tennhanvien.Contains(ten)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }

        public IEnumerable<Object> DanhSachHoaDonTheoThanhToan(Boolean check)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where p.dathanhtoan.Equals(check)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonTheoThanhToanVaoNgay(DateTime VaoNgay, Boolean check)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where p.ngaylap == VaoNgay && p.dathanhtoan.Equals(check)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> DanhSachHoaDonTheoThanhToanNgayDenNgay(DateTime TuNgay, DateTime DenNgay, Boolean check)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where (p.ngaylap <= DenNgay && p.ngaylap >= TuNgay) && p.dathanhtoan.Equals(check)
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }

        public IEnumerable<Object> HoaDonTheoMaHD(int mahd)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where p.mahoadon == mahd
                        orderby p.ngaylap
                        select new
                        {
                            p.mahoadon,
                            p.canho.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }

        public string LayMaCanHoTuMaHoaDon(int mahd)
        {
            CSDL db = new CSDL();
            var query = (from p in db.hoadondichvus
                         where p.mahoadon == mahd
                         select p.macanho).SingleOrDefault().ToString();
            return query;
        }


        public string LayMaNhanVienTuMaHoaDon(int mahd)
        {
            CSDL db = new CSDL();
            var query = (from p in db.hoadondichvus
                         where p.mahoadon == mahd
                         select p.manhanvien).SingleOrDefault().ToString();
            return query;
        }

        public hoadondichvu LayThongTin1HoaDon(int maHD)
        {
            CSDL db = new CSDL();
            var query = db.hoadondichvus.Where(p => p.mahoadon == maHD).SingleOrDefault();
            return query;
        }

        public IEnumerable<Object> HienThiDanhSachDichVuDaSuDung(int maHD)
        {
            CSDL db = new CSDL();
            var query = from p in db.chitiethoadons
                        where p.mahoadon == maHD
                        select new
                        {
                            //p.madichvu,
                            p.dichvu.tendichvu,
                            p.dichvu.gia,
                            p.soluong,
                            thanhtien = p.soluong * p.dichvu.gia
                        };
            return query.ToList();
        }

        public int LayMaHDLonNhat()
        {
            CSDL db = new CSDL();
            var query = (from p in db.hoadondichvus select p.mahoadon);
            List<int> maHD = new List<int>();
            foreach (int i in query)
            {
                maHD.Add(i);
            }
            if (maHD.Count == 0) return 0;
            return maHD.Max();

        }

        public IEnumerable<object> HienThiDSDichVuDaChon(int mahd)
        {
            CSDL db = new CSDL();
            var query = from p in db.chitiethoadons
                        where p.mahoadon == mahd
                        select new
                        {
                            p.madichvu,
                            p.dichvu.tendichvu,
                            p.soluong,
                            p.dichvu.gia,
                            thanhtien = p.soluong * p.dichvu.gia,

                        };
            return query.ToList();
        }

        public bool ThemDichVuVaoHD(chitiethoadon cthd)
        {
            CSDL db = new CSDL();
            var query = db.chitiethoadons.Where(p => p.mahoadon == cthd.mahoadon && p.madichvu == cthd.madichvu).Count();
            if (query == 0)
            {
                db.chitiethoadons.Add(cthd);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public void XoaDichVuKhoiHD(int mahd, int madv)
        {
            CSDL db = new CSDL();
            var query = db.chitiethoadons.Where(p => p.mahoadon.Equals(mahd) && p.madichvu.Equals(madv)).SingleOrDefault();
            db.chitiethoadons.Remove(query);
            db.SaveChanges();
        }

        public bool ThemHoaDonDV(hoadondichvu hd)
        {
            CSDL db = new CSDL();
            var query = db.hoadondichvus.Where(p => p.mahoadon == hd.mahoadon).Count();
            if (query == 0)
            {
                db.hoadondichvus.Add(hd);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool SuaHoaDonDV(hoadondichvu hd)
        {
            try
            {
                CSDL db = new CSDL();
                var query = (from p in db.hoadondichvus
                             where p.mahoadon == hd.mahoadon
                             select p).SingleOrDefault();
                query.mahoadon = hd.mahoadon;
                query.macanho = hd.macanho;
                query.manhanvien = hd.manhanvien;
                query.tongtien = hd.tongtien;
                query.ngaylap = hd.ngaylap;
                query.dathanhtoan = hd.dathanhtoan;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool KiemTraCanHoTonTai(int maCH)
        {
            CSDL db = new CSDL();
            var query = (from p in db.canhoes where p.macanho.Equals(maCH) select p).Any();
            if (query == true) return true;
            else return false;

        }

        public IEnumerable<Object> TimKiemHDTheoTenNV(string ten)
        {
            CSDL db = new CSDL();
            var query = from p in db.hoadondichvus
                        where p.nhanvien.tennhanvien.Contains(ten)
                        select new
                        {
                            p.mahoadon,
                            p.macanho,
                            p.nhanvien.tennhanvien,
                            p.tongtien,
                            p.dathanhtoan,
                            p.ngaylap,
                        };
            return query.ToList();
        }

    }
}
