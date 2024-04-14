
using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsApp1.Repositories;

namespace Main.DAL.Services
{
    internal class MaGiamGiaServices
    {
        MagiamgiaRepo repo = new MagiamgiaRepo();
        List<Magiamgium> list = new List<Magiamgium>();

        public List<Magiamgium> Getallmagiam()
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
        public bool CheckValidate(dynamic Check)
        {
            if (Check == null || Check.Length == 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool Them(string name, int phantramgiam, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            if (CheckValidate(name) || CheckValidate(phantramgiam) || CheckValidate(ngaybatdau) || CheckValidate(ngayketthuc))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
            {
                Magiamgium ma = new Magiamgium
                {
                    Idmagiamgia = XulyId(),
                    Tenma = name,
                    Phamtramgiam = phantramgiam,
                    Ngaybatdau = ngaybatdau,
                    Ngayketthuc = ngayketthuc
                };
                return true;
            }

        }
        public bool Sua(string id, string name, int phantramgiam, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            if (CheckValidate(name) || CheckValidate(phantramgiam) || CheckValidate(ngaybatdau) || CheckValidate(ngayketthuc))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
            {
                Magiamgium magiam = new Magiamgium
                {
                    Idmagiamgia = id,
                    Tenma = name,
                    Phamtramgiam = phantramgiam,
                    Ngaybatdau = ngaybatdau,
                    Ngayketthuc = ngayketthuc
                };
                repo.sua(magiam);
                return true;
            }


        }

        public bool Xoa(string ID)
        {
            return true;
        }

        public List<Magiamgium> FindMGGByName(string name)
        {
            return repo.FindMGGByName(name).ToList();
        }
        public List<Magiamgium> SortByName()
        {
            List<Magiamgium> magiamgiaSoft = repo.getallMaRepo().ToList();
            magiamgiaSoft.Sort((x, y) => x.Tenma.CompareTo(y.Tenma));
            return magiamgiaSoft;
        }
        
    }
}
