using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_ChiTietHoaDon
{
    public class ChiTietHoaDonRepotories : IChiTietHoaDonReporitories
    {
        QuanLiNhaHangEntities _db;

        public ChiTietHoaDonRepotories()
        {
            _db = new QuanLiNhaHangEntities();
        }

        public bool CheckTrung(string MaH,string MaHD)
        {
            var cthd = _db.HoaDonChiTiets.FirstOrDefault(c => c.MaH == MaH && c.MaHoaDon == MaHD);
            if (cthd == null) return true;
            return false;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _db.HoaDonChiTiets.ToList();
        }

        public decimal GetGiaSP(string MaH)
        {
            var gia = _db.Hangs.Where(c => c.Ma == MaH).Select(c => c.GiaBan).FirstOrDefault();
            return gia;
        }

        public bool TangSoLuong(string MaH,string MaHD)
        {
            var cthd = _db.HoaDonChiTiets.FirstOrDefault(c => c.MaH == MaH && c.MaHoaDon == MaHD);
            var hang = _db.Hangs.FirstOrDefault(c => c.Ma == MaH);
            hang.SoLuong--;
            cthd.SoLuong++;
            cthd.TongTien = (cthd.SoLuong * GetGiaSP(MaH));
            _db.SaveChanges();
            return true;
        }

        public bool GiamSoLuong(string MaH, string MaHD)
        {
            var cthd = _db.HoaDonChiTiets.FirstOrDefault(c => c.MaH == MaH && c.MaHoaDon == MaHD);
            var hang = _db.Hangs.FirstOrDefault(c => c.Ma == MaH);
            hang.SoLuong++;
            cthd.SoLuong--;
            cthd.TongTien = (cthd.SoLuong * GetGiaSP(MaH));
            _db.SaveChanges();
            return true;
        }

        public bool ThemHoaDonChiTiet(HoaDonChiTiet hdct)
        {
            if (hdct == null) return false;
            var hang = _db.Hangs.FirstOrDefault(c => c.Ma == hdct.MaH);
            hang.SoLuong--;
            _db.HoaDonChiTiets.Add(hdct);
            _db.SaveChanges();
            return true;
        }

        public List<DTO_HoaDonChiTiet> ViewData(string ma)
        {
            var list = (from a in _db.HoaDonChiTiets
                       join b in _db.HoaDons on a.MaHoaDon equals b.Ma
                       join c in _db.Hangs on a.MaH equals c.Ma
                       where a.MaHoaDon == ma
                       select new DTO_HoaDonChiTiet()
                       {
                           TenHang = c.Ten,
                           GiaBan = c.GiaBan,
                           SoLuong = a.SoLuong,
                           TongThanhTien = a.TongTien,
                       }).ToList();

            return list;
        }

        public bool Xoa(string mh, string mhd)
        {
            var cthd = _db.HoaDonChiTiets.FirstOrDefault(c => c.MaH == mh && c.MaHoaDon == mhd);
            if (cthd == null) return false;
            _db.HoaDonChiTiets.Remove(cthd);
            _db.SaveChanges();
            return true;
        }
    }
}
