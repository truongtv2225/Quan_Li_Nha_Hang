using DAL;
using GUI.service;
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
    public partial class Frm_NhanVien : Form
    {
        TaiKhoan tk = new TaiKhoan();
        Services service;

        public Frm_NhanVien(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            service = new Services();
            string text = "Xin chào," + taiKhoan.HoTen;
            labTen.Text = text;
            ptbAnhDaiDien.Image = service.ByteArrayToImage(taiKhoan.Anh);
            tk = new TaiKhoan()
            {
                Ma = taiKhoan.Ma,
                HoTen = taiKhoan.HoTen,
                Anh = taiKhoan.Anh,
                GioiTinh = taiKhoan.GioiTinh,
                NgaySinh = taiKhoan.NgaySinh,
                DiaChi = taiKhoan.DiaChi,
                TrangThai = taiKhoan.TrangThai,
                TenDangNhap = taiKhoan.TenDangNhap,
                MatKhau = taiKhoan.MatKhau,
            };
        }

        Form currentFormChile;

        public void OpenChildForm(Form ChildForm)
        {
            if (currentFormChile != null)
            {
                currentFormChile.Close();
            }
            currentFormChile = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(ChildForm);
            panel3.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_BanHang(tk));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
