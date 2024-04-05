﻿using System;
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
            TrangChu trangChu = new TrangChu();
            this.Hide();
            trangChu.Show();
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
            //HoaDon hoadon = new HoaDon();
            //hoadon.Show();
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
            SanPham sanPham = new SanPham();
            this.Hide();
            sanPham.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login loGin = new Login();
            this.Hide();
            loGin.Show();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            //var result = from sp in _sanphamService

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
    }
}
