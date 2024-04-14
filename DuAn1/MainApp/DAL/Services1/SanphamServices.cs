
using Main.DAL.Services;
using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
            if (Check == null || Check.Length == 0 )
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
        public string AddSP(string ten, string soluong, string giaban)
        {
            string id = XulyId();
            try
            {
                if (Convert.ToInt32(soluong) < 0)
                {
                    return "Số lượng không được nhỏ hơn 0";
                }
                else if (Convert.ToInt32(giaban) < 0)
                {
                    return "Giá bán không được nhỏ hơn 0";
                }
                else if (CheckValidate(ten))
                {
                    return "Thiếu tên";
                }
                else
                {
                    
                    Sanpham sanpham = new Sanpham
                    {
                        Masp = id,
                        Tensp = ten,
                        Soluong = Convert.ToInt32(soluong),
                        Giaban = Convert.ToDecimal(giaban),
                        Trangthai = Convert.ToInt32(soluong) == 0 ? "Hết hàng" : "Còn hàng"
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
                return "Sai kiểu dữ liệu";
            }
            

        }
        public string UpdateSP(string id, string name, string soluong, string giaban)
        {
            try
            {
                if (Convert.ToInt32(soluong) < 0)
                {
                    return "Số lượng không được nhỏ hơn 0";
                }
                else if (Convert.ToInt32(giaban) < 0)
                {
                    return "Giá bán không được nhỏ hơn 0";
                }
                else if (CheckValidate(name))
                {
                    return "Thiếu tên";
                }
                else
                {
                    Sanpham sanpham = list.Find(x => x.Masp == id);
                    sanpham.Tensp = name;
                    sanpham.Soluong = Convert.ToInt32(soluong);
                    sanpham.Giaban = Convert.ToDecimal(giaban);
                    sanpham.Trangthai = Convert.ToInt32(soluong) == 0 ? "Hết hàng" : "Còn hàng";
                    if (repo.sua(sanpham))
                    {
                        return "Sửa thành công";
                    }
                    else return "Sửa không thành công";
                }
            }
            catch (Exception)
            {
                return "Lỗi dữ liệu";
            }
        }
        public string XoaSp(string id)
        {
            Sanpham sanpham = list.Find(x => x.Masp == id);
            CtSanphamService ctsp = new();
            ctsp.Xoa(sanpham.Masp);
            if (repo.xoa(sanpham))
            {
                return "Xóa thành công";
            }
            else return "Xóa không thành công";
            
        }
        public List<Sanpham> GetSanphamsByName(string name, List<Sanpham> list)
        {
            return list;
        }

        public List<Sanpham> FindSvByName(string name)
        {
            return repo.FindSvByName(name).ToList();
        }

        public List<Sanpham> Timkiem(string? id, string? tensp, int? soluong, decimal? giaban, string? trangthai)
        {

            return GetSanphams().Where(x => x.Masp == id || x.Tensp == tensp || x.Soluong == soluong || x.Giaban == giaban || x.Trangthai == trangthai).ToList();
        }
        public void UpdateSL(string id , int sl)
        {
            Sanpham sanpham = list.Find(x => x.Masp == id);
            sanpham.Soluong = sl;
            repo.sua(sanpham);
            

        }
    }
}
