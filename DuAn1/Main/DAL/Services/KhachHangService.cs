using Main.BLL.Models2;
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


        public List<Khachhang> Getalldegiay()
        {
            return repo.getallKhachRepo().ToList();
        }

        public bool Them(string id, string name)
        {
            Khachhang khach = new Khachhang
            {
                Idkh = id,
                Ten = name
            };
            return true;
        }
        public bool Sua(string id, string name,string diachi, string sdt, string email, string diem)
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
            return repo.sua(id, khach1);

        }

        public bool Xoa(string ID)
        {
            return true;
        }

        public List<Khachhang> SortByName()
        {
            List<Khachhang> khachhangSoft = repo.getallSPrepo().ToList();
            khachhangSoft.Sort((x, y) => x.Ten.CompareTo(y.Ten));
            return khachhangSoft;
        }
        public List<Khachhang> FindSvByName(string name)
        {
            return repo.FindSvByName(name).ToList();
        }
    }
}
