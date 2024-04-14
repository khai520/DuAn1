

using MainApp.GUI.VIEW;
using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;
using WinFormsApp1.Services;

namespace Main.DAL.Services
{
    internal class CtSanphamService
    {
        CTSanPhamRepo sanpham = new CTSanPhamRepo();
        NhaCungCapServices ncc = new NhaCungCapServices();
        MauSacService ms = new MauSacService();
        Chatlieuservices cl = new();
        KichThuocService kt = new();
        DeGiayService dg = new();
        List<Ctsanpham> list = new List<Ctsanpham>();
        public List<Ctsanpham> GetallChitietsanpham()
        {
            return list = sanpham.getallSPrepo();
        }
        public string XulyId()
        {
            string idtam = "";
            for (int i = 0; i <= list.Count() + 1; i++)
            {
                if (i >= 10)
                {
                    idtam = "CTSP" + i;
                }
                else
                {
                    idtam = "CTSP" + "0" + i;
                }
                if (list.Where(x => x.Idctsp == idtam).Count() > 0)
                {
                    continue;
                }
            }
            return idtam;
        }
        //public List<Ctsanpham> Change()
        //{
        //    List<Ctsanpham> list2 = new();
        //    foreach (var item in list)
        //    {
        //        list2.Add(Loc(item.Idctsp));
        //    }
        //    return list2;
        //}
        public bool CheckValidate(dynamic Check)
        {
            if (Check == null || Check.Length == 0)
            {
                return true;
            }
            else { return false; }
        }
        public string Them(string? idncc, string? masp, string? mau, string? chatlieu, string? kichthuoc, string? degiay)
        {
            Ctsanpham ctsanpham = new Ctsanpham
            {
                Idctsp = XulyId(),
                Idncc = idncc,
                Masp = masp,
                Idchatlieu = chatlieu,
                Idkichthuoc = kichthuoc,
                Iddegiay = degiay,
                Idmau = mau,
            };
            if (sanpham.them(ctsanpham))
            {
                return "Add thành công";
            }
            else { return "Add không thành công"; }
        }
        public string Sua(string id, string? idncc, string? mau, string? chatlieu, string? kichthuoc, string? degiay)
        {
            Ctsanpham sp = GetallChitietsanpham().Find(x => x.Idctsp == id);
            sp.Idncc = idncc;
            sp.Idmau = mau;
            sp.Idchatlieu = chatlieu;
            sp.Idkichthuoc = kichthuoc;
            sp.Iddegiay = degiay;
            if (sanpham.sua(sp))
            {
                return "Sửa thành công";
            }
            else return "Sửa không thành công";
            
        }

        public string Xoa(string ID)
        {
            Ctsanpham sp = sanpham.getallSPrepo().Find(x => x.Idctsp == ID);
            if (sanpham.xoa(sp))
            {
                return "Xóa thành công";
            }
            else return "Xóa không thành công";
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
        //public Ctsanpham Loc(string id)
        //{

        //    string? nccc;
        //    if (ncc.getallSnhacungcap().Find(x => x.Idncc == list.Find(x => x.Idctsp == id).Idncc) == null)
        //    {
        //        nccc = " ";
        //    }
        //    else
        //    {
        //        nccc = ncc.getallSnhacungcap().Find(x => x.Idncc == list.Find(x => x.Idctsp == id).Idncc).Tenncc.ToString();
        //    }
        //    string? mau;
        //    if (ms.GetallMau().Find(x => x.Idmau == list.Find(x => x.Idctsp == id).Mau) == null)
        //    {
        //        mau = " ";
        //    }
        //    else
        //    {
        //        mau = ms.GetallMau().Find(x => x.Idmau == list.Find(x => x.Idctsp == id).Mau).Mau.ToString();
        //    }
        //    string? chatlieu;
        //    if (cl.Getallchatlieu().Find(x => x.Idchatlieu == list.Find(x => x.Idctsp == id).Chatlieuu) == null)
        //    {
        //        chatlieu = " ";
        //    }
        //    else
        //    {
        //        chatlieu = cl.Getallchatlieu().Find(x => x.Idchatlieu == list.Find(x => x.Idctsp == id).Chatlieuu).Chatlieu1.ToString();
        //    }
        //    string? kichthuoc;
        //    if (kt.Getallkt().Find(x => x.IdKichthuoc == list.Find(x => x.Idctsp == id).Kichthuoc) == null)
        //    {
        //        kichthuoc = " ";
        //    }
        //    else
        //    {
        //        kichthuoc = kt.Getallkt().Find(x => x.IdKichthuoc == list.Find(x => x.Idctsp == id).Kichthuoc).Kichthuoc1.ToString();
        //    }
        //    string? degiay;
        //    if (dg.Getalldegiay().Find(x => x.IdDegiay == list.Find(x => x.Idctsp == id).Degiay) == null)
        //    {
        //       degiay = " ";
        //    }
        //    else
        //    {
        //        degiay = dg.Getalldegiay().Find(x => x.IdDegiay == list.Find(x => x.Idctsp == id).Degiay).Degiay1.ToString();
        //    }



        //    Ctsanpham sP = new Ctsanpham()
        //    {
        //        Idctsp = id,
        //        Idncc = nccc,
        //        Tengiay = list.Find(x => x.Idctsp == list.Find(x => x.Idctsp == id).Idncc).Tengiay.ToString(),
        //        Masp = list.Find(x => x.Idctsp == id).Masp.ToString(),
        //        Mau = mau,
        //        Chatlieuu = chatlieu,
        //        Kichthuoc = kichthuoc,
        //        Degiay = degiay,
        //        Giaban = list.Find(x => x.Idctsp == id).Giaban,

        //    };
        //    return sP;
        //}
        public List<Ctsanpham> Timkiem(string? id, string? name, string? masp, string? mau, string? chatlieu, string? kichthuoc, string? degiay, decimal giaban)
        {
            return GetallChitietsanpham().Where(x => x.Idctsp == id || x.Tengiay == name || x.Masp == masp || x.Idmau == mau || x.Idchatlieu == chatlieu || x.Idkichthuoc == kichthuoc || x.Iddegiay == degiay || x.Giaban == giaban).ToList();
        }
    }
}
