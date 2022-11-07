using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_ChiTietHoaDon
{
    public interface IChiTietHoaDonServices
    {
        List<HoaDonChiTiet> GetAll();

        bool Them(HoaDonChiTiet hdct);

        List<DTO_HoaDonChiTiet> ViewData(string ma);

        bool CheckTrung(string MaH,string MaHD);

        bool tangsoluong(string MaH,string MaHD);

        int GetSoLuong(string MaH);

        bool GiamSoLuong(string MaH, string MaHD);

        bool Xoa(string mh,string mhd);
    }
}
