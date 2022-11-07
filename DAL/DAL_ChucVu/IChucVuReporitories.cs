using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_ChucVu
{
    public interface IChucVuReporitories
    {
        List<ChucVu> ViewData();

        bool Them(ChucVu cv);
    }
}
