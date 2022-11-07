using DAL;
using DAL.DAL_Nsx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_Nsx
{
    public class NsxServices : INsxServices
    {
        INsxReporitories _INsxRepo;
        public NsxServices()
        {
            _INsxRepo = new NsxReporitories();
        }
        public List<Nsx> GetAll()
        {
            return _INsxRepo.GetAll();
        }

        public bool Sua(Nsx nsx)
        {
            if (nsx == null) return false;
            if (_INsxRepo.Sua(nsx)) return true;
            return false;
        }

        public bool Them(Nsx nsx)
        {
            if (nsx == null) return false;
            if (_INsxRepo.Them(nsx)) return true;
            return false;
        }

        public bool CheckTrung(string ma)
        {
            var nsx = GetAll().FirstOrDefault(c => c.Ma == ma);
            if (nsx == null) return false;
            return true;
        }

        public List<string> GetNameNsx()
        {
            var Ten = _INsxRepo.GetAll().Select(c => c.Ten).ToList();

            return Ten;
        }
    }
}
