﻿
using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class KhachHangRepo
    {
        DUAN1Context context = new DUAN1Context();
        public List<Khachhang> getallKhachRepo()
        {
            return context.Khachhangs.ToList();
        }
        public List<Khachhang> FindSvByName(string name)
        {
            return context.Khachhangs.Where(x => x.Ten.ToLower().Contains(name)).ToList();
        }
        public bool them(Khachhang khachhang)
        {
            context.Khachhangs.Add(khachhang);

            return context.SaveChanges() > 0; 
        }
        public bool sua(string IDND, Khachhang khachhang)
        {
            try
            {
                var obj = findbyname(IDND);
                if (obj == null)
                {
                    return false;
                }
                obj.Idkh = khachhang.Idkh;
                obj.Idloaind = khachhang.Idloaind;
                obj.Ten = khachhang.Ten;
                obj.Sdt = khachhang.Sdt;
                obj.Diachi = khachhang.Diachi;
                obj.Email = khachhang.Email;
                obj.Diem = khachhang.Diem;
               
                context.Update(obj);
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(string idkhachhang)
        {
            var itemxoa = context.Khachhangs.Find(idkhachhang);
            context.Khachhangs.Remove(itemxoa);
            return context.SaveChanges() > 0;
        }
        public Khachhang findbyname(string ID)
        {
            return context.Khachhangs.Find(ID);
        }
    }
}
