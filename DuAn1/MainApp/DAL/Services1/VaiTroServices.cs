using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace WinFormsApp1.Services
{
    internal class VaiTroServices
    {
        VaiTroRepo vaiTroRepo = new VaiTroRepo();
        List<VaiTro> list = new List<VaiTro>();
        public List<VaiTro> GetVaiTros(List<VaiTro> list1)
        {
            return list = list1;

        }
        public List<VaiTro> Change()
        {
            List<VaiTro> list2 = new();
            foreach (var item in list)
            {
                list2.Add(Loc(item.IdvaiTro));
            }
            return list2;
        }
        public VaiTro Loc(string id)
        {
            VaiTro sP = new VaiTro()
            {
           
                IdvaiTro = id,
                Vaitro1 = list.Find(x=>x.IdvaiTro==id).Vaitro1.ToString()
            };
            return sP;
        }
        public List<VaiTro> Timkiem(string? id , string? vaitro)
        {
            var ds = Change().Where(x => x.IdvaiTro == id ||x.Vaitro1 == vaitro);
            List<VaiTro> listAdd = new();
            if (ds.Count() > 0)
            {
                foreach (var item in ds)
                {
                    listAdd.Add(Loc(item.IdvaiTro));
                }
            }
            else
            {
                listAdd = list;
            }
            return listAdd;
        }

    }
}
