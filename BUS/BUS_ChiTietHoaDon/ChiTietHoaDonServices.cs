using DAL;
using DAL.DAL_ChiTietHoaDon;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_ChiTietHoaDon
{
    public class ChiTietHoaDonServices : IChiTietHoaDonServices
    {
        IChiTietHoaDonReporitories _IHdctRepo;

        public ChiTietHoaDonServices()
        {
            _IHdctRepo = new ChiTietHoaDonRepotories();
        }

        public bool CheckTrung(string MaH,string MaHD)
        {
            if (_IHdctRepo.CheckTrung(MaH,MaHD)) return true;
            return false;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _IHdctRepo.GetAll();
        }

        public int GetSoLuong(string MaH)
        {
            int SoLuong = _IHdctRepo.GetAll().Where(c => c.MaH == MaH).Select(c => c.SoLuong).FirstOrDefault();
            return SoLuong;
        }

        public bool GiamSoLuong(string MaH, string MaHD)
        {
            if (_IHdctRepo.GiamSoLuong(MaH, MaHD)) return true;
            return false;
        }

        public bool tangsoluong(string MaH,string MaHD)
        {
            if (_IHdctRepo.TangSoLuong(MaH,MaHD)) return true;
            return false;
        }

        public bool Them(HoaDonChiTiet hdct)
        {
            if (hdct == null) return false;
            if (_IHdctRepo.ThemHoaDonChiTiet(hdct)) return true;
            return false;
        }

        public List<DTO_HoaDonChiTiet> ViewData(string ma)
        {
            return _IHdctRepo.ViewData(ma);
        }

        public bool Xoa(string mh, string mhd)
        {
            if (_IHdctRepo.Xoa(mh,mhd))
            {
                return true;
            }
            return false;
        }
    }
}
