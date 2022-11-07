using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_HoaDon
{
    public interface IHoaDonServices
    {
        bool Them(HoaDon hd);

        List<HoaDon> GetAll();

        bool ThayDoiTrangThai(string ma);

        string GetMaHD(string maban,int trangthai);

        bool checktrung(string mahd);

        bool GetTrangThai(string mahd);

        bool UpdateThanhTien(string ma,decimal thanhtien);

        decimal GetThanhTien(string ma);

        List<ThongKeDTO> ViewDataThongKe();

        decimal GetThanhTienTheoThang(DateTime time, decimal tongtien);
    }
}
