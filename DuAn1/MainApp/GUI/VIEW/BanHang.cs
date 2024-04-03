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

namespace APPBanHang
{
    public partial class BanHang : Form
    {
        //HoadonServices _hoadonService = new();
        //int _idCellClick;
        public BanHang()
        {
            InitializeComponent();
        }
        //private void BanHang_Load(object sender, EventArgs e)
        //{
        //    LoadData(string.Empty, string.Empty);

        //}
        //private void LoadData(string textSearch, string option)
        //{
        //    int STT = 0;
        //    var result = from hd in _hoadonService.GetHoadons()

        //                 select new
        //                 {
        //                     STT = STT++,
        //                     TenSp = hd.Tensp,
        //                     NgayBan = hd.Ngayban,
        //                     SoLuong = hd.Soluong,
        //                     Coupon = hd.Idmagiamgia,
        //                     TongTien = hd.Tongtien,
        //                     TrangThai = hd.Trangthai,

        //                 };

        //    dgvDSHoaDon.DataSource = result.ToList();
        //    dgvDSHoaDon.Columns[0].HeaderText = "STT";
        //    dgvDSHoaDon.Columns[1].HeaderText = "Tên SP";
        //    dgvDSHoaDon.Columns[2].HeaderText = "Ngày Bán";
        //    dgvDSHoaDon.Columns[3].HeaderText = "Số Lượng";
        //    dgvDSHoaDon.Columns[4].HeaderText = "Coupon";
        //    dgvDSHoaDon.Columns[5].HeaderText = "Tổng Tiền";
        //    dgvDSHoaDon.Columns[6].HeaderText = "Trạng Thái";
        //    dgvDSHoaDon.AllowUserToAddRows = false;
        //    dgvDSHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
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
        private void BanHang_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            //int STT = 0;
            //var result = from hd in _hoadonService.GetHoadons()
            //             select hd;
            //LoadData(string.Empty, string.Empty);

        }
        //private void LoadData(string textSearch, string option)
        //{
            //int STT = 0;
            //var result = from hd in _hoadonService.GetHoadons()

            //             select new
            //             {
            //                 STT = STT++,
            //                 TenSp = hd.Tensp,
            //                 NgayBan = hd.Ngayban,
            //                 SoLuong = hd.Soluong,
            //                 Coupon = hd.Idmagiamgia,
            //                 TongTien = hd.Tongtien,
            //                 TrangThai = hd.Trangthai,
            //             };

            //dgvDSHoaDon.DataSource = result.ToList();
            //dgvDSHoaDon.Columns[0].HeaderText = "STT";
            //dgvDSHoaDon.Columns[1].HeaderText = "Tên SP";
            //dgvDSHoaDon.Columns[2].HeaderText = "Ngày Bán";
            //dgvDSHoaDon.Columns[3].HeaderText = "Số Lượng";
            //dgvDSHoaDon.Columns[4].HeaderText = "Coupon";
            //dgvDSHoaDon.Columns[5].HeaderText = "Tổng Tiền";
            //dgvDSHoaDon.Columns[6].HeaderText = "Trạng Thái";
            //dgvDSHoaDon.AllowUserToAddRows = false;
            //dgvDSHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;

        //}

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

        }

        //private void label15_Click(object sender, EventArgs e)
        //{

        //}

        //private void BanHang_Load_1(object sender, EventArgs e)
        //{

        //}
    }
}
