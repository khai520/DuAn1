using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace WinFormsApp1.Services
{
    internal class SanphamServices
    {

        SanPhamRepo repo = new SanPhamRepo();

        List<Sanpham> list = new();
        public List<Sanpham> GetSanphams()

        {
            return list = repo.getallSPrepo();
        }
        public bool CheckValidate(dynamic Check)
        {
            if (Check == null || Check.Length == 0)
            {
                return true;
            }
            else { return false; }
        }
        public string XulyId()
        {
            string idtam = "";
            for (int i = 0; i <= list.Count() + 1; i++)
            {
                if (i >= 10)
                {
                    idtam = "SP" + i;
                }
                else
                {
                    idtam = "SP" + "0" + i;
                }
                if (list.Where(x => x.Masp == idtam).Count() > 0)
                {
                    continue;
                }
            }
            return idtam;
        }
        public string AddSP(string ten, string soluong, string giaban, string trangthai)
        {
            string id = XulyId();
            try
            {
                if(CheckValidate(ten) || CheckValidate(soluong) || CheckValidate(giaban) || CheckValidate(trangthai))
                {
                    return "Sai dữ liệu";
                }
                else
                {
                    
                    Sanpham sanpham = new Sanpham
                    {
                        Masp = id,
                        Tensp = ten,
                        Soluong = Convert.ToInt32(soluong),
                        Giaban = Convert.ToDecimal(giaban),
                        Trangthai = trangthai
                    };
                    if (repo.them(sanpham))
                    {
                        return "Add thành công";
                    }
                    else { return "Add không thành công"; }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(id + ten + soluong + giaban + trangthai);
                return "Sai kiểu dữ liệu";
            }
            

        }
        public string UpdateSP(string id, string name, string soluong, string giaban, string trangthai)
        {
            if (CheckValidate(id) || CheckValidate(name) || CheckValidate(soluong) || CheckValidate(giaban) || CheckValidate(trangthai))
            {
                return "Dữ liệu nhập vào lỗi hoặc chưa đầy đủ";
            }
            else
            {
                Sanpham sanpham = list.Find(x => x.Masp == id);
                sanpham.Tensp = name;
                sanpham.Soluong = Convert.ToInt32(soluong);
                sanpham.Giaban = Convert.ToDecimal(giaban);
                sanpham.Trangthai = trangthai;
                if (repo.sua(sanpham))
                {
                    return "Sửa thành công";
                }
                else return "Sửa không thành công";
            }

        }
        public string XoaSp(string id)
        {
            Sanpham sanpham = list.Find(x => x.Masp == id);
            if (repo.xoa(id))
            {
                return "Xóa thành công";
            }
            else return "Xóa không thành công";
            
        }
        public List<Sanpham> GetSanphamsByName(string name, List<Sanpham> list)
        {
            return list;
        }
        public List<Sanpham> SortByName()
        {
            List<Sanpham> sanphamSoft = repo.getallSPrepo().ToList();
            sanphamSoft.Sort((x, y) => x.Tensp.CompareTo(y.Tensp));
            return sanphamSoft;
        }
        public List<Sanpham> FindSvByName(string name)
        {
            return repo.FindSvByName(name).ToList();
        }

        public List<Sanpham> Timkiem(string? id, string? tensp, int? soluong, decimal? giaban, string? trangthai)
        {

            return GetSanphams().Where(x => x.Masp == id || x.Tensp == tensp || x.Soluong == soluong || x.Giaban == giaban || x.Trangthai == trangthai).ToList();
        }

    }
}
