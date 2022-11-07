using BUS.BUS_SanPham;
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
    public partial class Frm_QLSP : Form
    {
        ISanPhamServices sanPhamServices;
        Services Services;
        public Frm_QLSP()
        {
            InitializeComponent();
            sanPhamServices = new SanPhamServices();
            Services = new Services();
        }

        private void btnQLLH_Click(object sender, EventArgs e)
        {
            Frm_QLLH loaihang = new Frm_QLLH();
            loaihang.ShowDialog();
        }

        private void btnQLNSX_Click(object sender, EventArgs e)
        {
            Frm_QLNSX nsx = new Frm_QLNSX();
            nsx.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkNull()) 
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            } 
            else if (sanPhamServices.checkTrung(txtMa.Text))
            {
                if (MessageBox.Show("Bạn có muốn thêm","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (sanPhamServices.updateSoLuong(txtMa.Text,Convert.ToInt32(txtSoLuong.Text)))
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
            else
            {
                var sanpham = new Hang()
                {
                    Ma = txtMa.Text,
                    Ten = txtTen.Text,
                    Anh = Services.imageToByteArray(ptbAnhSP.Image),
                    GiaNhap = Convert.ToDecimal(txtGiaBan.Text),
                    GiaBan = Convert.ToDecimal(txtGiaNhap.Text),
                    SoLuong = Convert.ToInt32(txtSoLuong.Text),
                    MaLH = sanPhamServices.GetMaLH(cbbLoaiSP.Text),
                    MaNsx = sanPhamServices.GetMaNsx(cbbNsx.Text),
                };

                if (MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (sanPhamServices.Them(sanpham))
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                var sanpham = new Hang()
                {
                    Ma = txtMa.Text,
                    Ten = txtTen.Text,
                    Anh = Services.imageToByteArray(ptbAnhSP.Image),
                    GiaNhap = Convert.ToDecimal(txtGiaBan.Text),
                    GiaBan = Convert.ToDecimal(txtGiaNhap.Text),
                    SoLuong = Convert.ToInt32(txtSoLuong.Text),
                    MaLH = sanPhamServices.GetMaLH(cbbLoaiSP.Text),
                    MaNsx = sanPhamServices.GetMaNsx(cbbNsx.Text),
                };

                if (MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (sanPhamServices.Sua(sanpham))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        ClearAll();
                        GetAll();
                        txtMa.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() == "")
            {
                MessageBox.Show("Mời chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (sanPhamServices.Xoa(txtMa.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        ClearAll();
                        GetAll();
                        txtMa.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void Frm_QLSP_Load(object sender, EventArgs e)
        {
            GetAll();
            cbbLoaiSP.DataSource = sanPhamServices.GetTenLh();
            cbbNsx.DataSource = sanPhamServices.GetTenNsx();
        }

        public void GetAll()
        {
            dataGridView1.DataSource = sanPhamServices.ViewData();
        }

        public void ClearAll()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtSoLuong.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            ptbAnhSP.Image = null;
        }

        public bool checkNull()
        {
            if (txtGiaNhap.Text.Trim() == "" || txtGiaBan.Text.Trim() == "" || txtMa.Text.Trim() == "" || txtSoLuong.Text.Trim() == "" || txtTen.Text.Trim() == "" || ptbAnhSP.Image == null) return true;
            return false;
        }

        private void ptbAnhSP_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image anhupload = Image.FromFile(open.FileName);
                ptbAnhSP.Image = anhupload;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                txtMa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ptbAnhSP.Image = Services.ByteArrayToImage((byte[])dataGridView1.CurrentRow.Cells[2].Value);
                txtTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtGiaNhap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtGiaBan.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtSoLuong.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cbbNsx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                cbbLoaiSP.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtMa.Enabled = false;
            }
        }
    }
}
