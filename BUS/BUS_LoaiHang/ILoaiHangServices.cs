using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS_LoaiHang
{
    public interface ILoaiHangServices
    {
        List<LoaiHang> GetAll();

        bool Them(LoaiHang lh);

        bool Sua(LoaiHang lh);

        bool CheckTrung(string ma);
    }
}
