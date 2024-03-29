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
        HoadonServices _hoadonService = new();
<<<<<<< HEAD
=======
        int _idCellClick;

>>>>>>> 6b350488ca77575b449486aab61f88d5dffb3ba2
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
        private void BanHang_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            LoadData();

        }
        private void LoadData()
        {
            int STT = 0;
            var result = from hd in _hoadonService.GetHoadons()

=======
            LoadData(string.Empty, string.Empty);

        }
        private void LoadData(string textSearch, string option)
        {
            int STT = 0;
            var result = from hd in _hoadonService.GetHoadons()
                         
>>>>>>> 6b350488ca77575b449486aab61f88d5dffb3ba2
                         select new
                         {
                             STT = STT++,
                             TenSp = hd.Tensp,
                             NgayBan = hd.Ngayban,
                             SoLuong = hd.Soluong,
                             Coupon = hd.Idmagiamgia,
                             TongTien = hd.Tongtien,
<<<<<<< HEAD
                             TrangThai = hd.Trangthai,
=======
                             TrangThai=hd.Trangthai,
>>>>>>> 6b350488ca77575b449486aab61f88d5dffb3ba2

                         };

            dgvDSHoaDon.DataSource = result.ToList();
            dgvDSHoaDon.Columns[0].HeaderText = "STT";
            dgvDSHoaDon.Columns[1].HeaderText = "Tên SP";
            dgvDSHoaDon.Columns[2].HeaderText = "Ngày Bán";
            dgvDSHoaDon.Columns[3].HeaderText = "Số Lượng";
            dgvDSHoaDon.Columns[4].HeaderText = "Coupon";
            dgvDSHoaDon.Columns[5].HeaderText = "Tổng Tiền";
            dgvDSHoaDon.Columns[6].HeaderText = "Trạng Thái";
            dgvDSHoaDon.AllowUserToAddRows = false;
            dgvDSHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
<<<<<<< HEAD





        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
=======
>>>>>>> 6b350488ca77575b449486aab61f88d5dffb3ba2

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
