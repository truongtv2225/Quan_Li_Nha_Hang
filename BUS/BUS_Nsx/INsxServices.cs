using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_Nsx
{
    public interface INsxServices
    {
        List<Nsx> GetAll();

        bool Them(Nsx nsx);

        bool Sua(Nsx nsx);

        bool CheckTrung(string ma);

        List<string> GetNameNsx();
    }
}
