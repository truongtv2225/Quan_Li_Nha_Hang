using DAL;
using DAL.DAL_Lh;
using DAL.DAL_Nsx;
using DAL.DAL_SanPham;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_SanPham
{
    public class SanPhamServices : ISanPhamServices
    {
        ISanPhamReporitories _Isprepo;
        INsxReporitories _Insxrepo;
        ILoaiHangReporitories _Ilhrepo;

        public SanPhamServices()
        {
            _Isprepo = new SanPhamReporitories();
            _Insxrepo = new NsxReporitories();
            _Ilhrepo = new LoaiHangReporitories();
        }

        public bool checkTrung(string ma)
        {
            var sp = _Isprepo.GetAll().FirstOrDefault(c => c.Ma == ma);
            if (sp == null)
            {
                return false;
            }
            return true;
        }

        public List<Hang> GetAll()
        {
            return _Isprepo.GetAll();
        }

        public decimal GetGia(string MaH)
        {
            decimal gia = _Isprepo.GetAll().Where(c => c.Ma == MaH).Select(c => c.GiaBan).FirstOrDefault();
            return gia;
        }

        public string GetMaLH(string Ten)
        {
            var ma = _Ilhrepo.GetAll().Where(c => c.Ten == Ten).Select(c => c.Ma).FirstOrDefault().ToString();
            return ma;
        }

        public string GetMaNsx(string Ten)
        {
            var ma = _Insxrepo.GetAll().Where(c => c.Ten == Ten).Select(c => c.Ma).FirstOrDefault().ToString();
            return ma;
        }

        public string getMH(string ten)
        {
            var MH = _Isprepo.GetAll().Where(c => c.Ten == ten).Select(c => c.Ma).FirstOrDefault();
            return MH;
        }

        public List<string> GetTenLh()
        {
            var result = _Ilhrepo.GetAll().Select(c => c.Ten).ToList();
            return result;
        }

        public List<string> GetTenNsx()
        {
            var result = _Insxrepo.GetAll().Select(c => c.Ten).ToList();
            return result;
        }

        public bool Sua(Hang sp)
        {
            if (sp == null) return false;
            if (_Isprepo.Sua(sp)) return true;
            return false;
        }

        public bool Them(Hang sp)
        {
            if (sp == null) return false;
            if (_Isprepo.Them(sp)) return true;
            return false;
        }

        public List<DTO_SanPham> TimKiem(string str)
        {
            var result = _Isprepo.ViewData().Where(c => c.Ma.StartsWith(str.ToUpper()) || c.Ten.Contains(str)).ToList();
            return result;
        }

        public bool updateSoLuong(string ma,int soluong)
        {
            return _Isprepo.updateSoLuong(ma, soluong);
        }

        public List<DTO_SanPham> ViewData()
        {
            return _Isprepo.ViewData();
        }

        public bool Xoa(string ma)
        {
            if (_Isprepo.Xoa(ma)) return true;
            return false;
        }


    }
}
