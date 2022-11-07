using DAL;
using DAL.DAL_ChucVu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_ChucVu
{
    public class ChucVuService : IChucVuService
    {
        IChucVuReporitories _IChucVuReporitories;

        public ChucVuService()
        {
            _IChucVuReporitories = new ChucVuReporitories();
        }

        public bool Them(ChucVu cv)
        {
            if (cv == null) return false;
            if (_IChucVuReporitories.Them(cv)) return true;
            return false;
        }

        public List<ChucVu> ViewData()
        {
            return _IChucVuReporitories.ViewData();
        }

        public bool CheckTrung(string ma)
        {
            var chucvu = _IChucVuReporitories.ViewData().FirstOrDefault(c => c.Ma == ma);
            if (chucvu != null) return true;
            return false;
        }
    }
}
