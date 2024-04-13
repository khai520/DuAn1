
using MainApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace Main.DAL.Services
{
    internal class LoaiKhachHangService
    {
        LoaiKhachHangRepo repo = new LoaiKhachHangRepo();


        public List<Loaikhachhang> Getallkh()
        {
            return repo.getallLoaiKhachHangRepo().ToList();

        }
        public List<Loaikhachhang> SortByName()
        {
            List<Loaikhachhang> loaikhachhangSoft = repo.getallLoaiKhachHangRepo().ToList();
            loaikhachhangSoft.Sort((x, y) => x.Ten.CompareTo(y.Ten));
            return loaikhachhangSoft;
        }
        
    }
}
