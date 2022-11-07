using DAL;
using DAL.DAL_HoaDon;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_HoaDon
{
    public class HoaDonServices : IHoaDonServices
    {
        IHoaDonReporitories _HoaDonRepo;

        public HoaDonServices()
        {
            _HoaDonRepo = new HoaDonReporitories();
        }

        public bool checktrung(string mahd)
        {
            var hoadon = _HoaDonRepo.GetAll().FirstOrDefault(c => c.Ma == mahd);
            if (hoadon == null)
            {
                return false;
            }
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _HoaDonRepo.GetAll();
        }

        public string GetMaHD(string maban, int trangthai)
        {
            var mahd = _HoaDonRepo.GetAll().Where(c => c.MaB == maban && c.trangThai == 0).Select(c => c.Ma).FirstOrDefault();
            return mahd;
        }

        public decimal GetThanhTien(string ma)
        {
            return _HoaDonRepo.GetThanhTien(ma);
        }

        public bool GetTrangThai(string mahd)
        {
            var trangthai = _HoaDonRepo.GetAll().Where(c => c.Ma == mahd).Select(c => c.trangThai).FirstOrDefault();
            if (trangthai == 1)
            {
                return true;
            }
            return false;
        }

        public bool ThayDoiTrangThai(string ma)
        {
            return _HoaDonRepo.ThanhToan(ma);
        }

        public bool Them(HoaDon hd)
        {
            if (hd == null) return false;
            if (_HoaDonRepo.them(hd)) return true;
            return false;
        }

        public bool UpdateThanhTien(string ma, decimal thanhtien)
        {
            if (_HoaDonRepo.UpdateThanhTien(ma,thanhtien))
            {
                return true;
            }
            return false;
        }

        public List<ThongKeDTO> ViewDataThongKe()
        {
            return _HoaDonRepo.ViewDataThongKe();
        }

        public decimal GetThanhTienTheoThang(DateTime time,decimal tongtien)
        {
            var thang = time.Month;
            var tiens = (from a in ViewDataThongKe()
                         where a.ThoiGianDat.Month == thang
                         select a.ThanhTien).ToList();

                        
            foreach (var item in tiens)
            {
                tongtien += item;
            }

            return tongtien;
        }
    }
}
