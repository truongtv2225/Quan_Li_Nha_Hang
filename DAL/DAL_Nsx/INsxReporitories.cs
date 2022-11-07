using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_Nsx
{
    public interface INsxReporitories
    {
        List<Nsx> GetAll();

        bool Them(Nsx nsx);

        bool Sua(Nsx nsx);

        
    }
}
