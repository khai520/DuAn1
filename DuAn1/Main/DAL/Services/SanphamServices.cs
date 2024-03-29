﻿using Main.BLL.Models2;
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
        public List<Sanpham> GetSanphams(List<Sanpham> list)
        {
            return list;
        }
        public Sanpham AddSP(string ten, int soluong, int giaban, string trangthai )
        {
            Sanpham sanpham = new Sanpham
            {
                Tensp = ten,
                Soluong = soluong,
                Giaban = giaban,
                Trangthai = trangthai
            };
            return sanpham;
        }
        public Sanpham UpdateSP(string id , string name,int soluong, int giaban, string trangthai )
        {
            Sanpham sanpham = new Sanpham
            {
                Masp = id,
                Tensp = name,
                Soluong = soluong,
                Giaban = giaban,
                Trangthai = trangthai
            };
            return sanpham;
        }
        public List<Sanpham> GetSanphamsByName(string name , List<Sanpham> list)
        {
            return list;
        }
        public string DeleteSP(string id )
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
    }
}
