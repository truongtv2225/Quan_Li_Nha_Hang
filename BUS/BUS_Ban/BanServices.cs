using DAL;
using DAL.DAL_Ban;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_Ban
{
    public class BanServices : IBanServices
    {
        IBanReporitories _IBanRepo;

        public BanServices()
        {
            _IBanRepo = new BanReporitories();
        }

        public bool CheckTrung(string ma)
        {
            var ban = GetAll().FirstOrDefault(c=>c.Ma == ma);
            if (ban != null) return true;
            return false;
        }

        public bool ChuyenTrangThai(string ma)
        {
            if (_IBanRepo.ChuyenTrangThai(ma)) return true;
            return false;
        }

        public bool ChuyenTrangThai1(string ma)
        {
            if (_IBanRepo.ChuyenTrangThai1(ma)) return true;
            return false;
        }

        public List<Ban> GetAll()
        {
            return _IBanRepo.GetAll();
        }

        public string GetMaBan(string Ten)
        {
            var maban = _IBanRepo.GetAll().Where(c => c.Ten == Ten).Select(c => c.Ma).FirstOrDefault();
            return maban;
        }

        public int GetTrangThai(string ma)
        {

            int TrangThai = Convert.ToInt32(_IBanRepo.GetAll().Where(c=>c.Ma == ma).Select(c=>c.TrangThai).FirstOrDefault());
            return TrangThai;
        }

        public bool Them(Ban ban)
        {
            if (ban == null) return false;
            if (_IBanRepo.Them(ban)) return true;
            return false;
        }

       
    }
}
