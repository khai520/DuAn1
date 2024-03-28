using Main.BLL.Models2;
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
    

        public List<Ctsanpham> GetallChitietsanpham()
        {
            return sanpham.getallSPrepo().ToList();
        }

        public bool Them(string id, string name)
        {
            Ctsanpham ctsanpham = new Ctsanpham
            {
                Idctsp = id,
                Tengiay = name,
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
    }
}
