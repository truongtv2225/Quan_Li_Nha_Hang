using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL.DAL_SanPham
{
    public interface ISanPhamReporitories
    {
        List<Hang> GetAll();

        List<DTO_SanPham> ViewData();

        bool Them(Hang sp);

        bool Sua(Hang sp);

        bool Xoa(string ma);

        bool updateSoLuong(string ma, int soluong);


    }
}
