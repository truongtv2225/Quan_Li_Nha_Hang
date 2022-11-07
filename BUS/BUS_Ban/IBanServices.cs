using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_Ban
{
    public interface IBanServices
    {
        List<Ban> GetAll();

        bool Them(Ban ban);

        bool CheckTrung(string ma);

        int GetTrangThai(string ma);

        bool ChuyenTrangThai(string ma);

        bool ChuyenTrangThai1(string ma);

        string GetMaBan(string Ten);
    }
}
