using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;
using WinFormsApp1.Services;

namespace Main.DAL.Services
{
    //internal class HoadonServices
    //{
    //    //HoaDonRepo repo = new HoaDonRepo();
    //    //public List<Hoadon> GetHoadons()
    //    //{
    //    //    return repo.getallSPrepo().ToList();
    //    //}
    //    //public bool AddHoaDon(string idkh, string idnguoidung, string idmgg, DateTime ngayban, string tensanpham, int soluong, decimal tongtien, string trangthai , string idhdct, string idctsp, int slban, decimal gia, DateTime ngayban2)
    //    //{
    //    //    HoaDonChiTietServices hoaDonChiTietServices = new();
    //    //    Hoadonct hoadonct = new();
    //    //    hoadonct = hoaDonChiTietServices.AddHoaDonCT(  idctsp,  slban, gia,ngayban2);
    //    //    var hoadon = new Hoadon
    //    //    {
    //    //        Mahd = hoadonct.Mahd,
    //    //        Idkh = idkh,
    //    //        IdnguoiDung = idnguoidung,
    //    //        Idmagiamgia = idmgg,
    //    //        Ngayban = ngayban,
    //    //        Tensp = tensanpham,
    //    //        Soluong = soluong,
    //    //        Tongtien = tongtien,
    //    //        Trangthai = trangthai
    //    //    };

           
    //    //    return true;
    //    //}
    //    //public bool UpdateHoaDon(string idhoadon, string idkh, string idnguoidung, string idmgg, DateTime ngayban, string tensanpham, int soluong, decimal tongtien, string trangthai)
    //    //{
    //    //    Hoadon hoadon = new Hoadon
    //    //    {
    //    //        Mahd = idhoadon,
    //    //        Idkh = idkh,
    //    //        IdnguoiDung = idnguoidung,
    //    //        Idmagiamgia = idmgg,
    //    //        Ngayban = ngayban,
    //    //        Tensp = tensanpham,
    //    //        Soluong = soluong,
    //    //        Tongtien = tongtien,
    //    //        Trangthai = trangthai
    //    //    };
    //    //    return repo.sua(idhoadon, hoadon);
    //    //}
    //    //public bool XoaHoaDon(string id)
    //    //{
    //    //    return repo.xoa(id);
    //    //}
    //    //public List<Hoadon> FindHoaDon(string idhd)
    //    //{
    //    //    return repo.FindhoadonByid(idhd).ToList();
    //    //}
    //    //public void Timkiem(string? tengiay, string? tenHang, string? Mau, string? chatlieu, string? kichthuoc, string? deGiay)
    //    //{
    //    //    CtSanphamService spser = new();
    //    //    NhaCungCapServices nc = new();
    //    //    MauSacService ms = new();
    //    //    Chatlieuservices cl = new();
    //    //    KichThuocService kt = new();
    //    //    DeGiayService dg = new();
    //    //    var timKiem = spser.GetallChitietsanpham()
    //    //        .Join(nc.getallSnhacungcap(), x => x.Idncc, y => y.Idncc, (x, y) => new { x.Tengiay, y.Tenncc, x.Mau, x.Chatlieuu, x.Kichthuoc, x.Degiay })
    //    //        .Join(cl.Getallchatlieu(), x => x.Chatlieuu, y => y.Idchatlieu, (x, y) => new { x.Tengiay, x.Tenncc, x.Mau, y.Chatlieu1, x.Kichthuoc, x.Degiay })
    //    //        .Join(ms.GetallMau(), x => x.Mau, y => y.Idmau, (x, y) => new { x.Tengiay, x.Tenncc, y.Mau, x.Chatlieu1, x.Kichthuoc, x.Degiay })
    //    //        .Join(kt.Getallkt(), x => x.Kichthuoc, y => y.IdKichthuoc, (x, y) => new { x.Tengiay, x.Tenncc, x.Mau, x.Chatlieu1, y.Kichthuoc1, x.Degiay })
    //    //        .Join(dg.Getalldegiay(), x => x.Degiay, y => y.IdDegiay, (x, y) => new { x.Tengiay, x.Tenncc, x.Mau, x.Chatlieu1, x.Kichthuoc1, y.Degiay1 });
    //    //    if (tengiay != null)
    //    //    {
    //    //        timKiem = timKiem.Where(x => x.Tengiay.Contains(tengiay)).ToList();
    //    //    }
    //    //    if (tenHang != null)
    //    //    {

    //    //        timKiem = timKiem.Where(x => x.Tenncc.Contains(tenHang)).ToList();
    //    //    }
    //    //    if (Mau != null)
    //    //    {
    //    //        timKiem = timKiem.Where(x => x.Mau.Contains(Mau)).ToList();
    //    //    }
    //    //    if (chatlieu != null)
    //    //    {
    //    //        timKiem = timKiem.Where(x => x.Chatlieu1.Contains(chatlieu)).ToList();
    //    //    }
    //    //    if (kichthuoc != null)
    //    //    {
    //    //        timKiem = timKiem.Where(x => x.Kichthuoc1.Contains(kichthuoc)).ToList();
    //    //    }
    //    //    if (deGiay != null)
    //    //    {
    //    //        timKiem = timKiem.Where(x => x.Degiay1.Contains(deGiay)).ToList();
    //    //    }
    //    //}
    //}
}
