
using MainApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace Main.DAL.Services
{
    internal class DeGiayService
    {
        DeGiayRepo giayRepo = new DeGiayRepo();


        public List<Degiay> Getalldegiay()
        {
            return giayRepo.getallDeGiayrepo().ToList();
        }

        public bool Them(string id, string name)
        {
            Degiay degiay = new Degiay
            {
                IdDegiay = id,
                Degiay1 = name,
            };
            return true;
        }
        public bool Sua(string id, string name)
        {
            Degiay degiay1 = new Degiay
            {
                IdDegiay = id,
                Degiay1 = name,
            };
            return giayRepo.sua(id, degiay1);

        }

        public bool Xoa(string ID)
        {
            return true;
        }

        public List<Degiay> FindDegiayByName(string name)
        {
            return giayRepo.FindSvByName(name).ToList();
        }
        public List<Degiay> SortByName()
        {
            List<Degiay> degiaySoft = giayRepo.getallDeGiayrepo().ToList();
            degiaySoft.Sort((x, y) => x.Degiay1.CompareTo(y.Degiay1));
            return degiaySoft;
        }
        
    }
}
