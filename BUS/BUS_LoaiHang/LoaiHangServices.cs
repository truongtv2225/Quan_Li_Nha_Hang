using DAL;
using DAL.DAL_Lh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_LoaiHang
{
    public class LoaiHangServices : ILoaiHangServices
    {
        ILoaiHangReporitories _ILhRepo;

        public LoaiHangServices()
        {
            _ILhRepo = new LoaiHangReporitories();
        }

        public bool CheckTrung(string ma)
        {
            var lh = GetAll().FirstOrDefault(c => c.Ma == ma);
            if (lh == null) return false;
            return true;
        }

        public List<LoaiHang> GetAll()
        {
            return _ILhRepo.GetAll();
        }

        public bool Sua(LoaiHang lh)
        {
            if (lh == null) return false;
            if (_ILhRepo.Sua(lh)) return true;
            return false;
        }

        public bool Them(LoaiHang lh)
        {
            if (lh == null) return false;
            if (_ILhRepo.Them(lh)) return true;
            return false;
        }
    }
}
