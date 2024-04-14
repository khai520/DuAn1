
using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace Main.DAL.Services
{
    internal class KhachHangService
    {
        KhachHangRepo repo = new KhachHangRepo();
        List<Khachhang> list = new List<Khachhang>();
        LoaiKhachHangService loaiKhach = new LoaiKhachHangService();
        public List<Khachhang> Getallkh()
        {
            return list = repo.getallKhachRepo();
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
                    idtam = "KH" + i;
                }
                else
                {
                    idtam = "KH" + "0" + i;
                }
                if (list.Where(x => x.Idkh == idtam).Count() > 0)
                {
                    continue;
                }

            }
            return idtam;
        }

        public string Them(string name, string diachi, string sdt, string email, string loaikh  )
        {
            string id = XulyId();
          
               
                if (CheckValidate(name))
                {
                    return "Thiếu tên";
                }
                else if (CheckValidate(sdt))
            {
                return " thiếu sdt";
            }
                else
                {

                    Khachhang khachhang = new Khachhang
                    {
                        Idkh = id,
                        Idloaind = loaikh,
                        Ten = name,
                        Diachi = diachi,
                        Sdt = sdt,
                        Email = email,
                    
                    };
                    if (repo.them(khachhang))
                    {
                        return "Add thành công";
                    }
                    else { return "Add không thành công"; }
                }
            //}
            //catch (Exception)
            //{
            //    return "Sai kiểu dữ liệu";
            //}


        }
        public List<Khachhang> Change()
        {
            List<Khachhang> list2 = new();
            foreach (var item in list)
            {
                list2.Add(Loc(item.Idkh));
            }
            return list2;
        }
        public Khachhang Loc(string id)
        {
            string? loaikh;
            if (loaiKhach.Getallkh().Find(x => x.Idloaind == list.Find(x => x.Idkh == id).Idloaind) == null)
            {
                loaikh = " ";
            }
            else
            {
                loaikh = loaiKhach.Getallkh().Find(x => x.Idloaind == list.Find(x => x.Idkh == id).Idloaind).Ten.ToString();
            }
            Khachhang sP = new Khachhang()
            {
              
                Idkh = id,
                Idloaind = loaikh,
                Ten = list.Find(x => x.Idkh == id).Ten.ToString(),
                Sdt = list.Find(x => x.Idkh == id).Sdt.ToString(),
                Diachi = list.Find(x => x.Idkh == id).Diachi.ToString(),
                Email = list.Find(x => x.Idkh == id).Email.ToString(),
                Diem= list.Find(x => x.Idkh == id).Diem.ToString(),

            };
            return sP;
        }
        public List<Khachhang> Timkiem(string? idkh, string? idloaikh, string? ten, string? sdt, string? diachi, string? email, string? diem)
        {
            if (idkh == null && idloaikh == null && ten == null && sdt == null && diachi == null && email == null && diem == null)
            {
                MessageBox.Show("Chưa nhập thông tin để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
            {
                var ds = Change().Where(x => x.Idkh == idkh || x.Idloaind == idloaikh || x.Ten == ten || x.Sdt == sdt || x.Diachi == diachi || x.Email == email || x.Diem == diem);
                List<Khachhang> listAdd = new();
                if (ds.Count() > 0)
                {
                    foreach (var item in ds)
                    {
                        listAdd.Add(Loc(item.Idkh));
                    }
                }
                else
                {
                    listAdd = list;
                }
                return listAdd;
            }
        }


        public string Sua(string id, string name, string diachi, string sdt, string email, string diem)
        {
            try
            {
                if (CheckValidate(sdt))
                {
                    return "Số lượng không được nhỏ hơn 0";
                }
                else if (Convert.ToInt32(sdt) < 0)
                {
                    return "Giá bán không được nhỏ hơn 0";
                }
                else if (CheckValidate(email))
                {
                    return "không được để trống ";
                }
                else if (CheckValidate(name))
                {
                    return "Thiếu tên";
                }
                else
                {
                    Khachhang khachhang = list.Find(x => x.Idkh == id);
                    khachhang.Ten = name;
                    khachhang.Diachi = diachi ;
                    khachhang.Sdt = sdt;
                    khachhang.Email = email;
                 
                    if (repo.sua(id,khachhang))
                    {
                        return "Sửa thành công";
                    }
                    else return "Sửa không thành công";
                }
            }
            catch (Exception)
            {
                return "Lỗi dữ liệu";
            }
        }

        public string Xoa(string ID)
        {
           Khachhang khachhang = list.Find(x => x.Idkh == ID);
            KhachHangRepo khachHangRepo = new();
            if (repo.xoa(khachhang.Idkh))
            {
                return "Xóa thành công";
            }
            else return "Xóa không thành công";
        }

        public List<Khachhang> SortByName()
        {
            List<Khachhang> khachhangSoft = repo.getallKhachRepo().ToList();
            khachhangSoft.Sort((x, y) => x.Ten.CompareTo(y.Ten));
            return khachhangSoft;
        }
        public List<Khachhang> FindSvByName(string name)
        {
            return repo.FindSvByName(name).ToList();
        }
    }
}
