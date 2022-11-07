using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_Ban
{
    public interface IBanReporitories
    {
        List<Ban> GetAll();

        bool Them(Ban ban);

        bool ChuyenTrangThai(string ma);

        bool ChuyenTrangThai1(string ma);
    }
}
