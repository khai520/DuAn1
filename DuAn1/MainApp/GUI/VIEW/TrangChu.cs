using MainApp.GUI.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPBanHang
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            //HoaDon hoaDon = new HoaDon();
            //hoaDon.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();
            this.Close();
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
        private void button_Click_TimHoaDon(object sender, EventArgs e)
        {
            this.Hide();

            TimKiemHoaDon timKiemHoaDon = new();
            timKiemHoaDon.ShowDialog();
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }
    }
}
