using BUS.BUS_ChucVu;
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
    public partial class Frm_ChucVu : Form
    {
        IChucVuService chucVuService;
        public Frm_ChucVu()
        {
            InitializeComponent();
            chucVuService = new ChucVuService();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var chucvu = new ChucVu()
            {
                Ma = txtMa.Text,
                Ten = txtTen.Text,
            };

            if (txtMa.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin","Thông báo",MessageBoxButtons.OK);
            }
            else if (chucVuService.CheckTrung(txtMa.Text))
            {
                MessageBox.Show("Chức vụ đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn thêm","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (chucVuService.Them(chucvu))
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

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ChucVu_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        //Lấy danh sách chức vụ
        public void GetAll()
        {
            dgvChucVu.DataSource = chucVuService.ViewData();
        }

        //Xoá dữ liệu textbox
        public void ClearAll()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }
    }
}
