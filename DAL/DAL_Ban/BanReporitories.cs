using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_Ban
{
    public class BanReporitories : IBanReporitories
    {
        QuanLiNhaHangEntities _db;

        public BanReporitories()
        {
            _db = new QuanLiNhaHangEntities();
        }

        public bool ChuyenTrangThai(string ma)
        {
            var ban = _db.Bans.FirstOrDefault(c => c.Ma == ma);
            ban.TrangThai = 1;
            _db.SaveChanges();
            return true;
        }

        public bool ChuyenTrangThai1(string ma)
        {
            var ban = _db.Bans.FirstOrDefault(c => c.Ma == ma);
            ban.TrangThai = 0;
            _db.SaveChanges();
            return true;
        }

        public List<Ban> GetAll()
        {
            return _db.Bans.ToList();
        }

        public bool Them(Ban ban)
        {
            if (ban == null) return false;
            _db.Bans.Add(ban);
            _db.SaveChanges();
            return true;
        }
    }
}
