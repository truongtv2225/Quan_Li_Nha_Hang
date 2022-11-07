using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public byte[] Anh { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string Nsx { get; set; }
        public string LoaiHang { get; set; }
    }
}
