using DAL;
using DAL.DAL_ChucVu;
using DAL.DAL_NhanVien;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_TaiKhoan
{
    public class NhanVienService : INhanVienService
    {
        INhanVienServices _INvRepo;
        IChucVuReporitories _ICvRepo;

        public NhanVienService()
        {
            _INvRepo = new NhanVienReporitories();
            _ICvRepo = new ChucVuReporitories();
        }

        public bool Them(TaiKhoan acc)
        {
            if (acc == null) return false;
            if (_INvRepo.Them(acc)) return true;
            return false;
        }

        public List<TaiKhoan> Tim(string str)
        {
            var nv = _INvRepo.GetAll().Where(c => c.Ma == str.ToUpper() || c.HoTen.Contains(str)).ToList();
            return nv;
        }

        public bool checkTrungNv(string ma)
        {
            var nv = _INvRepo.ViewData().FirstOrDefault(c => c.Ma == ma);
            if (nv != null) return true;
            return false;
        }

        public List<TaiKhoan> GetAll()
        {
            return _INvRepo.GetAll();
        }

        public List<DTO_TaiKhoan> ViewData()
        {
            return _INvRepo.ViewData();
        }

        public bool Sua(TaiKhoan acc)
        {
            if (acc == null) return false;
            if (_INvRepo.Sua(acc)) return true;
            return false;
        }

        public List<string> GetCV()
        {
            return _ICvRepo.ViewData().Select(c => c.Ten).ToList();
        }

        public string GetM(string ten)
        {
            var Ma = _ICvRepo.ViewData().Where(c => c.Ten == ten).Select(a => a.Ma).FirstOrDefault();
            return Ma;
        }

        public bool VoHieu(string ma)
        {
            var nv = _INvRepo.GetAll().FirstOrDefault(c => c.Ma == ma);
            nv.TrangThai = 1;
            if (_INvRepo.Sua(nv)) return true;
            return false;
        }

        public List<DTO_TaiKhoan> ViewDataVhh()
        {
            return _INvRepo.ViewDataVhh();
        }

        public bool KhoiPhuc(string ma)
        {
            var nv = _INvRepo.GetAll().FirstOrDefault(c => c.Ma == ma);
            nv.TrangThai = 0;
            if (_INvRepo.Sua(nv)) return true;
            return false;
        }

        public bool Xoa(TaiKhoan acc)
        {
            if (acc == null) return false;
            if (_INvRepo.Xoa(acc)) return true;
            return false;
        }

        public int DangNhap(string tk, string mk)
        {
            var nv = _INvRepo.GetAll().Where(c => c.TenDangNhap == tk && c.MatKhau == mk).FirstOrDefault();

            if (nv == null)
            {
                return 4;
            }
            else if (nv.TrangThai == 1)
            {
                return 0;
            }
            else if (nv.TrangThai == 0 && nv.MaCV == "CV01")
            {
                return 1;
            }else if (nv.TrangThai == 0 && nv.MaCV == "CV02")
            {
                return 2;
            }
            return 3;
        }

        public TaiKhoan GetNhanVien(string tenDangNhap, string MatKhau)
        {
            var nv = _INvRepo.GetAll().FirstOrDefault(c => c.TenDangNhap == tenDangNhap && c.MatKhau == MatKhau);
            return nv;
        }
    }
}
