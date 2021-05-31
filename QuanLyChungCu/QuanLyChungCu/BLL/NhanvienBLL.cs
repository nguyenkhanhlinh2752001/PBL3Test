using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.BLL
{
    class NhanvienBLL
    {
        private static NhanvienBLL _Instance;
        public static NhanvienBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new NhanvienBLL();
                return _Instance;
            }
            private set { }
        }
        public List<nhanvien> GetALLNhanVien()
        {
            CSDL db = new CSDL();
            var l1 = db.nhanviens.Select(p => p);
            return l1.ToList();
        }
        public IEnumerable<object> LayDSNV()
        {
            CSDL db = new CSDL();
            var l1 = from nv in db.nhanviens
                     join tk in db.taikhoans
                     on nv.manhanvien equals tk.manhanvien
                     select new
                     {
                         nv.manhanvien,
                         nv.tennhanvien,
                         nv.gioitinh,
                         nv.sdt,
                         nv.ngaysinh,
                         nv.cmnd,
                         nv.chucvu.tenchucvu,
                         tk.tendangnhap,
                         tk.matkhau
                     };
            return l1.ToList();
        }
        public bool Add_NV(nhanvien nv)
        {
            try
            {
                CSDL db = new CSDL();
                db.Entry(nv).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Edit_NV(nhanvien nv)
        {
            try
            {
                CSDL db = new CSDL();
                var query = (from p in db.nhanviens
                             where p.manhanvien == nv.manhanvien
                             select p).SingleOrDefault();
                query.manhanvien = nv.manhanvien;
                query.tennhanvien = nv.tennhanvien;
                query.ngaysinh = nv.ngaysinh;
                query.gioitinh = nv.gioitinh;
                query.sdt = nv.sdt;
                query.cmnd = nv.cmnd;
                query.machucvu = nv.machucvu;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void Delete_NV(int manv)
        {
            CSDL db = new CSDL();
            var nv = db.nhanviens.Where(p => p.manhanvien == manv).SingleOrDefault();
            db.nhanviens.Remove(nv);
            db.SaveChanges();
        }
        public IEnumerable<object> GetListNVByTen(string tennv)
        {
            CSDL db = new CSDL();
            var l = from nv in db.nhanviens
                    join tk in db.taikhoans
                    on nv.manhanvien equals tk.manhanvien
                    where nv.tennhanvien.ToLower().Contains(tennv.ToLower())
                    select new
                    {
                        nv.manhanvien,
                        nv.tennhanvien,
                        nv.gioitinh,
                        nv.sdt,
                        nv.ngaysinh,
                        nv.cmnd,
                        nv.chucvu.tenchucvu,
                        tk.tendangnhap,
                        tk.matkhau
                    };
            return l.ToList();
        }
        public nhanvien LayThongTin1NhanVien(int maNV)
        {
            CSDL db = new CSDL();
            var query = db.nhanviens.Where(p => p.manhanvien == maNV).SingleOrDefault();
            return query;
        }
        public bool SuaThongtinNhanvien(nhanvien nv)
        {
            try
            {
                CSDL db = new CSDL();
                nhanvien l = db.nhanviens.Find(nv.manhanvien);
                l.tennhanvien = nv.tennhanvien;
                l.sdt = nv.sdt;
                l.cmnd = nv.cmnd;
                l.gioitinh = nv.gioitinh;
                l.ngaysinh = nv.ngaysinh;
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
