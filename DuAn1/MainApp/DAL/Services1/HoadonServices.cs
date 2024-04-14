
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
            for (int i = 0; i <= list.Count() + 1; i++)
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

        public void AddHoaDon(string idnguoidung)
        {
            HoaDonChiTietServices hoaDonChiTietServices = new();
            Hoadonct hoadonct = new();
            if ( CheckValidate(idnguoidung)  )
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
            }
            else
            {
                var hoadon = new Hoadon
                {
                    Mahd = XulyId(),
                    Ngayban = DateTime.Now.Date,

                };
            }

        }
        public bool UpdateHoaDon(string idhoadon, string idkh, string idnguoidung, string idmgg, DateTime ngayban, string tensanpham, int soluong, int tongtien, string trangthai)
        {
            if (CheckValidate(idhoadon) || CheckValidate(idkh) || CheckValidate(idnguoidung) || CheckValidate(ngayban) || CheckValidate(tensanpham) || CheckValidate(tongtien) || CheckValidate(trangthai) || CheckValidate(soluong))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
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
                return repo.sua(hoadon);
            }

        }
        public void UpdateGia(string mahd , long gia)
        {
            Hoadon hoadon = GetHoadons().Find(x => x.Mahd == mahd);
            hoadon.Tongtien = Convert.ToInt32(gia);
            repo.sua(hoadon);
        }

    }
}
