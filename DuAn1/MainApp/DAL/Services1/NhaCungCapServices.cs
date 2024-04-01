using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace WinFormsApp1.Services
{
    internal class NhaCungCapServices
    {
        NhaCungCapRepo nhacungcap = new NhaCungCapRepo();
        List<NhaCungCap> list = new List<NhaCungCap>(); 
        public List<NhaCungCap> getallSnhacungcap(List<NhaCungCap> list1)
        {
            return list = list1;
        }
        public List<NhaCungCap> Change()
        {
            List<NhaCungCap> list2 = new();
            foreach (var item in list)
            {
                list2.Add(Loc(item.Idncc));
            }
            return list2;
        }

        public bool Them(string id, string name)
        {
            NhaCungCap nha = new NhaCungCap
            {
                Idncc = id,
                Tenncc = name
            };
            return true;
        }
        public bool Sua(string id, string name)
        {
            NhaCungCap nha1 = new NhaCungCap
            {
                Idncc = id,
                Tenncc = name
            };
            return nhacungcap.sua(id, nha1);

        }

        public bool Xoa(string ID)
        {
            return true;
        }
        public NhaCungCap Loc(string id)
        {
            NhaCungCap sP = new NhaCungCap()
            {
                //Idctsp = id,
                //Tengiay = list.Find(x => x.Idctsp == id).Tengiay.ToString(),
                //Masp = list.Find(x => x.Idctsp == id).Masp.ToString(),
                //Mau = ms.GetallMau().Find(x => x.Idmau == list.Find(x => x.Idctsp == id).Mau).Mau.ToString(),
                //Chatlieuu = cl.Getallchatlieu().Find(x => x.Idchatlieu == list.Find(x => x.Idctsp == id).Chatlieuu).Chatlieu1.ToString(),
                //Kichthuoc = kt.Getallkt().Find(x => x.IdKichthuoc == list.Find(x => x.Idctsp == id).Kichthuoc).Kichthuoc1.ToString(),
                //Degiay = dg.Getalldegiay().Find(x => x.IdDegiay == list.Find(x => x.Idctsp == id).Degiay).Degiay1.ToString(),
                //Giaban = list.Find(x => x.Idctsp == id).Giaban,
                Idncc= id,
                Tenncc = list.Find(x=>x.Idncc == id).Tenncc.ToString(),
                Email = list.Find(x => x.Idncc == id).Email.ToString(),
                Sdt = list.Find(x => x.Idncc == id).Sdt.ToString(),
                Loaidichvu = list.Find(x => x.Idncc == id).Loaidichvu.ToString(),
                Diachi = list.Find(x => x.Idncc == id).Diachi.ToString(),
                Dieukhoanhoptac = list.Find(x => x.Idncc == id).Dieukhoanhoptac.ToString()


            };
            return sP;
        }
        public List<NhaCungCap> Timkiem(string? id,string? tenncc, string? email, string? sdt, string? loaidichvu, string? diachi, string? dieukhoan )
        {
            var ds = Change().Where(x => x.Idncc == id || x.Tenncc == tenncc || x.Email == email || x.Sdt == sdt || x.Loaidichvu == loaidichvu || x.Diachi == diachi || x.Dieukhoanhoptac == dieukhoan );
            List<NhaCungCap> listAdd = new();
            if (ds.Count() > 0)
            {
                foreach (var item in ds)
                {
                    listAdd.Add(Loc(item.Idncc));
                }
            }
            else
            {
                listAdd = list;
            }
            return listAdd;
        }
        public List<NhaCungCap> FindNCCByName(string name)
        {
            return nhacungcap.FindSvByName(name).ToList();
        } 
        public List<NhaCungCap> SortByName()
        {
                List<NhaCungCap> nhacungcapSoft = nhacungcap.getallSPrepo().ToList();
                nhacungcapSoft.Sort((x, y) => x.Tenncc.CompareTo(y.Tenncc));
                return nhacungcapSoft;
        }
        public List<NhaCungCap> FindSvByName(string name)
        {
            return nhacungcap.FindSvByName(name).ToList();
        }
        }
}
