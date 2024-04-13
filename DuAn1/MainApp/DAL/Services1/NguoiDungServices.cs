using Main.DAL.Services;
using MainApp.BLL.Models;
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
        public List<NguoiDung> GetallND()
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
                    idtam = "ND" + i;
                }
                else
                {
                    idtam = "ND" + "0" + i;
                }
                if (list.Where(x => Convert.ToInt32(x.IdnguoiDung.Skip(2)) == i).Count() > 0)
                {
                    break;
                }
            }
            return idtam;
        }

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
            if (CheckValidate(ten) || CheckValidate(matkhau) || CheckValidate(diachi) || CheckValidate(email) || CheckValidate(sdt) || CheckValidate(trangthai))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
            {
                var user = new NguoiDung
                {
                    IdnguoiDung = XulyId(),
                    Ten = ten,
                    MatKhau = matkhau,
                    Diachi = diachi,
                    Email = email,
                    Dthoai = sdt,
                    Trangthai = trangthai
                };
                return true;
            }

        }
        public bool UpdateUser(string id, string ten, string matkhau, string diachi, string email, string sdt, string trangthai)
        {
            if (CheckValidate(ten) || CheckValidate(matkhau) || CheckValidate(diachi) || CheckValidate(email) || CheckValidate(sdt) || CheckValidate(trangthai))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
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
                repo.sua(id, nguoidung);
                return true;
            }

        }
        public bool CheckLogin(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (repo.CheckLogin(email, password).Count > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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
