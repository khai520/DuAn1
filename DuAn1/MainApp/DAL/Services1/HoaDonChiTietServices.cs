
using MainApp.Models;
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
            for (int i = 0; i <= list.Count() + 1; i++)
            {
                if (i >= 10)
                {
                    idtam = "HDCT" + i;
                }
                else
                {
                    idtam = "HDCT" + "0" + i;
                }
                if (list.Where(x => x.Mahdct.Skip(4) == idtam).Count() > 0)
                {
                    continue;
                }
            }
            return idtam;
        }

        public string AddHoaDonCT( string mahd, string masp, int slban, string gia)
        {
                Hoadonct hdct = new Hoadonct
                {
                    Mahdct = XulyId(),
                    Mahd = mahd,
                    Idctsp = masp,
                    Slban = slban,
                    Gia = Convert.ToDecimal(gia),
                    Ngayban = DateTime.Now.Date,
                };
                if (repo.them(hdct))
                {
                    return "Add thành công";
                }
                else return "Add không thành công";
           
           
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
                Mahdct = XulyId(),
                Mahd = id ,
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
                var ds = Change().Where(x => x.Mahd == id  || x.Slban == slban || x.Gia == gia || x.Ngayban == ngayban);
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
        public void UpdateHoaDonCT(string idhdct, int slban, decimal gia)
        {
            try
            {
                Hoadonct hdct = GetHoaDonCT().Find(x => x.Mahdct == idhdct);
                hdct.Slban = slban;
                hdct.Gia = Convert.ToDecimal(gia);
                repo.them(hdct);

            }
            catch (Exception)
            {
                Console.WriteLine("Lỗi");
            }
        }
        public bool XoaHDCT(string idhdct)
        {
            Hoadonct hoadonct = GetHoaDonCT().Find(x => x.Mahdct == idhdct);
            return repo.xoa(hoadonct);
        }
        public List<Hoadonct> FindHoaDonct(string idkh)
        {
            return repo.FindhoadonByid(idkh).ToList();
        }
    }
}
