using BUS.BUS_Ban;
using BUS.BUS_ChiTietHoaDon;
using BUS.BUS_HoaDon;
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
    public partial class Frm_BanHang : Form
    {
        IBanServices banServices;
        IHoaDonServices hoaDonServices;
        IChiTietHoaDonServices ChiTietHoaDonService;
        ISanPhamServices sanPhamServices;
        Services Services;
        TaiKhoan tk;
        decimal thanhtien;
        public Frm_BanHang(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            banServices = new BanServices();
            hoaDonServices = new HoaDonServices();
            ChiTietHoaDonService = new ChiTietHoaDonServices();
            sanPhamServices = new SanPhamServices();
            Services = new Services();
            tk = taiKhoan;
        }

        void GetAllBan()
        {
            foreach (var x in banServices.GetAll())
            {
                Label lbBan = new Label();
                lbBan.Width = 70;
                lbBan.Height = 90;
                lbBan.Text = x.Ten;
                lbBan.Name = x.Ma;
                if (banServices.GetTrangThai(x.Ma) == 0)
                {
                    lbBan.BackColor = Color.Green;
                }
                else
                {
                    lbBan.BackColor = Color.DarkOrange;
                }
                lbBan.TextAlign = ContentAlignment.MiddleCenter;
                lbBan.ForeColor = Color.White;
                lbBan.Font = new Font(lbBan.Font, FontStyle.Bold);

                flowban.Controls.Add(lbBan);

                lbBan.Click += (sender, e) => lbBan_OnClick(this, e, lbBan.Name, lbBan.Text);
            }
        }

        private void lbBan_OnClick(Frm_BanHang frm_BanHang, EventArgs e, string ma, string ten)
        {
            if (banServices.GetTrangThai(ma) == 0)
            {
                txtTenBan.Text = ten;

                if (txtMaHD.Text.Trim() == "")
                {
                    MessageBox.Show("Mời nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK);
                }
                else if (hoaDonServices.checktrung(txtMaHD.Text))
                {
                    MessageBox.Show("Hóa đơn đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    var hd = new HoaDon()
                    {
                        Ma = txtMaHD.Text,
                        MaB = ma,
                        MaTK = tk.Ma,
                        ngaytao = DateTime.Now,
                        thanhTien = 0,
                        trangThai = 0,
                    };

                    if (hoaDonServices.Them(hd))
                    {
                        MessageBox.Show(ten + " đã được kích hoạt", "Thông báo", MessageBoxButtons.OK);
                        if (banServices.ChuyenTrangThai(ma))
                        {
                            flowban.Controls.Clear();
                            GetAllBan();
                        }
                        txtMaHD.Text = "";
                        txtTenBan.Text = "";
                    }
                }
            }
            else
            {
                txtTenBan.Text = ten;
                txtMaHD.Text = hoaDonServices.GetMaHD(ma, 1);
                txtThanhTien.Text = hoaDonServices.GetThanhTien(txtMaHD.Text).ToString().Replace("000.0000", ".000 Đ");
                GetAllCTHD();
            }
        }

        void GetAllSanPham()
        {
            foreach (var item in sanPhamServices.GetAll())
            {
                PictureBox ptbAnhSP = new PictureBox();
                Label lbTenSP = new Label();
                Label lbGiaSP = new Label();
                Panel ChiTietSP = new Panel();
                string gia = item.GiaBan.ToString().Replace("000.0000",".000 Đ");

                ptbAnhSP.Name = item.Ma;
                ptbAnhSP.Image = Services.ByteArrayToImage(item.Anh);
                ptbAnhSP.Width = 100;
                ptbAnhSP.Height = 60;
                ptbAnhSP.SizeMode = PictureBoxSizeMode.Zoom;
                ptbAnhSP.Location = new Point(0, 20);

                lbGiaSP.Text = gia;
                lbGiaSP.Width = 100;
                lbGiaSP.Height = 15;
                lbGiaSP.Location = new Point(0, 95);
                lbGiaSP.BackColor = Color.Green;
                lbGiaSP.TextAlign = ContentAlignment.MiddleCenter;
                lbGiaSP.ForeColor = Color.White;

                lbTenSP.Text = item.Ten;
                lbTenSP.Width = 100;
                lbTenSP.Height = 15;
                lbTenSP.Location = new Point(0, 0);
                lbTenSP.BackColor = Color.Green;
                lbTenSP.TextAlign = ContentAlignment.MiddleCenter;
                lbTenSP.ForeColor = Color.White;

                ChiTietSP.Controls.Add(ptbAnhSP);
                ChiTietSP.Controls.Add(lbGiaSP);
                ChiTietSP.Controls.Add(lbTenSP);
                ChiTietSP.Width = 100;
                ChiTietSP.Height = 110;
                ChiTietSP.BorderStyle = BorderStyle.FixedSingle;

                flowsanpham.Controls.Add(ChiTietSP);

                ptbAnhSP.Click += (sender, e) => BtnSp_OnClick(this,e,ptbAnhSP.Name,item.GiaBan);
            }
        }

        private void BtnSp_OnClick(Frm_BanHang frm_BanHang, EventArgs e, string name, decimal giaBan)
        {
            if (txtTenBan.Text.Trim() == "")
            {
                MessageBox.Show("Mời chọn bàn");
            }
            else if (ChiTietHoaDonService.CheckTrung(name,txtMaHD.Text))
            {
                var cthd = new HoaDonChiTiet()
                {
                    MaHoaDon = txtMaHD.Text,
                    MaH = name,
                    SoLuong = 1,
                    TongTien = sanPhamServices.GetGia(name),
                };

                if (ChiTietHoaDonService.Them(cthd))
                {
                    thanhtien += giaBan;
                    txtThanhTien.Text = thanhtien.ToString().Replace("000.0000", ".000 Đ");
                    if (hoaDonServices.UpdateThanhTien(txtMaHD.Text,thanhtien))
                    {
                        GetAllCTHD();
                    }
                }
            }
            else
            {
                thanhtien += giaBan;
                txtThanhTien.Text = thanhtien.ToString().Replace("000.0000", ".000 Đ");
                if (ChiTietHoaDonService.tangsoluong(name,txtMaHD.Text))
                {
                    if (hoaDonServices.UpdateThanhTien(txtMaHD.Text, thanhtien))
                    {
                        GetAllCTHD();
                    }
                }
            }
        }

        void GetAllCTHD()
        {
            dgvChiTietHD.DataSource = ChiTietHoaDonService.ViewData(txtMaHD.Text);
        }

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            GetAllBan();
            GetAllSanPham();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtTenBan.Text.Trim() == "")
            {
                MessageBox.Show("Mời chọn bàn cần thanh toán", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (hoaDonServices.ThayDoiTrangThai(txtMaHD.Text))
                {
                    if (banServices.ChuyenTrangThai1(banServices.GetMaBan(txtTenBan.Text)))
                    {
                        dgvChiTietHD.DataSource = null;
                        txtMaHD.Text = "";
                        txtTenBan.Text = "";
                        txtThanhTien.Text = "";
                        MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK);
                        flowban.Controls.Clear();
                        GetAllBan();
                    }
                }
            }
        }

        private void dgvChiTietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mah = sanPhamServices.getMH(dgvChiTietHD.CurrentRow.Cells[1].Value.ToString());
            int sl = Convert.ToInt32(dgvChiTietHD.CurrentRow.Cells[3].Value.ToString());
            decimal gia = sanPhamServices.GetGia(mah);

            if (dgvChiTietHD.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                if (sl == 1)
                {
                    if (ChiTietHoaDonService.Xoa(mah,txtMaHD.Text))
                    {
                        thanhtien -= gia;
                        txtThanhTien.Text = thanhtien.ToString().Replace("000.0000", ".000 Đ");
                        if (hoaDonServices.UpdateThanhTien(txtMaHD.Text, thanhtien))
                        {
                            GetAllCTHD();
                        } 
                    }
                }
                else
                {
                    if (ChiTietHoaDonService.GiamSoLuong(mah, txtMaHD.Text))
                    {
                        thanhtien -= gia;
                        txtThanhTien.Text = thanhtien.ToString().Replace("000.0000", ".000 Đ");
                        if (hoaDonServices.UpdateThanhTien(txtMaHD.Text, thanhtien))
                        {
                            GetAllCTHD();
                        }
                    }
                }
            }
        }
    }
}
