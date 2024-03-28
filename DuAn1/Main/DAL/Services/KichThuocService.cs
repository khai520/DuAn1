using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace Main.DAL.Services
{
    internal class KichThuocService
    {
        KichThuocRepo kichthuoc = new KichThuocRepo();


        public List<Kichthuoc> Getallkt()
        {
            return kichthuoc.getallKtRepo().ToList();
        }

        public bool Them(string id, string name)
        {
            Kichthuoc kt = new Kichthuoc
            {
                IdKichthuoc = id,
                Kichthuoc1 = name,
            };
            return true;
        }
        public bool Sua(string id, string name)
        {
            Kichthuoc kt = new Kichthuoc
            {
                IdKichthuoc = id,
                Kichthuoc1 = name,
            };
            return kichthuoc.sua(id, kt);

        }

        public bool Xoa(string ID)
        {
            return true;
        }

        public List<Kichthuoc> FindKtByName(string name)
        {
            return kichthuoc.FindSvByName(name).ToList();
        }
    }
}
