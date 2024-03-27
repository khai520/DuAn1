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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrangChu trangchu = new TrangChu();
            trangchu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanPham sanpham = new SanPham();
            sanpham.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HoaDon hoadon = new HoaDon();
            hoadon.Show();
        }
    }
}
