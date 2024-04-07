using Main.BLL.Models2;
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
        KhachHangService khachHangService = new KhachHangService();
        NguoiDungServices nguoiDungServices = new NguoiDungServices();
        MaGiamGiaServices ma = new MaGiamGiaServices();

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
        public List<Hoadon> Change()
        {
            List<Hoadon> list2 = new();
            GetHoadons();
            foreach (var item in list)
            {
                list2.Add(Loc(item.Mahd));
            }
            return list2;
        }
        public bool AddHoaDon(string idkh, string idnguoidung, string idmgg, DateTime ngayban, string tensanpham, int soluong, decimal tongtien, string trangthai, string idhdct, string idctsp, int slban, decimal gia)
        {
            HoaDonChiTietServices hoaDonChiTietServices = new();
            Hoadonct hoadonct = new();
            if (CheckValidate(idkh) || CheckValidate(idnguoidung) || CheckValidate(ngayban) || CheckValidate(tensanpham) || CheckValidate(soluong) || CheckValidate(tongtien) || CheckValidate(trangthai) || CheckValidate(idhdct) || CheckValidate(idctsp) || CheckValidate(slban) || CheckValidate(gia))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
            {
                hoadonct = hoaDonChiTietServices.AddHoaDonCT(idctsp, slban, gia, ngayban);
                var hoadon = new Hoadon
                {
                    Mahd = XulyId(),
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

        }
        public bool UpdateHoaDon(string idhoadon, string idkh, string idnguoidung, string idmgg, DateTime ngayban, string tensanpham, int soluong, decimal tongtien, string trangthai)
        {
            if (CheckValidate(idhoadon) || CheckValidate(idkh) || CheckValidate(idnguoidung) || CheckValidate(ngayban) || CheckValidate(tensanpham) || CheckValidate(tongtien) || CheckValidate(trangthai) || CheckValidate(soluong))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
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

        }

        public Hoadon Loc(string id)
        {
            string? kh ;
            if (khachHangService.Getallkh().Find(x => x.Idkh == list.Find(x => x.Mahd == id).Idkh) == null)  
            {
                kh = " ";
            }
            else
            {
                kh = khachHangService.Getallkh().Find(x => x.Idkh == list.Find(x => x.Mahd == id).Idkh).Ten.ToString();
            }
            string? nd;
            if (nguoiDungServices.GetallND().Find(x => x.IdnguoiDung == list.Find(x => x.Mahd == id).IdnguoiDung) == null)
            {
                nd = " ";
            }
            else
            {
                nd = nguoiDungServices.GetallND().Find(x => x.IdnguoiDung == list.Find(x => x.Mahd == id).IdnguoiDung).Ten.ToString();
            }
            string? magg ;
            if (ma.Getallmagiam().Find(x => x.Idmagiamgia == list.Find(x => x.Mahd == id).Idmagiamgia) == null)
            {
                magg = " ";
            }
            else
            {
                magg = ma.Getallmagiam().Find(x => x.Idmagiamgia == list.Find(x => x.Mahd == id).Idmagiamgia).Tenma.ToString();
            }
            Hoadon hoadon = new Hoadon()
            {
                Mahd = id,
                Idkh = kh,
                IdnguoiDung = nd,
                Idmagiamgia = magg,
                Ngayban = list.Find(x => x.Mahd == id).Ngayban.Value,
                Tensp = list.Find(x => x.Mahd == id).Tensp.ToString(),
                Soluong = list.Find(x => x.Mahd == id).Soluong.Value,
                Tongtien = list.Find(x => x.Mahd == id).Tongtien.Value,
                Trangthai = list.Find(x => x.Mahd == id).Trangthai.ToString()

            };
            return hoadon;
        }
        public List<Hoadon> Timkiem(string? id, string? idkh, string? idngdung, string? idmagiamgia, DateTime? ngayban, string? tensp, int? soluong, decimal? tongtien, string? trangthai)
        {
            if (id == null && idkh == null && idngdung == null && idmagiamgia == null && ngayban == null && tensp == null && soluong == null && tongtien == null && trangthai == null)
            {
                MessageBox.Show("Chưa nhập thông tin để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
            {
                var ds = Change().Where(x => x.Mahd == id || x.Idkh == idkh || x.IdnguoiDung == idngdung || x.Idmagiamgia == idmagiamgia || x.Ngayban == ngayban || x.Tensp == tensp || x.Soluong == soluong || x.Tongtien == tongtien || x.Trangthai == trangthai);
                List<Hoadon> listAdd = new();
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
        }

    }
}
