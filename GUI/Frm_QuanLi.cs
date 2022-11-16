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
    public partial class Frm_QuanLi : Form
    {
        TaiKhoan tk = new TaiKhoan();
        Services service;
        public Frm_QuanLi(TaiKhoan taiKhoan)
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

        private void ptbAnhDaiDien_Click(object sender, EventArgs e)
        {
            Form_ThongTinTaiKHoan thongtin = new Form_ThongTinTaiKHoan(tk);
            thongtin.ShowDialog();
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

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_QLNV());
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_QLSP());
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_BanHang(tk));
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_ThongKe());
        }

        private void Frm_QuanLi_Load(object sender, EventArgs e)
        {

        }
    }
}
