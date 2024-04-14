
using MainApp.Models;
using System;
using System.Collections.Generic;
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
            for (int i = 0; i <= list.Count; i++)
            {
                if (i >= 10)
                {
                    idtam = "KH" + i;
                }
                else
                {
                    idtam = "KH" + "0" + i;
                }
                if (list.Where(x => Convert.ToInt32(x.Idkh.Skip(2)) == i).Count() > 0)
                {
                    break;
                }
            }
            return idtam;
        }

        public bool Them(string name, string diachi, string sdt, string email, string diem)
        {
            if (CheckValidate(diachi) || CheckValidate(sdt) || CheckValidate(email) || CheckValidate(name))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
            {
                Khachhang khach = new Khachhang
                {
                    Idkh = XulyId(),
                    Ten = name,
                    Diachi = diachi,
                    Sdt = sdt,
                    Email = email,
                    Diem = diem
                };
                return repo.them(khach);
            }

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


        public bool Sua(string id, string name, string diachi, string sdt, string email, string diem)
        {
            if (CheckValidate(id) || CheckValidate(diachi) || CheckValidate(sdt) || CheckValidate(email) || CheckValidate(name))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
            {
                Khachhang khach1 = new Khachhang
                {
                    Idkh = id,
                    Ten = name,
                    Sdt = sdt,
                    Diachi = diachi,
                    Email = email,
                    Diem = diem
                };
                repo.sua(id, khach1);
                return true;
            }
        }

        public bool Xoa(string ID)
        {
            return true;
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
