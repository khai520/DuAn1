using APPBanHang;
using Main.DAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Services;

namespace MainApp.GUI.VIEW
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

        }
        private void button_Click_BanHang(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang();
            this.Hide();
            banHang.Show();
            this.Close();
        }
        public void Timkiem(string? tengiay, string? tenHang, string? Mau, string? chatlieu, string? kichthuoc, string? deGiay)
        {
            //CtSanphamService spser = new CtSanphamService();
            //NhaCungCapServices nc = new();
            //MauSacService ms = new();
            //Chatlieuservices cl = new();
            //KichThuocService kt = new();
            //DeGiayService dg = new();
            //var timKiem = spser.GetallChitietsanpham()
            //    .Join(nc.getallSnhacungcap(), x => x.Idncc, y => y.Idncc, (x, y) => new { x.Tengiay, y.Tenncc, x.Mau, x.Chatlieuu, x.Kichthuoc, x.Degiay })
            //    .Join(cl.Getallchatlieu(), x => x.Chatlieuu, y => y.Idchatlieu, (x, y) => new { x.Tengiay, x.Tenncc, x.Mau, y.Chatlieu1, x.Kichthuoc, x.Degiay })
            //    .Join(ms.GetallMau(), x => x.Mau, y => y.Idmau, (x, y) => new { x.Tengiay, x.Tenncc, y.Mau, x.Chatlieu1, x.Kichthuoc, x.Degiay })
            //    .Join(kt.Getallkt(), x => x.Kichthuoc, y => y.IdKichthuoc, (x, y) => new { x.Tengiay, x.Tenncc, x.Mau, x.Chatlieu1, y.Kichthuoc1, x.Degiay })
            //    .Join(dg.Getalldegiay(), x => x.Degiay, y => y.IdDegiay, (x, y) => new { x.Tengiay, x.Tenncc, x.Mau, x.Chatlieu1, x.Kichthuoc1, y.Degiay1 });
            //if (tengiay != null)
            //{
            //    timKiem = timKiem.Where(x => x.Tengiay.Contains(tengiay)).ToList();
            //}
            //if (tenHang != null)
            //{

            //    timKiem = timKiem.Where(x => x.Tenncc.Contains(tenHang)).ToList();
            //}
            //if (Mau != null)
            //{
            //    timKiem = timKiem.Where(x => x.Mau.Contains(Mau)).ToList();
            //}
            //if (chatlieu != null)
            //{
            //    timKiem = timKiem.Where(x => x.Chatlieu1.Contains(chatlieu)).ToList();
            //}
            //if (kichthuoc != null)
            //{
            //    timKiem = timKiem.Where(x => x.Kichthuoc1.Contains(kichthuoc)).ToList();
            //}
            //if (deGiay != null)
            //{
            //    timKiem = timKiem.Where(x => x.Degiay1.Contains(deGiay)).ToList();
            //}
        }
    }
}
