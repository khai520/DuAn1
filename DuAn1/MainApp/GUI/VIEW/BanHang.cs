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
using Main.BLL.Models2;
using WinFormsApp1.Services;

namespace APPBanHang
{
    public partial class BanHang : Form
    {
        HoadonServices _hoadonService = new();
        SanphamServices SanphamServices = new();
        HoaDonChiTietServices _hoadonChiTietServices = new();
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
            TrangChu trangChu = new TrangChu();
            this.Hide();
            trangChu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanPham sanpham = new SanPham();
            this.Hide();
            sanpham.Show();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            this.Hide();
            nhanvien.Show();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            this.Hide();
            khachHang.Show();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher();
            this.Hide();
            voucher.Show();
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
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            this.Hide();
            khachHang.Show();
            this.Close();
        }

        private void btnTimSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            SanPham sanpham = new SanPham();
            this.Hide();
            sanpham.Show();
            this.Close();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            this.Hide();
            khachHang.Show();
            this.Close();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher();
            this.Hide();
            voucher.Show();
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
            List<Sanpham> sanphams = SanphamServices.GetSanphams();
            dgvDanhSachSanPham.DataSource = sanphams;
            DataGridViewTextBoxColumn sttColumns = new DataGridViewTextBoxColumn();
            sttColumns.HeaderText = "STT";
            sttColumns.Name = "sttColumn";
            dgvDanhSachSanPham.Columns.Insert(0, sttColumns);


            for (int i = 0; i < dgvDanhSachSanPham.Rows.Count; i++)
            {
                dgvDanhSachSanPham.Rows[i].Cells["sttColumn"].Value = (i + 1).ToString();
            }

            dgvDanhSachSanPham.Columns[6].Visible = false;
            dgvDanhSachSanPham.EditMode = DataGridViewEditMode.EditProgrammatically;



        }
        private void loadhoadonchitiet()
        {
            List<Hoadonct> hoadoncts = _hoadonChiTietServices.GetHoaDonCT();
            dgvHoaDonChiTiet.DataSource = hoadoncts;
            DataGridViewTextBoxColumn sttColumna = new DataGridViewTextBoxColumn();
            sttColumna.HeaderText = "STT";
            sttColumna.Name = "sttColumn";
            dgvHoaDonChiTiet.Columns.Insert(0, sttColumna);


            for (int i = 0; i < dgvHoaDonChiTiet.Rows.Count; i++)
            {
                dgvHoaDonChiTiet.Rows[i].Cells["sttColumn"].Value = (i + 1).ToString();
            }
            dgvHoaDonChiTiet.Columns[6].Visible = false;
            dgvHoaDonChiTiet.Columns[7].Visible = false;
            dgvDanhSachSanPham.EditMode = DataGridViewEditMode.EditProgrammatically;







        }

        private void BanHang_Load_1(object sender, EventArgs e)
        {
            loaddanhsachhoadon();
            loaddanhsachsanpham();
            loadhoadonchitiet();
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {

        }
    }
}
