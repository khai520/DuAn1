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
        HoaDonCTRepo repo = new HoaDonCTRepo();
        List<Hoadon> list = new();
        public List<Hoadon> GetSanphams(List<Hoadon> list1)

        {
            return list = list1;
        }
        public string XulyId()
        {
            string idtam = "";
            for (int i = 0; i <= list.Count(); i++)
            {
                if (i >= 10)
                {
                    idtam = "HD" + i;
                }
                else
                {
                    idtam = "HD" + "0" + i;
                }
                if (list.Where(x => Convert.ToInt32(x.Mahd.Skip(2)) == i).Count() > 0)
                {
                    break;
                }
            }
            return idtam;
        }
        
        public Hoadonct AddHoaDonCT(string idctsp, int slban, decimal gia, DateTime ngayban)
        {
            var hdct = new Hoadonct
            {
                Mahd = XulyId(),
                Idctsp = idctsp,
                Slban = slban,
                Gia = gia,
                Ngayban = ngayban,
            };
            if (AddHoaDonCT2(idctsp,slban,gia,ngayban))
            {
                return hdct;
            }
            else
            {
                return null;
            }
            
        }
        public bool AddHoaDonCT2(string idctsp, int slban, decimal gia, DateTime ngayban)
        {
            return repo.them(AddHoaDonCT(idctsp, slban, gia, ngayban));
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
