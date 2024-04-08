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
using MainApp.GUI.VIEW;

namespace APPBanHang
{
    public partial class SanPham : Form
    {
        SanphamServices _sanphamService = new();
        string id;
        public SanPham()
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
            //HoaDon hoadon = new HoaDon();
            //hoadon.Show();
        }
        private void button_Click_Voucher(object sender, EventArgs e)
        {
            this.Hide();

            Voucher voucher = new Voucher();
            voucher.ShowDialog();
            this.Close();
        }
        private void button_Click_BanHang(object sender, EventArgs e)
        {
            this.Hide();

            BanHang banHang = new BanHang();
            banHang.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();

            SanPham sanPham = new SanPham();
            sanPham.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login loGin = new Login();
            loGin.ShowDialog();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            //var result = from sp in _sanphamService
            int Stt = 1;
            dgvDanhSachSanPham.DataSource = _sanphamService.GetSanphams().Select(x => new
            {
                STT = Stt++,
                x.Masp,
                x.Tensp,
                x.Soluong,
                x.Giaban,
                x.Trangthai
            }).ToList();
            dgvDanhSachSanPham.Columns[0].HeaderText = "STT";
            dgvDanhSachSanPham.Columns[1].HeaderText = "Masp";
            dgvDanhSachSanPham.Columns[2].HeaderText = "Tên sản phẩm";
            dgvDanhSachSanPham.Columns[3].HeaderText = "Số lượng";
            dgvDanhSachSanPham.Columns[4].HeaderText = "Giá bán";
            dgvDanhSachSanPham.Columns[5].HeaderText = "Trạng thái";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
            chiTietSanPham.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ThongTinNhaCungCap ttncc = new ThongTinNhaCungCap();
            ttncc.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangchu = new TrangChu();
            trangchu.ShowDialog();
            this.Close();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang kh = new KhachHang();
            kh.ShowDialog();
            this.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien nhan = new NhanVien();
            nhan.ShowDialog();
            this.Close();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_sanphamService.AddSP(txtTenSP.Text, txtSoLuongTon.Text, txtGiaBan.Text, cbxTrangThai.Text));
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_sanphamService.XoaSp(id));
            LoadData();
        }

        private void dgvDanhSachSanPham_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            id = dgvDanhSachSanPham.Rows[d].Cells[1].Value.ToString();
            txtTenSP.Text = dgvDanhSachSanPham.Rows[d].Cells[2].Value.ToString();
            txtSoLuongTon.Text = dgvDanhSachSanPham.Rows[d].Cells[3].Value.ToString();
            txtGiaBan.Text = dgvDanhSachSanPham.Rows[d].Cells[4].Value.ToString();
            cbxTrangThai.Text = dgvDanhSachSanPham.Rows[d].Cells[5].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_sanphamService.UpdateSP(id, txtTenSP.Text, txtSoLuongTon.Text, txtGiaBan.Text, cbxTrangThai.Text));
            LoadData();
        }
    }
}
