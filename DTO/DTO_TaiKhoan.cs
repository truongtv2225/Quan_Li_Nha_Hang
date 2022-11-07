using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public byte[] Anh { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenChucVu { get; set; }
    }
}
