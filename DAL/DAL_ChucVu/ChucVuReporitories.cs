using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_ChucVu
{
    public class ChucVuReporitories : IChucVuReporitories
    {
        QuanLiNhaHangEntities _db;

        public ChucVuReporitories()
        {
            _db = new QuanLiNhaHangEntities();
        }

        public bool Them(ChucVu cv)
        {
            if (cv == null) return false;
            _db.ChucVus.Add(cv);
            _db.SaveChanges();
            return true;
        }

        public List<ChucVu> ViewData()
        {
            return _db.ChucVus.ToList();
        }
    }
}
