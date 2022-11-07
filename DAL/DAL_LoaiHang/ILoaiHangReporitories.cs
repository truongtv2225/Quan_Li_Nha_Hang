using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_Lh
{
    public interface ILoaiHangReporitories
    {
        List<LoaiHang> GetAll();

        bool Them(LoaiHang lh);

        bool Sua(LoaiHang lh);
    }
}
