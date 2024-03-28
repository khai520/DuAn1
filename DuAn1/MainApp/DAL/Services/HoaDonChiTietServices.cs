using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace Main.DAL.Services
{
    internal class HoaDonChiTietServices
    {
        HoaDonCTRepo repo =  new HoaDonCTRepo();
        public bool AddHoaDonCT(string idctsp, int slban, decimal gia, DateTime ngayban)
        {
            var hdct = new Hoadonct
            {
                Idctsp = idctsp,
                Slban = slban,
                Gia = gia,
                Ngayban = ngayban,
            };
            return repo.them(hdct);
        }
        public bool UpdateHoaDonCT(string idhdct,string idctsp, int slban, decimal gia, DateTime ngayban)
        {
            Hoadonct hoadonct = new Hoadonct
            {
                Mahd = idhdct,
                Slban = slban,
                Idctsp = idctsp,
                Gia = gia,
                Ngayban = ngayban
            };
            return repo.sua(idhdct, hoadonct);
        }
        public bool XoaHDCT(string idhdct)
        {
            return repo.xoa(idhdct);
        }
        public List<Hoadonct> FindHoaDonct(string idkh)
        {
            return repo.FindhoadonByid(idkh).ToList();
        }
    }
}
