using BUS.BUS_HoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Frm_ThongKe : Form
    {
        IHoaDonServices _HoaDonServices;
        public Frm_ThongKe()
        {
            InitializeComponent();
            _HoaDonServices = new HoaDonServices();
        }

        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            foreach (var item in _HoaDonServices.ViewDataThongKe())
            {
                BieuDoDoanhThu.Series["DoanhThu"].Points.AddXY("Tháng " + item.ThoiGianDat,item.ThanhTien);
            }
        }
    }
}
