using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_SanPham
{
    public class SanPhamReporitories : ISanPhamReporitories
    {
        QuanLiNhaHangEntities _db;

        public SanPhamReporitories()
        {
            _db = new QuanLiNhaHangEntities();
        }

        public List<Hang> GetAll()
        {
            return _db.Hangs.ToList();
        }

        public bool Sua(Hang sp)
        {
            if (sp == null) return false;
            var item = _db.Hangs.FirstOrDefault(c => c.Ma == sp.Ma);
            item.Ten = sp.Ten;
            item.Anh = sp.Anh;
            item.GiaNhap = sp.GiaNhap;
            item.GiaBan = sp.GiaBan;
            item.SoLuong = sp.SoLuong;
            item.MaNsx = sp.MaNsx;
            item.MaLH = sp.MaLH;
            _db.SaveChanges();
            return true;
        }

        public bool Them(Hang sp)
        {
            if (sp == null) return false;
            _db.Hangs.Add(sp);
            _db.SaveChanges();
            return true;
        }

        public bool updateSoLuong(string ma, int soluong)
        {
            var sp = _db.Hangs.FirstOrDefault(c => c.Ma == ma);
            if (sp == null) return false;
            sp.SoLuong += soluong;
            _db.SaveChanges();
            return true;
        }

        public List<DTO_SanPham> ViewData()
        {
            var result = (from a in _db.Hangs
                         join b in _db.Nsxes on a.MaNsx equals b.Ma
                         join c in _db.LoaiHangs on a.MaLH equals c.Ma
                         select new DTO_SanPham()
                         {
                             Ma = a.Ma,
                             Ten = a.Ten,
                             Anh = a.Anh,
                             GiaNhap = a.GiaNhap,
                             GiaBan = a.GiaBan,
                             SoLuong = a.SoLuong,
                             Nsx = b.Ten,
                             LoaiHang = c.Ten,
                         }).ToList();
            return result;

        }

        public bool Xoa(string ma)
        {
            var sp = _db.Hangs.FirstOrDefault(c => c.Ma == ma);
            if (sp == null) return false;
            _db.Hangs.Remove(sp);
            _db.SaveChanges();
            return true;
        }
    }
}
