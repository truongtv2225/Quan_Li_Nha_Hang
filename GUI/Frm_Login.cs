using BUS.BUS_TaiKhoan;
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
    public partial class Frm_Login : Form
    {
        INhanVienService nhanVienService;
        public Frm_Login()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tdn = txtTenDangNhap.Text;
            string mk = txtMatKhau.Text;
            if (nhanVienService.DangNhap(tdn,mk) == 4)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK);
            }
            else if(nhanVienService.DangNhap(tdn, mk) == 0)
            {
                MessageBox.Show("Tài khoản đã bị vô hiệu hóa", "Thông báo", MessageBoxButtons.OK);
            }
            else if (nhanVienService.DangNhap(tdn, mk) == 1)
            {
                var taikhoan = nhanVienService.GetNhanVien(tdn, mk);
                Frm_QuanLi quanLi = new Frm_QuanLi(taikhoan);
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                quanLi.ShowDialog();
            }
            else if (nhanVienService.DangNhap(tdn, mk) == 2)
            {
                var taikhoan = nhanVienService.GetNhanVien(tdn, mk);
                Frm_NhanVien nhanvien = new Frm_NhanVien(taikhoan);
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                nhanvien.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbNho_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "" && txtMatKhau.Text != "")
            {
                if (cbNho.Checked == true)
                {
                    string tdn = txtTenDangNhap.Text;
                    string mk = txtMatKhau.Text;
                    Properties.Settings.Default.TenDangNhap = tdn;
                    Properties.Settings.Default.MatKhau = mk;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            var tendangnhap = Properties.Settings.Default.TenDangNhap;
            var matkhau = Properties.Settings.Default.MatKhau;
            txtTenDangNhap.Text = tendangnhap;
            txtMatKhau.Text = matkhau;
            if (tendangnhap != "")
            {
                cbNho.Checked = true;
            }
        }
    }
}
