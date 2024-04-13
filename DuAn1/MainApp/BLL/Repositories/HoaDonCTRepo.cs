using MainApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class HoaDonCTRepo
    {

        DUAN1Context context = new DUAN1Context();
        public List<Hoadonct> getallHoaDonrepo()
        {
            return context.Hoadoncts.ToList();
        }
        public List<Hoadonct> FindhoadonByid(string idhd)
        {
            return context.Hoadoncts.Where(x => x.Mahd.ToLower().Contains(idhd)).ToList();
        }
        public bool them(Hoadonct hoadonct)
        {
            context.Hoadoncts.Add(hoadonct);
            
            return context.SaveChanges() > 0;
        }
        public bool sua(string mahd, Hoadonct hoadonct)
        {
            try
            {
                var obj = findbyname(mahd);
                if (obj == null)
                {
                    return false;
                }
                obj.Mahd = hoadonct.Mahd;
                obj.Idctsp = hoadonct.Idctsp;
                obj.Slban = hoadonct.Slban;
                obj.Gia = hoadonct.Gia;
                obj.Ngayban = hoadonct.Ngayban;
               

                context.Update(obj);
                

                return context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(string idhdct)
        {
            var itemxoa = context.Hoadoncts.Find(idhdct);
            context.Hoadoncts.Remove(itemxoa);
            return context.SaveChanges() > 0;
        }
        public Hoadonct findbyname(string ID)
        {
            return context.Hoadoncts.Find(ID);
        }
    }
}
