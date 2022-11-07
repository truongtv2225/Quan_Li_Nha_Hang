using BUS.BUS_LoaiHang;
using DAL;
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
    public partial class Frm_QLLH : Form
    {
        ILoaiHangServices loaiHangServices;
        public Frm_QLLH()
        {
            InitializeComponent();
            loaiHangServices = new LoaiHangServices();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var loai = new LoaiHang()
            {
                Ma = txtMa.Text,
                Ten = txtTen.Text,
            };

            if (txtMa.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else if (loaiHangServices.CheckTrung(txtMa.Text))
            {
                MessageBox.Show("Loại hàng này đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn thêm","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (loaiHangServices.Them(loai))
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

        private void Frm_QLLH_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        //Lấy danh sách loại hàng
        public void GetAll()
        {
            dgvLoai.DataSource = loaiHangServices.GetAll();
        }

        //Xóa dữ liệu textbox
        public void ClearAll()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }

    }
}
