using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_SanPham
{
    public interface ISanPhamServices
    {
        List<Hang> GetAll();

        List<DTO_SanPham> ViewData();

        bool Them(Hang sp);

        bool Sua(Hang sp);

        bool Xoa(string ma);

        string GetMaNsx(string Ten);

        string GetMaLH(string Ten);

        List<string> GetTenNsx();

        List<string> GetTenLh();

        bool updateSoLuong(string ma,int soluong);

        List<DTO_SanPham> TimKiem(string str);

        decimal GetGia(string MaH);

        bool checkTrung(string ma);

        string getMH(string ten);
    }
}
