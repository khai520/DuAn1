using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.DAL.Services;
using MainApp.BLL.Models;
using WinFormsApp1.Services;

namespace APPBanHang
{
    public partial class BanHang : Form
    {
        HoadonServices _hoadonService;
        SanphamServices _SanphamServices;
        HoaDonChiTietServices _hoadonChiTietServices;
        CtSanphamService _ctsp;
        NhaCungCapServices _ncc;
        //int _idCellClick;
        public BanHang()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            SanPham sanpham = new SanPham();
            sanpham.ShowDialog();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            NhanVien nhanvien = new NhanVien();
            nhanvien.ShowDialog();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            KhachHang khachHang = new KhachHang();
            khachHang.ShowDialog();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Voucher voucher = new Voucher();
            voucher.ShowDialog();
            this.Close();
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHang ban = new BanHang();
            ban.ShowDialog();
            this.Close();
        }

        private void btnTimSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.ShowDialog();
            this.Close();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();

            SanPham sanpham = new SanPham();
            sanpham.ShowDialog();
            this.Close();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();

            KhachHang khachHang = new KhachHang();
            khachHang.ShowDialog();
            this.Close();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            this.Hide();

            Voucher voucher = new Voucher();
            voucher.ShowDialog();
            this.Close();
        }
        
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void loaddanhsachhoadon()
        {
            int Stt = 1;
            dgvDanhSachHoaDon.DataSource = _hoadonService.Change().Select(x => new
            {
                STT = Stt++,
                x.Mahd,
                x.Idkh,
                x.IdnguoiDung,
                x.Idmagiamgia,
                x.Ngayban,
                x.Tensp,
                x.Soluong,
                x.Tongtien,
                x.Trangthai
            }).ToList();
            dgvDanhSachHoaDon.Columns[0].HeaderText = "STT";
            dgvDanhSachHoaDon.Columns[1].HeaderText = "MaHD";
            dgvDanhSachHoaDon.Columns[2].HeaderText = "Tên khách hàng";
            dgvDanhSachHoaDon.Columns[3].HeaderText = "Tên nhân viên";
            dgvDanhSachHoaDon.Columns[4].HeaderText = "Mã giảm giá";
            dgvDanhSachHoaDon.Columns[5].HeaderText = "Ngày bán";
            dgvDanhSachHoaDon.Columns[6].HeaderText = "Tên sản phẩm";
            dgvDanhSachHoaDon.Columns[7].HeaderText = "Số lượng";
            dgvDanhSachHoaDon.Columns[8].HeaderText = "Tổng tiền";
            dgvDanhSachHoaDon.Columns[9].HeaderText = "Trạng thái";


        }

        private void loaddanhsachsanpham()
        {
            int Stt = 1;
            dgvDanhSachSanPham.DataSource = _SanphamServices.GetSanphams().Join(_ctsp.GetallChitietsanpham(), x => x.Masp, y => y.Masp, (x, y) => new
            {
                x.Masp,
                x.Tensp,
                x.Soluong,
                x.Giaban,
                x.Trangthai,
                y.Idncc,
                y.Idmau,
                y.Idchatlieu,
                y.Idkichthuoc,
                y.Iddegiay
            }).ToList().Join(_ncc.getallSnhacungcap(), x => x.Idncc, y => y.Idncc, (x, y) => new
            {
                STT = Stt++,
                x.Masp,
                x.Tensp,
                x.Soluong,
                x.Giaban,
                x.Trangthai,
                y.Tenncc,
                x.Idmau,
                x.Idchatlieu,
                x.Idkichthuoc,
                x.Iddegiay
            }).ToList();
            dgvDanhSachSanPham.Columns[0].HeaderText = "STT";
            dgvDanhSachSanPham.Columns[1].HeaderText = "Masp";
            dgvDanhSachSanPham.Columns[2].HeaderText = "Tên sản phẩm";
            dgvDanhSachSanPham.Columns[3].HeaderText = "Số lượng";
            dgvDanhSachSanPham.Columns[4].HeaderText = "Giá bán";
            dgvDanhSachSanPham.Columns[5].HeaderText = "Trạng thái";
            dgvDanhSachSanPham.Columns[6].HeaderText = "Nhà cung cấp";
            dgvDanhSachSanPham.Columns[7].HeaderText = "Màu";
            dgvDanhSachSanPham.Columns[8].HeaderText = "Chất liệu";
            dgvDanhSachSanPham.Columns[9].HeaderText = "Kích thước";
            dgvDanhSachSanPham.Columns[10].HeaderText = "Đế giày";

        }
        private void loadhoadonchitiet()
        {


        }

        private void BanHang_Load_1(object sender, EventArgs e)
        {
            _SanphamServices = new();
            _hoadonChiTietServices = new();
            _hoadonService = new();
            _ctsp = new();
            _ncc = new();
            loaddanhsachhoadon();
            loaddanhsachsanpham();
            loadhoadonchitiet();
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
