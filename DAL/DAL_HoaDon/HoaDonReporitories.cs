using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_HoaDon
{
    public class HoaDonReporitories : IHoaDonReporitories
    {
        QuanLiNhaHangEntities _db;

        public HoaDonReporitories()
        {
            _db = new QuanLiNhaHangEntities();
        }

        public List<HoaDon> GetAll()
        {
            return _db.HoaDons.ToList();
        }

        public decimal GetThanhTien(string ma)
        {
            var thanhtien = _db.HoaDons.Where(c => c.Ma == ma).Select(c => c.thanhTien).FirstOrDefault();
            return (decimal)thanhtien;
        }

        public bool ThanhToan(string ma)
        {
            var hd = _db.HoaDons.FirstOrDefault(c => c.Ma == ma);
            hd.trangThai = 1;
            _db.SaveChanges();
            return true;
        }

        public bool them(HoaDon hd)
        {
            if (hd == null) return false;
            _db.HoaDons.Add(hd);
            _db.SaveChanges();
            return true;
        }

        public bool UpdateThanhTien(string ma, decimal thanhtien)
        {
            var hd = _db.HoaDons.FirstOrDefault(c => c.Ma == ma);
            hd.thanhTien = thanhtien;
            _db.SaveChanges();
            return true;
        }

        public List<ThongKeDTO> ViewDataThongKe()
        {
            var lst = (from a in _db.HoaDons
                       where a.trangThai == 1
                       select new ThongKeDTO()
                       {
                           ThoiGianDat = (DateTime)a.ngaytao,
                           ThanhTien = (decimal)a.thanhTien,
                       }).ToList();
            return lst;
        }


    }
}
