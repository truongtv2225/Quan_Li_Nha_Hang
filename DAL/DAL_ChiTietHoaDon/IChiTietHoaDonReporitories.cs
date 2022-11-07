using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IChiTietHoaDonReporitories
    {
        List<HoaDonChiTiet> GetAll();

        bool ThemHoaDonChiTiet(HoaDonChiTiet hdct);

        List<DTO_HoaDonChiTiet> ViewData(string ma);

        bool TangSoLuong(string MaH,string MaHD);

        bool CheckTrung(string MaH,string MaHD);

        bool GiamSoLuong(string MaH, string MaHD);

        bool Xoa(string mh,string mhd);
    }
}
