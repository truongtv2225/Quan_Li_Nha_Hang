using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_Lh
{
    public class LoaiHangReporitories : ILoaiHangReporitories
    {
        QuanLiNhaHangEntities _db;

        public LoaiHangReporitories()
        {
            _db = new QuanLiNhaHangEntities();
        }

        public List<LoaiHang> GetAll()
        {
            return _db.LoaiHangs.ToList();
        }

        public bool Sua(LoaiHang Lh)
        {
            if (Lh == null) return false;
            var a = _db.LoaiHangs.FirstOrDefault(c => c.Ma == Lh.Ma);
            a.Ten = Lh.Ten;
            _db.SaveChanges();
            return true;
        }

        public bool Them(LoaiHang Lh)
        {
            if (Lh == null) return false;
            _db.LoaiHangs.Add(Lh);
            _db.SaveChanges();
            return true;
        }
    }
}
