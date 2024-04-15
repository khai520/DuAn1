
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
    internal class HoadonServices
    {
        HoaDonRepo repo = new HoaDonRepo();
        List<Hoadon> list = new List<Hoadon>();


        public List<Hoadon> GetHoadons()
        {
            return list = repo.getallSPrepo();
        }
        public bool CheckValidate(dynamic Check)
        {
            if (Check == null || Check.Length == 0)
            {
                return true;
            }
            else { return false; }
        }

        public string XulyId()
        {
            string idtam = "";
            for (int i = 1; i <= list.Count() + 1; i++)
            {
                if (i >= 10)
                {
                    idtam = "HD" + i;
                }
                else
                {
                    idtam = "HD" + "0" + i;
                }
                if (list.Where(x => x.Mahd == idtam).Count() > 0)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            return idtam;
        }

        public string AddHoaDon()
        {

            Hoadon hoadon = new Hoadon
            {
                Mahd = XulyId(),
                Ngayban = DateTime.Now.Date,
                Trangthai = "CHUA TT",
            };
            if (repo.them(hoadon))
            {
                return "Add thành công";
            }
            else return "Add không thành";
            
        }
        public void UpdateHoaDon(string idhoadon, string idkh, string idnguoidung, string idmgg, DateTime ngayban, string tensanpham, int soluong, int tongtien, string trangthai)
        {
            Hoadon hoadon = GetHoadons().Find(x => x.Mahd == idhoadon);
            hoadon.Idkh = idkh;
            hoadon.IdnguoiDung = idnguoidung;
            hoadon.Idmagiamgia = idmgg;
            hoadon.Ngayban = ngayban;
            hoadon.Tensp = tensanpham;
            hoadon.Soluong = soluong;
            hoadon.Tongtien = tongtien;
            hoadon.Trangthai = trangthai;
            repo.sua(hoadon);
        }
        public void UpdateGia(string mahd , long gia)
        {
            Hoadon hoadon = GetHoadons().Find(x => x.Mahd == mahd);
            hoadon.Tongtien = Convert.ToInt32(gia);
            repo.sua(hoadon);
        }
        public void UpdateTT(string mahd)
        {
            Hoadon hoadon = GetHoadons().Find(x => x.Mahd == mahd);
            hoadon.Trangthai = "Đã TT";
            repo.sua(hoadon);
        }
        public void Delete(string id)
        {
            Hoadon hoadon = GetHoadons().Find(x => x.Mahd == id);
            repo.xoa(hoadon);
        }

    }
}
