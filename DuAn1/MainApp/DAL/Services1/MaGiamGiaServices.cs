using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.BLL;
using Main.BLL.Models2;
using WinFormsApp1.Repositories;

namespace Main.DAL.Services
{
    internal class MaGiamGiaServices
    {
        MagiamgiaRepo repo = new MagiamgiaRepo();
        List<Magiamgia> list = new List<Magiamgia>();

        public List<Magiamgia> Getallmagiam()
        {
            return list= repo.getallMaRepo();
        }
        public string XulyId()
        {
            string idtam = "";
            for (int i = 0; i <= list.Count(); i++)
            {
                if (i >= 10)
                {
                    idtam = "MGG" + i;
                }
                else
                {
                    idtam = "MGG" + "0" + i;
                }
                if (list.Where(x => Convert.ToInt32(x.Idmagiamgia.Skip(2)) == i).Count() > 0)
                {
                    break;
                }
            }
            return idtam;
        }

        public bool Them(string id, string name)
        {
            Magiamgia ma = new Magiamgia
            {
                Idmagiamgia = id,
                Tenma = name
            };
            return true;
        }
        public bool Sua(string id, string name)
        {
            Magiamgia magiam = new Magiamgia
            {
                Idmagiamgia = id,
                Tenma = name
            };
            return repo.sua(id, magiam);

        }

        public bool Xoa(string ID)
        {
            return true;
        }

        public List<Magiamgia> FindMGGByName(string name)
        {
            return repo.FindMGGByName(name).ToList();
        }
        public List<Magiamgia> SortByName()
        {
            List<Magiamgia> magiamgiaSoft = repo.getallMaRepo().ToList();
            magiamgiaSoft.Sort((x, y) => x.Tenma.CompareTo(y.Tenma));
            return magiamgiaSoft;
        }
        
    }
}
