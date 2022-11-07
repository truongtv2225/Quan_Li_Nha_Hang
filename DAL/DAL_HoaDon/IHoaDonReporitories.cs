using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_HoaDon
{
    public interface IHoaDonReporitories
    {
        bool them(HoaDon hd);

        List<HoaDon> GetAll();

        bool ThanhToan(string ma);

        bool UpdateThanhTien(string ma,decimal thanhtien);

        decimal GetThanhTien(string ma);

        List<ThongKeDTO> ViewDataThongKe();
    }
}
