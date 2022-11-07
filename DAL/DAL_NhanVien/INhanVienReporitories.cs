using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_NhanVien
{
    public interface INhanVienServices
    {
        List<TaiKhoan> GetAll();

        bool Them(TaiKhoan acc);

        List<DTO_TaiKhoan> ViewData();

        List<DTO_TaiKhoan> ViewDataVhh();

        bool Sua(TaiKhoan acc);

        bool Xoa(TaiKhoan acc);
    }
}
