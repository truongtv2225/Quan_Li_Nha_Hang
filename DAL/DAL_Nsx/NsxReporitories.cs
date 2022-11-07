using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_Nsx
{
    public class NsxReporitories : INsxReporitories
    {
        QuanLiNhaHangEntities _db;
        public NsxReporitories()
        {
            _db = new QuanLiNhaHangEntities();
        }

        public List<Nsx> GetAll()
        {
            return _db.Nsxes.ToList();
        }


        public bool Sua(Nsx nsx)
        {
            if (nsx == null) return false;
            var a = _db.Nsxes.FirstOrDefault(c => c.Ma == nsx.Ma);
            a.Ten = nsx.Ten;
            _db.SaveChanges();
            return true;
        }

        public bool Them(Nsx nsx)
        {
            if (nsx == null) return false;
            _db.Nsxes.Add(nsx);
            _db.SaveChanges();
            return true;
        }
    }
}
