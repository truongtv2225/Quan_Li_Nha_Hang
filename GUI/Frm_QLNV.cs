using BUS.BUS_TaiKhoan;
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
    public partial class Frm_QLNV : Form
    {
        INhanVienService nhanVienService;
        Services Services;

        public Frm_QLNV()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
            Services = new Services();
        }

        private void Frm_QLNV_Load(object sender, EventArgs e)
        {
            GetAll();
            cbbCV.DataSource = nhanVienService.GetCV();
            rbtnNam.Checked = true;
        }

        //Hiển thị danh sách nhân viên
        private void btnDs_Click(object sender, EventArgs e)
        {
            GetAll();
            btnKhoiPhuc.Hide();
            btnVoHieu.Show();
        }

        //Hiển thị danh sách vô hiệu hóa
        private void btnDsVhh_Click(object sender, EventArgs e)
        {
            GetAllVhh();
            btnKhoiPhuc.Show();
            btnVoHieu.Hide();
        }

        //Vố hiệu hóa nhân viên
        private void btnVoHieu_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Mời chọn nhân viên cần vô hiệu hóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn vô hiệu nhân viên này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nhanVienService.VoHieu(txtMa.Text))
                    {
                        MessageBox.Show("Đã vô hiệu nhân viên này", "Thông báo", MessageBoxButtons.OK);
                        ClearAll();
                        GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Vô hiệu thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        //KHôi phục nhân viên
        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Mời chọn nhân viên cần Khôi phục", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn vô hiệu nhân viên này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nhanVienService.KhoiPhuc(txtMa.Text))
                    {
                        MessageBox.Show("Đã khôi phục nhân viên này", "Thông báo", MessageBoxButtons.OK);
                        ClearAll();
                        GetAllVhh();
                    }
                    else
                    {
                        MessageBox.Show("Khôi phục thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        //Thêm nhân viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ptbAnh.Image == null || txtDiaChi.Text == "" || txtMa.Text == "" || txtMatKhau.Text == "" || txtNgaySinh.Text == "" || txtTen.Text == "" || txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else if (nhanVienService.checkTrungNv(txtMa.Text))
            {
                MessageBox.Show("Nhân viên này đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                var nhanvien = new TaiKhoan()
                {
                    Ma = txtMa.Text,
                    HoTen = txtTen.Text,
                    GioiTinh = rbtnNam.Checked == true ? "Nam" : "Nữ",
                    NgaySinh = txtNgaySinh.Text,
                    MaCV = nhanVienService.GetM(cbbCV.Text),
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = txtMatKhau.Text,
                    DiaChi = txtDiaChi.Text,
                    Anh = Services.imageToByteArray(ptbAnh.Image),
                    TrangThai = 0,
                };

                if (MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nhanVienService.Them(nhanvien))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        ClearAll();
                        GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        //Sủa nhân viên
        private void btnSua_Click(object sender, EventArgs e)
        {
           

            if (ptbAnh.Image == null || txtDiaChi.Text == "" || txtMa.Text == "" || txtMatKhau.Text == "" || txtNgaySinh.Text == "" || txtTen.Text == "" || txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                var nhanvien = new TaiKhoan()
                {
                    Ma = txtMa.Text,
                    HoTen = txtTen.Text,
                    GioiTinh = rbtnNam.Checked == true ? "Nam" : "Nữ",
                    NgaySinh = txtNgaySinh.Text,
                    MaCV = nhanVienService.GetM(cbbCV.Text),
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = txtMatKhau.Text,
                    DiaChi = txtDiaChi.Text,
                    Anh = Services.imageToByteArray(ptbAnh.Image),
                    TrangThai = 0,
                };

                if (MessageBox.Show("Bạn có muốn Sửa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nhanVienService.Sua(nhanvien))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        ClearAll();
                        GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        //Chọn ảnh
        private void ptbAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image anhupload = Image.FromFile(open.FileName);
                ptbAnh.Image = anhupload;
            }
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            Frm_ChucVu chucvu = new Frm_ChucVu();
            chucvu.ShowDialog();
        }

        //Xóa dữ liệu textbox
        private void ClearAll()
        {
            txtMa.Text = "";
            txtDiaChi.Text = "";
            txtMatKhau.Text = "";
            txtTen.Text = "";
            txtTenDangNhap.Text = "";
            ptbAnh.Image = null;
        }

        //Lấy danh sach nhân viên
        private void GetAll()
        {
            dgvNhanVien.DataSource = nhanVienService.ViewData();
        }

        //Lấy danh sách vô hiệu hóa
        private void GetAllVhh()
        {
            dgvNhanVien.DataSource = nhanVienService.ViewDataVhh();
        }
        
        //Tìm kiếm nhân viên
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVienService.Tim(txtTimKiem.Text);
        }


        //Đổ dữ liệu từ gridview vào các textbox
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.RowCount > 0)
            {
                txtMa.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                ptbAnh.Image = Services.ByteArrayToImage((byte[])dgvNhanVien.CurrentRow.Cells[2].Value);
                if (dgvNhanVien.CurrentRow.Cells[3].Value.ToString() == "Nam")
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }
                txtNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                txtTenDangNhap.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                txtMatKhau.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
                cbbCV.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
                txtMa.Enabled = true;
            }
        }
    }
}
