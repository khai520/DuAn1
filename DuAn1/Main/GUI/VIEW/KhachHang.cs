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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu trangChu = new TrangChu();
            trangChu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            SanPham sanpham = new SanPham();
            sanpham.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            NhanVien nhanvien = new NhanVien();
            nhanvien.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            HoaDon hoadon = new HoaDon();
            hoadon.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
