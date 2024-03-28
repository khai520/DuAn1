using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WinFormsApp1.Repositories
{
    internal class HoaDonRepo
    {
        DUAN1Context context = new DUAN1Context();
        public List<Hoadon> getallSPrepo()
        {
            return context.Hoadons.ToList();
        }
        public List<Hoadon> FindhoadonByid(string idhd)
        {
            return context.Hoadons.Where(x => x.Mahd.ToLower().Contains(idhd)).ToList();
        }
        public bool them(Hoadon hoadon)
        {
            context.Hoadons.Add(hoadon);
            return context.SaveChanges() > 0;
            
        }
        public bool sua(string masp, Hoadon hoadon)
        {
                var obj = findbyname(masp);
                if (obj == null)
                {
                    return false;
                }
                obj.Mahd = hoadon.Mahd;
                obj.Idkh = hoadon.Idkh;
                obj.IdnguoiDung = hoadon.IdnguoiDung;
                obj.Ngayban = hoadon.Ngayban;
                obj.Tensp = hoadon.Tensp;
                obj.Soluong = hoadon.Soluong;
                obj.Tongtien = hoadon.Tongtien;
                obj.Trangthai = hoadon.Trangthai;
               
                context.Update(obj);
                return context.SaveChanges()> 0;
        }
        public bool xoa(string xoahd)
        {
            var itemxoa = context.Hoadons.Find(xoahd);
            context.Hoadons.Remove(itemxoa);
            return context.SaveChanges() > 0;
        }
        public Hoadon findbyname(string ID)
        {
            return context.Hoadons.Find(ID);
        }
    }
}
