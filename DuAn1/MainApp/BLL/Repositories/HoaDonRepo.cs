
using MainApp.Models;
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
        public bool sua( Hoadon hoadon)
        {
                context.Update(hoadon);
                return context.SaveChanges()> 0;
        }
        public bool xoa(Hoadon xoahd)
        {
            context.Hoadons.Remove(xoahd);
            return context.SaveChanges() > 0;
        }
        public Hoadon findbyname(string ID)
        {
            return context.Hoadons.Find(ID);
        }
    }
}
