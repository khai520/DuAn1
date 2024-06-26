﻿
using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class DeGiayRepo
    {
        DUAN1Context context = new DUAN1Context();
        public List<Degiay> getallDeGiayrepo()
        {
            return context.Degiays.ToList();
        }
        public List<Degiay> FindSvByName(string name)
        {
            return context.Degiays.Where(x => x.Degiay1.ToLower().Contains(name)).ToList();
        }
        public bool them(Degiay degiay)
        {
            context.Degiays.Add(degiay);
            context.SaveChanges();
            return true;
        }
        public bool sua(string masp, Degiay degiay)
        {
            try
            {
                var obj = findbyname(masp);
                if (obj == null)
                {
                    return false;
                }
                obj.Degiay1 = degiay.Degiay1;


                context.Update(obj);
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(string iddegiay)
        {
            var itemxoa = context.Degiays.Find(iddegiay);
            context.Degiays.Remove(itemxoa);
            return context.SaveChanges() > 0;
        }
        public Degiay findbyname(string ID)
        {
            return context.Degiays.Find(ID);
        }
    }
}
