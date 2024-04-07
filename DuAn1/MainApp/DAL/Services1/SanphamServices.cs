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
        public List<Sanpham> Change()
        {
            List<Sanpham> list2 = new();
            foreach (var item in list)
            {
                list2.Add(Loc(item.Masp));
            }
            return list2;
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
            for (int i = 0; i <= list.Count(); i++)
            {
                if (i >= 10)
                {
                    idtam = "SP" + i;
                }
                else
                {
                    idtam = "SP" + "0" + i;
                }
                if (list.Where(x => Convert.ToInt32(x.Masp.Skip(2)) == i).Count() > 0)
                {
                    break;
                }
            }
            return idtam;
        }
        public bool AddSP(string ten, int soluong, int giaban, string trangthai)
        {
            if (CheckValidate(ten) || CheckValidate(soluong) || CheckValidate(giaban) || CheckValidate(trangthai))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
            {
                Sanpham sanpham = new Sanpham
                {
                    Masp = XulyId(),
                    Tensp = ten,
                    Soluong = soluong,
                    Giaban = giaban,
                    Trangthai = trangthai
                };
                return true;
            }

        }
        public bool UpdateSP(string id, string name, int soluong, int giaban, string trangthai)
        {
            if (CheckValidate(id) || CheckValidate(name) || CheckValidate(soluong) || CheckValidate(giaban) || CheckValidate(trangthai))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
            {
                Sanpham sanpham = new Sanpham
                {
                    Masp = id,
                    Tensp = name,
                    Soluong = soluong,
                    Giaban = giaban,
                    Trangthai = trangthai
                };
                return repo.sua(id, sanpham);
            }

        }
        public Sanpham XoaSp(string id)
        {
            Sanpham sanpham = list.Find(x => x.Masp == id);
            return sanpham;
        }
        public List<Sanpham> GetSanphamsByName(string name, List<Sanpham> list)
        {
            return list;
        }
        public string DeleteSP(string id)
        {
            return id;
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
        public Sanpham Loc(string id)
        {
            Sanpham sP = new Sanpham()
            {
           
                Masp = id,
                Tensp = list.Find(x => x.Masp == id).Tensp.ToString(),
                Soluong = list.Find(x => x.Masp == id).Soluong.Value,
                Giaban = list.Find(x => x.Masp == id).Giaban.Value,
                Trangthai = list.Find(x => x.Masp == id).Trangthai.ToString()

            };
            return sP;
        }
        public List<Sanpham> Timkiem(string? id, string? tensp, int? soluong, decimal? giaban, string? trangthai)
        {
            if (id == null && tensp == null && soluong == null && giaban == null && trangthai == null)
            {
                MessageBox.Show("Chưa nhập thông tin để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
            {
                var ds = Change().Where(x => x.Masp == id || x.Tensp == tensp || x.Soluong == soluong || x.Giaban == giaban || x.Trangthai == trangthai);
                List<Sanpham> listAdd = new();
                if (ds.Count() > 0)
                {
                    foreach (var item in ds)
                    {
                        listAdd.Add(Loc(item.Masp));
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
}
