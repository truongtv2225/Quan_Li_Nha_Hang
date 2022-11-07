using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_NhanVien
{
    public class NhanVienReporitories : INhanVienServices
    {
        QuanLiNhaHangEntities _db;

        public NhanVienReporitories()
        {
            _db = new QuanLiNhaHangEntities();
        }

        public List<TaiKhoan> GetAll()
        {
            return _db.TaiKhoans.ToList();
        }

        public bool Sua(TaiKhoan acc)
        {
            if (acc == null) return false;
            var nv = _db.TaiKhoans.FirstOrDefault(c => c.Ma == acc.Ma);
            nv.HoTen = acc.HoTen;
            nv.Anh = acc.Anh;
            nv.GioiTinh = acc.GioiTinh;
            nv.TrangThai = acc.TrangThai;
            nv.DiaChi = acc.DiaChi;
            nv.NgaySinh = acc.NgaySinh;
            nv.MaCV = acc.MaCV;
            nv.TenDangNhap = acc.TenDangNhap;
            nv.MatKhau = acc.MatKhau;
            _db.SaveChanges();
            return true;
        }

        public bool Them(TaiKhoan acc)
        {
            if (acc == null) return false;
            _db.TaiKhoans.Add(acc);
            _db.SaveChanges();
            return true;
        }

        public List<DTO_TaiKhoan> ViewData()
        {
            var result = (from a in _db.TaiKhoans
                          join b in _db.ChucVus on a.MaCV equals b.Ma
                          where a.TrangThai == 0 && a.MaCV != "CV01"
                          select new DTO_TaiKhoan()
                          {
                              Anh = a.Anh,
                              Ma = a.Ma,
                              HoTen = a.HoTen,
                              NgaySinh = a.NgaySinh,
                              GioiTinh = a.GioiTinh,
                              DiaChi = a.DiaChi,
                              TenDangNhap = a.TenDangNhap,
                              MatKhau = a.MatKhau,
                              TenChucVu = b.Ten,
                          }).ToList();

            return result;
        }

        public List<DTO_TaiKhoan> ViewDataVhh()
        {
            var result = (from a in _db.TaiKhoans
                          join b in _db.ChucVus on a.MaCV equals b.Ma
                          where a.TrangThai == 1 && a.MaCV != "CV01"
                          select new DTO_TaiKhoan()
                          {
                              Anh = a.Anh,
                              Ma = a.Ma,
                              HoTen = a.HoTen,
                              NgaySinh = a.NgaySinh,
                              GioiTinh = a.GioiTinh,
                              DiaChi = a.DiaChi,
                              TenDangNhap = a.TenDangNhap,
                              MatKhau = a.MatKhau,
                              TenChucVu = b.Ten,
                          }).ToList();

            return result;
        }

        public bool Xoa(TaiKhoan acc)
        {
            if (acc == null) return false;
            _db.TaiKhoans.Remove(acc);
            _db.SaveChanges();
            return true;
        }
    }
}
