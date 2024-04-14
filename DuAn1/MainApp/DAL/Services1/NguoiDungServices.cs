using Main.DAL.Services;
using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using WinFormsApp1.Repositories;

namespace WinFormsApp1.Services
{
    internal class NguoiDungServices
    {
        NguoiDungRepo repo = new NguoiDungRepo();
        VaiTroServices vaiTroServices = new VaiTroServices(); 
        List<NguoiDung> list = new List<NguoiDung>();
        public string Xoa(string id)
        {
            NguoiDung idndxoa = list.Find(x => x.IdnguoiDung == id);
            if(repo.xoa(idndxoa))
            {
                return "Xóa thành công";
            }    
            else
            {
                return "Xóa thất bại";
            }    
        }
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
            for (int i = 0; i <= list.Count() + 1; i++)
            {
                if (i >= 10)
                {
                    idtam = "ND" + i;
                }
                else
                {
                    idtam = "ND" + "0" + i;
                }
                if (list.Where(x => x.IdnguoiDung == idtam).Count() > 0)
                {
                    continue;
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
        public string AddUser(string ten, string matkhau, string diachi, string email, string sdt, string trangthai)
        {
            if (CheckValidate(ten) || CheckValidate(matkhau) ||CheckValidate(email))
            {
                return "Dữ liệu lỗi hoặc chưa đầy đủ";
                
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
                if (repo.them(user))
                {
                    return "Add thành công";
                }    
                else
                {
                    return "Add không thành công";
                }    
            }

        }
        public string UpdateUser(string id, string ten, string matkhau, string diachi, string email, string sdt, string trangthai)
        {
            if (CheckValidate(ten) || CheckValidate(matkhau) ||CheckValidate(email) )
            {
                return "Sửa thất bại do sai dữ liệu";
            }
            else
            {
                NguoiDung nguoidung = list.Find(x => x.IdnguoiDung == id);
                nguoidung.Ten = ten;
                nguoidung.MatKhau = matkhau;
                nguoidung.Diachi = diachi;
                nguoidung.Email = email;
                nguoidung.Dthoai = sdt;
                nguoidung.Trangthai = trangthai;

                if(repo.sua(nguoidung))
                {
                    return "Sửa thành công";
                }    
                else
                {
                    return "Sửa thất bại";
                }    
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
