using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_TaiKhoan
{
    public interface INhanVienService
    {
        bool Them(TaiKhoan acc);

        List<TaiKhoan> GetAll();

        List<TaiKhoan> Tim(string ma);

        bool checkTrungNv(string ma);

        List<DTO_TaiKhoan> ViewData();

        bool Sua(TaiKhoan acc);

        List<string> GetCV();

        string GetM(string ten);

        bool VoHieu(string ma);

        bool KhoiPhuc(string ma);

        List<DTO_TaiKhoan> ViewDataVhh();

        bool Xoa(TaiKhoan acc);

        int DangNhap(string tk,string mk);

        TaiKhoan GetNhanVien(string tenDangNhap,string MatKhau);
    }
}
