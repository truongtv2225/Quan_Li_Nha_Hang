using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_ChucVu
{
    public interface IChucVuService
    {
        List<ChucVu> ViewData();

        bool Them(ChucVu cv);

        bool CheckTrung(string ma);
    }
}
