﻿using System;
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            //HoaDon hoadon = new HoaDon();
            //hoadon.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            this.Close();
        }
        private void button_Click_Voucher(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher();
            this.Hide();
            voucher.Show();
            this.Close();
        }
        private void button_Click_BanHang(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang();
            this.Hide();
            banHang.Show();
            this.Close();
        }
    }
}
