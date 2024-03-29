using Main.BLL.Models2;
using MainApp.GUI.VIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace Main.DAL.Services
{
    internal class CtSanphamService
    {
        CTSanPhamRepo sanpham = new CTSanPhamRepo();
        MauSacService ms = new();
        Chatlieuservices cl = new();
        KichThuocService kt = new();
        DeGiayService dg = new();
        List<Ctsanpham> list = new List<Ctsanpham>();
        public List<Ctsanpham> GetallChitietsanpham(List<Ctsanpham> list1)
        {
            return list = list1;
        }
        public List<Ctsanpham> Change()
        {
            List<Ctsanpham> list2 = new();
            foreach (var item in list)
            {
                list2.Add(Loc(item.Idctsp));
            }
            return list2;
        }
        public bool Them(string id, string name, string masp, string mau, string chatlieu, string kichthuoc, string degiay, decimal giaban)
        {
            Ctsanpham ctsanpham = new Ctsanpham
            {
                Idctsp = id,
                Tengiay = name,
                Masp = masp,
                Chatlieuu = chatlieu,
                Kichthuoc = kichthuoc,
                Degiay = degiay,
                Mau = mau,
                Giaban = giaban
            };
            return true;
        }
        public bool Sua(string id, string name, string masp, string mau, string chatlieu, string kichthuoc, string degiay, decimal giaban)
        {
            Ctsanpham ctsanpham = new Ctsanpham
            {
                Idctsp = id,
                Tengiay = name,
                Masp = masp,
                Chatlieuu = chatlieu,
                Kichthuoc = kichthuoc,
                Degiay = degiay,
                Mau = mau,
                Giaban = giaban
            };
            return sanpham.sua(id, ctsanpham);

        }

        public bool Xoa(string ID)
        {
            return true;
        }

        public List<Ctsanpham> FindCTSPByName(string name)
        {
            return sanpham.FindSvByName(name).ToList();
        }
        public List<Ctsanpham> SortByName()
        {
            List<Ctsanpham> sanphamSoft = sanpham.getallSPrepo().ToList();
            sanphamSoft.Sort((x, y) => x.Tengiay.CompareTo(x.Tengiay));
            return sanphamSoft;
        }
        public Ctsanpham Loc(string id)
        {
            Ctsanpham sP = new Ctsanpham()
            {
                Idctsp = id,
                Tengiay = list.Find(x => x.Idctsp == id).Tengiay.ToString(),
                Masp = list.Find(x => x.Idctsp == id).Masp.ToString(),
                Mau = ms.GetallMau().Find(x => x.Idmau == list.Find(x => x.Idctsp == id).Mau).Mau.ToString(),
                Chatlieuu = cl.Getallchatlieu().Find(x => x.Idchatlieu == list.Find(x => x.Idctsp == id).Chatlieuu).Chatlieu1.ToString(),
                Kichthuoc = kt.Getallkt().Find(x => x.IdKichthuoc == list.Find(x => x.Idctsp == id).Kichthuoc).Kichthuoc1.ToString(),
                Degiay = dg.Getalldegiay().Find(x => x.IdDegiay == list.Find(x => x.Idctsp == id).Degiay).Degiay1.ToString(),
                Giaban = list.Find(x => x.Idctsp == id).Giaban,
            };
            return sP;
        }
        public List<Ctsanpham> Timkiem(string? id, string? name, string? masp, string? mau, string? chatlieu, string? kichthuoc, string? degiay, decimal giaban)
        {
            var ds = Change().Where(x => x.Idctsp == id || x.Tengiay == name || x.Masp == masp || x.Mau == mau || x.Chatlieuu == chatlieu || x.Kichthuoc == kichthuoc || x.Degiay == degiay || x.Giaban == giaban);
            List<Ctsanpham> listAdd = new();
            if (ds.Count() > 0)
            {
                foreach (var item in ds)
                {
                    listAdd.Add(Loc(item.Idctsp));
                }
            }
            else
            {
                listAdd = list;
            }
            return listAdd;
        }
    }
}
