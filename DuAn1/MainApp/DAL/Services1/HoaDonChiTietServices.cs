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
        public List<Hoadonct> GetHoaDonCT()

        {
            return list = repo.getallHoaDonrepo();
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

        public Hoadonct AddHoaDonCT(string idctsp, int slban, decimal gia, DateTime ngayban)
        {
            if (CheckValidate(idctsp) || CheckValidate(slban) || CheckValidate(gia) || CheckValidate(ngayban))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return null;
            }
            else
            {
                Hoadonct hdct = new Hoadonct
                {
                    Mahd = XulyId(),
                    Idctsp = idctsp,
                    Slban = slban,
                    Gia = gia,
                    Ngayban = ngayban,
                };
                return hdct;
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
                
                Mahd = id ,
                Idctsp = list.Find(x=>x.Mahd == id).Idctsp.ToString(),
                Slban = list.Find(x => x.Mahd == id).Slban.Value,
                Gia = list.Find(x => x.Mahd == id).Gia.Value,
                Ngayban = list.Find(x => x.Mahd == id).Ngayban.Value


            };
            return sP;
        }

        public List<Hoadonct> Timkiem(string? id, string? idctsp, int? slban, decimal? gia, DateTime? ngayban)
        {
            if (id == null && idctsp == null && slban == null && gia == null && ngayban == null)
            {
                MessageBox.Show("Chưa nhập thông tin để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
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
        }
        public bool AddHoaDonCT2(string idctsp, int slban, decimal gia, DateTime ngayban)
        {
            return repo.them(AddHoaDonCT(idctsp, slban, gia, ngayban));
        }
        public bool UpdateHoaDonCT(string idhdct, string idctsp, int slban, decimal gia, DateTime ngayban)
        {
            if (CheckValidate(idctsp) || CheckValidate(slban) || CheckValidate(gia) || CheckValidate(ngayban))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
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
