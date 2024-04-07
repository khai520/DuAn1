using Main.BLL.Models2;
using MainApp.GUI.VIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;
using WinFormsApp1.Services;

namespace Main.DAL.Services
{
    internal class CtSanphamService
    {
        CTSanPhamRepo sanpham = new CTSanPhamRepo();
        NhaCungCapServices ncc = new NhaCungCapServices();
        MauSacService ms = new MauSacService();
        Chatlieuservices cl = new();
        KichThuocService kt = new();
        DeGiayService dg = new();
        List<Ctsanpham> list = new List<Ctsanpham>();
        public List<Ctsanpham> GetallChitietsanpham(List<Ctsanpham> list1)
        {
            return list = list1;
        }
        public string XulyId()
        {
            string idtam = "";
            for (int i = 0; i <= list.Count(); i++)
            {
                if (i >= 10)
                {
                    idtam = "CTSP" + i;
                }
                else
                {
                    idtam = "CTSP" + "0" + i;
                }
                if (list.Where(x => Convert.ToInt32(x.Masp.Skip(2)) == i).Count() > 0)
                {
                    break;
                }
            }
            return idtam;
        }
        public List<Ctsanpham> Change()
        {
            List<Ctsanpham> list2 = new();
            foreach (var item in list)
            {
                list2.Add(Loc(item.Idctsp));
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
        public bool Them(string name, string idncc, string masp, string mau, string chatlieu, string kichthuoc, string degiay, decimal giaban)
        {
            if (CheckValidate(name) || CheckValidate(idncc) || CheckValidate(masp) || CheckValidate(mau) || CheckValidate(chatlieu) || CheckValidate(kichthuoc) || CheckValidate(degiay) || CheckValidate(giaban))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
            {
                Ctsanpham ctsanpham = new Ctsanpham
                {
                    Idctsp = XulyId(),
                    Idncc = idncc,
                    Tengiay = name,
                    Masp = masp,
                    Chatlieuu = chatlieu,
                    Kichthuoc = kichthuoc,
                    Degiay = degiay,
                    Mau = mau,
                    Giaban = giaban
                };
                return true;
            }

        }
        public bool Sua(string id, string idncc, string name, string masp, string mau, string chatlieu, string kichthuoc, string degiay, decimal giaban)
        {
            if (CheckValidate(name) || CheckValidate(idncc) || CheckValidate(masp) || CheckValidate(mau) || CheckValidate(chatlieu) || CheckValidate(kichthuoc) || CheckValidate(degiay) || CheckValidate(giaban))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
            {
                Ctsanpham ctsanpham = new Ctsanpham
                {
                    Idctsp = id,
                    Idncc = idncc,
                    Tengiay = name,
                    Masp = masp,
                    Chatlieuu = chatlieu,
                    Kichthuoc = kichthuoc,
                    Degiay = degiay,
                    Mau = mau,
                    Giaban = giaban
                };
                sanpham.sua(id, ctsanpham);
                return true;
            }


        }

        public bool Xoa(string ID)
        {
            return true;
        }

        public List<Ctsanpham> FindCTSPByName(string name)
        {
            return sanpham.FindSvByName(name).ToList();
        }
        public List<Ctsanpham> SortByName()
        {
            List<Ctsanpham> sanphamSoft = sanpham.getallSPrepo().ToList();
            sanphamSoft.Sort((x, y) => x.Tengiay.CompareTo(x.Tengiay));
            return sanphamSoft;
        }
        public Ctsanpham Loc(string id)
        {

            string? nccc;
            if (ncc.getallSnhacungcap().Find(x => x.Idncc == list.Find(x => x.Idctsp == id).Idncc) == null)
            {
                nccc = " ";
            }
            else
            {
                nccc = ncc.getallSnhacungcap().Find(x => x.Idncc == list.Find(x => x.Idctsp == id).Idncc).Tenncc.ToString();
            }
            string? mau;
            if (ms.GetallMau().Find(x => x.Idmau == list.Find(x => x.Idctsp == id).Mau) == null)
            {
                mau = " ";
            }
            else
            {
                mau = ms.GetallMau().Find(x => x.Idmau == list.Find(x => x.Idctsp == id).Mau).Mau.ToString();
            }
            string? chatlieu;
            if (cl.Getallchatlieu().Find(x => x.Idchatlieu == list.Find(x => x.Idctsp == id).Chatlieuu) == null)
            {
                chatlieu = " ";
            }
            else
            {
                chatlieu = cl.Getallchatlieu().Find(x => x.Idchatlieu == list.Find(x => x.Idctsp == id).Chatlieuu).Chatlieu1.ToString();
            }
            string? kichthuoc;
            if (kt.Getallkt().Find(x => x.IdKichthuoc == list.Find(x => x.Idctsp == id).Kichthuoc) == null)
            {
                kichthuoc = " ";
            }
            else
            {
                kichthuoc = kt.Getallkt().Find(x => x.IdKichthuoc == list.Find(x => x.Idctsp == id).Kichthuoc).Kichthuoc1.ToString();
            }
            string? degiay;
            if (dg.Getalldegiay().Find(x => x.IdDegiay == list.Find(x => x.Idctsp == id).Degiay) == null)
            {
               degiay = " ";
            }
            else
            {
                degiay = dg.Getalldegiay().Find(x => x.IdDegiay == list.Find(x => x.Idctsp == id).Degiay).Degiay1.ToString();
            }



            Ctsanpham sP = new Ctsanpham()
            {
                Idctsp = id,
                Idncc = nccc,
                Tengiay = list.Find(x => x.Idctsp == list.Find(x => x.Idctsp == id).Idncc).Tengiay.ToString(),
                Masp = list.Find(x => x.Idctsp == id).Masp.ToString(),
                Mau = mau,
                Chatlieuu = chatlieu,
                Kichthuoc = kichthuoc,
                Degiay = degiay,
                Giaban = list.Find(x => x.Idctsp == id).Giaban,

            };
            return sP;
        }
        public List<Ctsanpham> Timkiem(string? id, string? name, string? masp, string? mau, string? chatlieu, string? kichthuoc, string? degiay, decimal giaban)
        {
            if (id == null && name == null && masp == null && mau == null && chatlieu == null && kichthuoc == null && degiay == null)
            {

                MessageBox.Show("Chưa nhập thông tin để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
            {
                var ds = Change().Where(x => x.Idctsp == id || x.Tengiay == name || x.Masp == masp || x.Mau == mau || x.Chatlieuu == chatlieu || x.Kichthuoc == kichthuoc || x.Degiay == degiay || x.Giaban == giaban);
                List<Ctsanpham> listAdd = new();
                if (ds.Count() > 0)
                {
                    foreach (var item in ds)
                    {
                        listAdd.Add(Loc(item.Idctsp));
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
