using Main.BLL.Models2;
using Main.DAL.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using WinFormsApp1.Repositories;

namespace WinFormsApp1.Services
{
    internal class NguoiDungServices
    {
        NguoiDungRepo repo = new NguoiDungRepo();
      VaiTroServices vaiTroServices = new VaiTroServices(); 
        List<NguoiDung> list = new List<NguoiDung>();
        public List<NguoiDung> GetallChitietsanpham(List<NguoiDung> list1)
        {
            return list = list1;
        }
        static int counter = 0;
        //public List<NguoiDung> Change()
        //{
        //    List<NguoiDung> list2 = new();
        //    foreach (var item in list)
        //    {
        //        list2.Add(Loc(item.Masp));
        //    }
        //    return list2;
        //}
        public bool AddUser(string ten, string matkhau, string diachi, string email, string sdt, string trangthai)

        {
            var user = new NguoiDung
            {
                //IdnguoiDung = GenerateID(),

                Ten = ten,
                MatKhau = matkhau,
                Diachi = diachi,
                Email = email,
                Dthoai = sdt,
                Trangthai = trangthai
            };
            return true;
        }
        public bool UpdateUser(string id, string ten, string matkhau, string diachi, string email, string sdt, string trangthai)
        {
            NguoiDung nguoidung = new NguoiDung
            {
                IdnguoiDung = id,
                Ten = ten,
                MatKhau = matkhau,
                Diachi = diachi,
                Email = email,
                Dthoai = sdt,
                Trangthai = trangthai
            };
            return repo.sua(id, nguoidung);
        }

        public bool CheckLogin(string email, string password)
        {
            if (repo.CheckLogin(email, password).Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
  
        public List<NguoiDung> checktkdn(string email, string passwork)
        {
            return repo.CheckLogin(email, passwork).ToList();
        }
            public List<NguoiDung> SortByName()
            {
                List<NguoiDung> nguoidungSoft = repo.getallSPrepo().ToList();
                nguoidungSoft.Sort((x, y) => x.Ten.CompareTo(y.Ten));
                return nguoidungSoft;
            }
            public List<NguoiDung> FindSvByName(string name)
            {
                return repo.FindSvByName(name).ToList();
            }
        }
}
