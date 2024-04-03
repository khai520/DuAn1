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
        List<Hoadonct> list = new();
        public List<Hoadonct> GetSanphams(List<Hoadonct> list1)

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
        public List<Hoadonct> Change()
        {
            List<Hoadonct> list2 = new();
            foreach (var item in list)
            {
                list2.Add(Loc(item.Mahd));
            }
            return list2;
        }
        public Hoadonct Loc(string id)
        {
            Hoadonct sP = new Hoadonct()
            {
                //Idctsp = id,
                //Tengiay = list.Find(x => x.Idctsp == id).Tengiay.ToString(),
                //Masp = list.Find(x => x.Idctsp == id).Masp.ToString(),
                //Mau = ms.GetallMau().Find(x => x.Idmau == list.Find(x => x.Idctsp == id).Mau).Mau.ToString(),
                //Chatlieuu = cl.Getallchatlieu().Find(x => x.Idchatlieu == list.Find(x => x.Idctsp == id).Chatlieuu).Chatlieu1.ToString(),
                //Kichthuoc = kt.Getallkt().Find(x => x.IdKichthuoc == list.Find(x => x.Idctsp == id).Kichthuoc).Kichthuoc1.ToString(),
                //Degiay = dg.Getalldegiay().Find(x => x.IdDegiay == list.Find(x => x.Idctsp == id).Degiay).Degiay1.ToString(),
                //Giaban = list.Find(x => x.Idctsp == id).Giaban,
                Mahd = id ,
                Idctsp = list.Find(x=>x.Mahd == id).Idctsp.ToString(),
                Slban = list.Find(x => x.Mahd == id).Slban.Value,
                Gia = list.Find(x => x.Mahd == id).Gia.Value,
                Ngayban = list.Find(x => x.Mahd == id).Ngayban.Value


            };
            return sP;
        }

        public List<Hoadonct> Timkiem(string? id, string? idctsp, int? slban, decimal? gia,DateTime? ngayban)
        {
            var ds = Change().Where(x => x.Mahd == id || x.Idctsp == idctsp || x.Slban == slban || x.Gia == gia || x.Ngayban == ngayban);
            List<Hoadonct> listAdd = new();
            if (ds.Count() > 0)
            {
                foreach (var item in ds)
                {
                    listAdd.Add(Loc(item.Mahd));
                }
            }
            else
            {
                listAdd = list;
            }
            return listAdd;
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
