using MainApp.BLL.Models;
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
            for (int i = 0; i <= list.Count() + 1; i++)
            {
                if (i >= 10)
                {
                    idtam = "MGG" + i;
                }
                else
                {
                    idtam = "MGG" + "0" + i;
                }
                if (list.Where(x => x.Idmagiamgia == idtam).Count() > 0)
                {
                    continue;
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
            if (CheckValidate(name))
            {
                MessageBox.Show("Bạn chưa nhập tên mã giảm giá");
                return false;
            }
            else if(phantramgiam < 1 || phantramgiam > 70)
            {
                MessageBox.Show("Phần trăm giảm không được quá 70%");
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
                if(repo.them(ma))
                {
                    return true;
                }
                else
                {
                    return false;
                }    
            }

        }
        public bool Sua(string idmgg, string name, int phantramgiam, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            if (CheckValidate(name))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else if (phantramgiam < 1 || phantramgiam > 70)
            {
                MessageBox.Show("Phần trăm giảm không được quá 70%");
                return false;
            }
            else
            {
                Magiamgium magiam = list.Find(x => x.Idmagiamgia == idmgg);
                magiam.Tenma = name;
                magiam.Phamtramgiam = phantramgiam;
                magiam.Ngaybatdau = ngaybatdau;
                magiam.Ngayketthuc = ngayketthuc;
                repo.sua(magiam);
                return true;
            }
        }
        public string Xoa(string ID)
        {
            Magiamgium mggxoa = list.Find(x => x.Idmagiamgia == ID);
            if (repo.xoa(mggxoa))
            {
                return "Xóa thành công";
            }    
            else
            { return "Xóa thất bại"; }    
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
