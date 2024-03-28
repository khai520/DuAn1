using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace Main.DAL.Services
{
    internal class MauSacService
    {
        MauSacRepo mau = new MauSacRepo();


        public List<Mausac> GetallMau()
        {
            return mau.getallMauRepo().ToList();
        }

        public bool Them(string id, string name)
        {
            Mausac mausac = new Mausac
            {
                Idmau = id,
                Mau = name
            };
            return true;
        }
        public bool Sua(string id, string name)
        {
            Mausac mausac = new Mausac
            {
                Idmau = id,
                Mau = name
            };
            return mau.sua(id, mausac);

        }

        public bool Xoa(string ID)
        {
            return true;
        }

        public List<Mausac> FindKtByName(string name)
        {
            return mau.FindSvByName(name).ToList();
        }
        public List<Mausac> SortByName()
        {
            List<Mausac> mausacSoft = mau.getallMauRepo().ToList();
            mausacSoft.Sort((x, y) => x.Mau.CompareTo(y.Mau));
            return mausacSoft;
        }
       
    }
}
