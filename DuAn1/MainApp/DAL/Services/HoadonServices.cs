using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace Main.DAL.Services
{
    internal class HoadonServices
    {
        HoaDonRepo repo = new HoaDonRepo();
        public List<Hoadon> GetHoadons()
        {
            return repo.getallSPrepo().ToList();
        }
        public bool AddHoaDon(string idkh, string idnguoidung, string idmgg, DateTime ngayban, string tensanpham, int soluong, decimal tongtien, string trangthai)
        {
            var hoadon = new Hoadon
            {
                Idkh = idkh,
                IdnguoiDung = idnguoidung,
                Idmagiamgia = idmgg,
                Ngayban = ngayban,
                Tensp = tensanpham,
                Soluong = soluong,
                Tongtien = tongtien,
                Trangthai = trangthai
            };
            return true;
        }
        public bool UpdateHoaDon(string idhoadon, string idkh, string idnguoidung, string idmgg, DateTime ngayban, string tensanpham, int soluong, decimal tongtien, string trangthai)
        {
            Hoadon hoadon = new Hoadon
            {
                Mahd = idhoadon,
                Idkh = idkh,
                IdnguoiDung = idnguoidung,
                Idmagiamgia = idmgg,
                Ngayban = ngayban,
                Tensp = tensanpham,
                Soluong = soluong,
                Tongtien = tongtien,
                Trangthai = trangthai
            };
            return repo.sua(idhoadon, hoadon);
        }
        public bool XoaHoaDon(string id)
        {
            return repo.xoa(id);
        }
        public List<Hoadon> FindHoaDon(string idhd)
        {
            return repo.FindhoadonByid(idhd).ToList();
        }

    }
}
