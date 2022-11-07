using BUS.BUS_LoaiHang;
using BUS.BUS_Nsx;
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
    public partial class Frm_QLNSX : Form
    {
        INsxServices nsxServices;
        public Frm_QLNSX()
        {
            InitializeComponent();
            nsxServices = new NsxServices();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var nsx = new Nsx()
            {
                Ma = txtMa.Text,
                Ten = txtTen.Text,
            };

            if (txtMa.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else if (nsxServices.CheckTrung(txtMa.Text))
            {
                MessageBox.Show("Loại hàng này đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (nsxServices.Them(nsx))
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

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_QLNSX_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        //Lấy danh sách loại hàng
        public void GetAll()
        {
            dgvNsx.DataSource = nsxServices.GetAll();
        }

        //Xóa dữ liệu textbox
        public void ClearAll()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }

    }
}
