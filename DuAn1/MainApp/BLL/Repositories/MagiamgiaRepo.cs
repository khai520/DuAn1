﻿
using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class MagiamgiaRepo
    {
        DUAN1Context context = new DUAN1Context();

        public List<Magiamgium> getallMaRepo()
        {
            return context.Magiamgia.ToList();
        }
        public List<Magiamgium> FindMGGByName(string name)
        {
            return context.Magiamgia.Where(x => x.Tenma.ToLower().Contains(name)).ToList();
        }
        public bool them(Magiamgium magiamgia)
        {
            context.Magiamgia.Add(magiamgia);
            return context.SaveChanges() > 0;
            
        }
        public bool sua( Magiamgium magiamgia)
        {
            context.Update(magiamgia);
            return context.SaveChanges() > 0;
        }
        public bool xoa(Magiamgium idxoama)
        {
            context.Magiamgia.Remove(idxoama);
            return context.SaveChanges() > 0;
        }
        public Magiamgium findbyname(string ID)
        {
            return context.Magiamgia.Find(ID);
        }
    }
}
