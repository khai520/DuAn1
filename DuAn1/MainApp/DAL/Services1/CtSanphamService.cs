
using MainApp.GUI.VIEW;
using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WinFormsApp1.Repositories;
using WinFormsApp1.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Main.DAL.Services
{
    internal class CtSanphamService
    {
        CTSanPhamRepo sanpham = new CTSanPhamRepo();
        List<Ctsanpham> list = new List<Ctsanpham>();
        public List<Ctsanpham> GetallChitietsanpham()
        {
            return list = sanpham.getallSPrepo();
        }
        public string XulyId()
        {
            string idtam = "";
            for (int i = 1; i <= list.Count() + 1; i++)
            {
                if (i >= 10)
                {
                    idtam = "CTSP" + i;
                }
                else
                {
                    idtam = "CTSP" + "0" + i;
                }
                if (list.Where(x => x.Idctsp == idtam).Count() > 0)
                {
                    continue;
                }
                else
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
        public string Them(object? idncc, string? masp, string? mau, string? chatlieu, string? kichthuoc, string? degiay, int? sl)
        {
            try
            {
                if (Convert.ToInt32(sl) < 0)
                {
                    return "Số lượng không được nhỏ hơn 0";
                }
                else if (CheckValidate(mau))
                {
                    return "màu không được để trống ";
                }
                else if (CheckValidate(chatlieu))
                {
                    return "không được để trống ";
                }
                else if (CheckValidate(kichthuoc))
                {
                    return "không đc để trống ";
                }
                var check = GetallChitietsanpham().Find(x => x.Idncc == (idncc == null ? "" : idncc.ToString()) && x.Masp == masp && x.Idmau == mau && x.Idchatlieu == chatlieu && x.Idkichthuoc == kichthuoc && x.Iddegiay == degiay);
                if (check != null)
                {
                    Sua(check.Idctsp, idncc, mau, chatlieu, kichthuoc, degiay, Convert.ToString(check.Soluong + Convert.ToInt32(sl)));
                    return "Add thành công";
                }
                else
                {
                    Ctsanpham ctsanpham = new Ctsanpham
                    {
                        Idctsp = XulyId(),
                        Idncc = idncc == null ? null : Convert.ToString(idncc),
                        Masp = masp,
                        Soluong = sl,
                        Idchatlieu = chatlieu,
                        Idkichthuoc = kichthuoc,
                        Iddegiay = degiay,
                        Idmau = mau,
                    };

                    if (sanpham.them(ctsanpham))
                    {
                        return "Add thành công";
                    }
                    else { return "Add không thành công"; }
                }
            }
            catch(Exception e)
            {
                return "Lỗi";
            }
         
        }
        public string Sua( string id, object? idncc, string? mau, string? chatlieu, string? kichthuoc, string? degiay , string? sl)
        {
            try
            {
                if (Convert.ToInt32(sl)<0)
                {
                    return "Số lượng không được nhỏ hơn 0";
                }
                else if (CheckValidate(mau))
                {
                    return "màu không được để trống ";
                }
                else if (CheckValidate(chatlieu))
                {
                    return "không được để trống ";
                }
                else if (CheckValidate(kichthuoc))
                {
                    return "không đc để trống ";
                }
                Ctsanpham sp = GetallChitietsanpham().Find(x => x.Idctsp == id);
                    sp.Idncc = Check(idncc);
                    sp.Idmau = mau;
                    sp.Idchatlieu = chatlieu;
                    sp.Idkichthuoc = kichthuoc;
                    sp.Iddegiay = degiay;
                    sp.Soluong = Convert.ToInt32(sl);
                    if (sanpham.sua(sp))
                    {
                        return "Sửa thành công";
                    }
                    else return "Sửa không thành công";
            }
            catch (Exception)
            {
                return "Sai kiều dữ liệu";
            }
        }
        public string Check(object? id)
        {
            if(id == null)
            {
                return null;
            }    
            else
            {
                return id.ToString();
            }    
        }
        public string Xoa(string ID)
        {
            Ctsanpham sp = sanpham.getallSPrepo().Find(x => x.Idctsp == ID);
            if (sanpham.xoa(sp))
            {
                return "Xóa thành công";
            }
            else return "Xóa không thành công";
        }
        public bool UpdateSL(string id, int sl)
        {
            Ctsanpham sp = list.Find(x => x.Idctsp == id);

            if (sp.Soluong == 0)
            {
                return false;
            }
            else
            {
                sp.Soluong = sl;
                sanpham.sua(sp);
                return true;
            }


        }
    }
