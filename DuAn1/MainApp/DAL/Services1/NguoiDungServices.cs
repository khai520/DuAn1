using Main.BLL.Models2;
using Main.DAL.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using WinFormsApp1.Repositories;

namespace WinFormsApp1.Services
{
    internal class NguoiDungServices
    {
        NguoiDungRepo repo = new NguoiDungRepo();
      VaiTroServices vaiTroServices = new VaiTroServices(); 
        List<NguoiDung> list = new List<NguoiDung>();
        public List<NguoiDung> GetallChitietsanpham(List<NguoiDung> list1)
        {
            return list = list1;
        }
        static int counter = 0;
        public List<NguoiDung> Change()
        {
            List<NguoiDung> list2 = new();
            foreach (var item in list)
            {
                list2.Add(Loc(item.Masp));
            }
            return list2;
        }
        public bool AddUser(string ten, string matkhau, string diachi, string email, string sdt, string trangthai)

        {
            var user = new NguoiDung
            {
                //IdnguoiDung = GenerateID(),

                Ten = ten,
                MatKhau = matkhau,
                Diachi = diachi,
                Email = email,
                Dthoai = sdt,
                Trangthai = trangthai
            };
            return true;
        }
        public bool UpdateUser(string id, string ten, string matkhau, string diachi, string email, string sdt, string trangthai)
        {
            NguoiDung nguoidung = new NguoiDung
            {
                IdnguoiDung = id,
                Ten = ten,
                MatKhau = matkhau,
                Diachi = diachi,
                Email = email,
                Dthoai = sdt,
                Trangthai = trangthai
            };
            return repo.sua(id, nguoidung);
        }

        public bool CheckLogin(string email, string password)
        {
            if (repo.CheckLogin(email, password).Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public NguoiDung Loc(string id)
        {
            NguoiDung sP = new NguoiDung()
            {
                //Idctsp = id,
                //Tengiay = list.Find(x => x.Idctsp == id).Tengiay.ToString(),
                //Masp = list.Find(x => x.Idctsp == id).Masp.ToString(),
                //Mau = ms.GetallMau().Find(x => x.Idmau == list.Find(x => x.Idctsp == id).Mau).Mau.ToString(),
                //Chatlieuu = cl.Getallchatlieu().Find(x => x.Idchatlieu == list.Find(x => x.Idctsp == id).Chatlieuu).Chatlieu1.ToString(),
                //Kichthuoc = kt.Getallkt().Find(x => x.IdKichthuoc == list.Find(x => x.Idctsp == id).Kichthuoc).Kichthuoc1.ToString(),
                //Degiay = dg.Getalldegiay().Find(x => x.IdDegiay == list.Find(x => x.Idctsp == id).Degiay).Degiay1.ToString(),
                //Giaban = list.Find(x => x.Idctsp == id).Giaban,
                IdnguoiDung = id,
                IdvaiTro = vaiTroServices.GetVaiTros().Find(x=>x.IdvaiTro == list.Find(x=>x.IdnguoiDung == id).IdvaiTro).Vaitro1.ToString(),
                Ten = list.Find(x => x.IdnguoiDung == id).Ten.ToString(),
                MatKhau = list.Find(x => x.IdnguoiDung == id).MatKhau.ToString(),
                Diachi = list.Find(x => x.IdnguoiDung == id).Diachi.ToString(),
                Email = list.Find(x => x.IdnguoiDung == id).Email.ToString(),
                Dthoai = list.Find(x => x.IdnguoiDung == id).Dthoai.ToString(),
                Trangthai = list.Find(x => x.IdnguoiDung == id).Trangthai.ToString(),


            };
            return sP;
        }
        public List<Ctsanpham> Timkiem(string? id, string? name, string? masp, string? mau, string? chatlieu, string? kichthuoc, string? degiay, decimal giaban)
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
        public List<NguoiDung> checktkdn(string email, string passwork)
        {
            return repo.CheckLogin(email, passwork).ToList();
        }
            public List<NguoiDung> SortByName()
            {
                List<NguoiDung> nguoidungSoft = repo.getallSPrepo().ToList();
                nguoidungSoft.Sort((x, y) => x.Ten.CompareTo(y.Ten));
                return nguoidungSoft;
            }
            public List<NguoiDung> FindSvByName(string name)
            {
                return repo.FindSvByName(name).ToList();
            }
        }
}
