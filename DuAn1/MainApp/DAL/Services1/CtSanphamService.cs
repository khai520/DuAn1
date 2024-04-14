

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
        public bool CheckValidate(dynamic Check)
        {
            if (Check == null || Check.Length == 0)
            {
                return true;
            }
            else { return false; }
        }
        public string Them(dynamic? idncc, string? masp, string? mau, string? chatlieu, string? kichthuoc, string? degiay, string? sl)
        {
            Ctsanpham ctsanpham = new Ctsanpham
            {
                Idctsp = XulyId(),
                Idncc = idncc == null ? null : Convert.ToString(idncc),
                Masp = masp,
                Soluong = Convert.ToInt32(sl),
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
        public string Sua(string id, dynamic? idncc, string? mau, string? chatlieu, string? kichthuoc, string? degiay , string? sl)
        {
            try
            {
                Ctsanpham sp = GetallChitietsanpham().Find(x => x.Idctsp == id);
                sp.Idncc = idncc == null ? null : Convert.ToString(idncc);
                sp.Idmau = mau;
                sp.Idchatlieu = chatlieu;
                sp.Idkichthuoc = kichthuoc;
                sp.Iddegiay = degiay;
                sp.Soluong = Convert.ToInt32(sl);
                if (sanpham.sua(sp))
                {
                    return "Sửa thành công";
                }
                else return "Sửa không thành công";
            }
            catch (Exception)
            {
                return "Sai kiều dữ liệu";
            }
            
            
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
        public void UpdateSL(string id, int sl)
        {
            Ctsanpham sp = list.Find(x => x.Masp == id);
            sp.Soluong = sl;
            sanpham.sua(sp);
        }

    }
}
