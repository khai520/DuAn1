using MainApp.BLL.Models;
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
        List<NhaCungCap> nhaCungCapList = new List<NhaCungCap>();
        public List<NhaCungCap> getallSnhacungcap()
        {
            List<NhaCungCap> list = nhacungcap.getallSPrepo().ToList();
            return nhaCungCapList = list;
        }
        public string XulyId()
        {
            List<NhaCungCap> list = getallSnhacungcap();
            string idtam = "";
            for (int i = 0; i <= list.Count(); i++)
            {
                if (i >= 10)
                {
                    idtam = "NCC" + i;
                }
                else
                {
                    idtam = "NCC" + "0" + i;
                }
                if (list.Where(x => Convert.ToInt32(x.Idncc.Skip(2)) == i).Count() > 0)
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
        public List<NhaCungCap> Change()
        {
            List<NhaCungCap> list2 = new();
            foreach (var item in nhaCungCapList)
            {
                list2.Add(Loc(item.Idncc));
            }
            return list2;
        }

        public bool Them(string name, string email, string sdt, string loaidichvu, string diaChi, string dieukhoanhoptac)
        {
            if (CheckValidate(name) || CheckValidate(email) || CheckValidate(sdt) || CheckValidate(loaidichvu) || CheckValidate(diaChi) || CheckValidate(dieukhoanhoptac))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
            {
                NhaCungCap nha = new NhaCungCap
                {
                    Idncc = XulyId(),
                    Tenncc = name,
                    Email = email,
                    Sdt = sdt,
                    Loaidichvu = loaidichvu,
                    Diachi = diaChi,
                    Dieukhoanhoptac = dieukhoanhoptac
                };
                return true;
            }

        }
        public bool Sua(string id, string name, string email, string sdt, string loaidichvu, string diaChi, string dieukhoanhoptac)
        {
            if (CheckValidate(id) || CheckValidate(name) || CheckValidate(email) || CheckValidate(sdt) || CheckValidate(loaidichvu) || CheckValidate(diaChi) || CheckValidate(dieukhoanhoptac))
            {
                MessageBox.Show("Dữ liệu nhập vào lỗi hoặc chưa đầy đủ");
                return false;
            }
            else
            {
                NhaCungCap nha1 = new NhaCungCap
                {
                    Idncc = id,
                    Tenncc = name,
                    Email = email,
                    Sdt = sdt,
                    Loaidichvu = loaidichvu,
                    Diachi = diaChi,
                    Dieukhoanhoptac = dieukhoanhoptac
                };
                nhacungcap.sua(id, nha1);
                return true;
            }


        }

        public bool Xoa(string ID)
        {
            return true;
        }
        public NhaCungCap Loc(string id)
        {
            NhaCungCap sP = new NhaCungCap()
            {
              
                Idncc= id,
                Tenncc = nhaCungCapList.Find(x=>x.Idncc == id).Tenncc.ToString(),
                Email = nhaCungCapList.Find(x => x.Idncc == id).Email.ToString(),
                Sdt = nhaCungCapList.Find(x => x.Idncc == id).Sdt.ToString(),
                Loaidichvu = nhaCungCapList.Find(x => x.Idncc == id).Loaidichvu.ToString(),
                Diachi = nhaCungCapList.Find(x => x.Idncc == id).Diachi.ToString(),
                Dieukhoanhoptac = nhaCungCapList.Find(x => x.Idncc == id).Dieukhoanhoptac.ToString()


            };
            return sP;
        }
        public List<NhaCungCap> Timkiem(string? id, string? tenncc, string? email, string? sdt, string? loaidichvu, string? diachi, string? dieukhoan)
        {
            if (id == null && tenncc == null && email == null && sdt == null && loaidichvu == null && diachi == null && dieukhoan == null)
            {
                MessageBox.Show("Chưa nhập thông tin để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
            {
                var ds = Change().Where(x => x.Idncc == id || x.Tenncc == tenncc || x.Email == email || x.Sdt == sdt || x.Loaidichvu == loaidichvu || x.Diachi == diachi || x.Dieukhoanhoptac == dieukhoan);
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
                    listAdd = nhaCungCapList;
                }
                return listAdd;
            }
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
