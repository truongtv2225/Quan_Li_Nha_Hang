using DAL;
using GUI.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_ThongTinTaiKHoan : Form
    {
        Services services;
        public Form_ThongTinTaiKHoan(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            services = new Services();
            txtMa.Text = taiKhoan.Ma;
            txtHoTen.Text = taiKhoan.HoTen;
            ptbAnhDaiDien.Image = services.ByteArrayToImage(taiKhoan.Anh);
            txtGioiTinh.Text = taiKhoan.GioiTinh;
            txtNgaySinh.Text = taiKhoan.NgaySinh;
            txtDiaChi.Text = taiKhoan.DiaChi;
            txtTrangThai.Text = taiKhoan.TrangThai==0?"Hoạt động":"Không hoạt động";
            txtTenDangNhap.Text = taiKhoan.TenDangNhap;
            txtMatKhau.Text = taiKhoan.MatKhau;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
