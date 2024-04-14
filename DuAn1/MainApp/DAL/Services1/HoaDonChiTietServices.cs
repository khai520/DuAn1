
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
            for (int i = 1; i <= list.Count() + 1; i++)
            {
                if (i >= 10)
                {
                    idtam = "HDCT" + i;
                }
                else
                {
                    idtam = "HDCT" + "0" + i;
                }
                if (list.Where(x => x.Mahdct == idtam).Count() > 0)
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

        public string AddHoaDonCT( string mahd, string masp, int slban, string gia)
        {
            string id = XulyId();
                Hoadonct hdct = new Hoadonct
                {
                    Mahdct = id,
                    Mahd = mahd,
                    Idctsp = masp,
                    Slban = slban,
                    Gia = Convert.ToInt32(gia),
                    Ngayban = DateTime.Now.Date,
                };
                if (repo.them(hdct))
                {
                    return "Add thành công";
                }
                else return "Add không thành công";
           
           
        }

        //public List<Hoadonct> Timkiem(string? id, string? idctsp, int? slban, int? gia, DateTime? ngayban)
        //{
        //    if (id == null && idctsp == null && slban == null && gia == null && ngayban == null)
        //    {
        //        MessageBox.Show("Chưa nhập thông tin để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return null;
        //    }
        //    else
        //    {
        //        var ds = Change().Where(x => x.Mahd == id  || x.Slban == slban || x.Gia == gia || x.Ngayban == ngayban);
        //        List<Hoadonct> listAdd = new();
        //        if (ds.Count() > 0)
        //        {
        //            foreach (var item in ds)
        //            {
        //                listAdd.Add(Loc(item.Mahd));
        //            }
        //        }
        //        else
        //        {
        //            listAdd = list;
        //        }
        //        return listAdd;
        //    }
        //}
        public void UpdateHoaDonCT(string idhdct, int slban, int gia)
        {
            try
            {
                Hoadonct hdct = GetHoaDonCT().Find(x => x.Mahdct == idhdct);
                hdct.Slban = slban;
                hdct.Gia = gia;
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
