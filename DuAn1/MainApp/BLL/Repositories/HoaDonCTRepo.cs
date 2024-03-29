﻿using Main.BLL.Models2;
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
        public List<Hoadonct> getallSPrepo()
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
            context.SaveChanges();
            return true;
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
                context.SaveChanges();

                return true;
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
