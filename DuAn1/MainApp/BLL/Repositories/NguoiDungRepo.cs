
using MainApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class NguoiDungRepo
    {
        DUAN1Context context = new DUAN1Context();

        public List<NguoiDung> getallSPrepo()
        {
            return context.NguoiDungs.ToList();
        }
        public List<NguoiDung> CheckLogin (string email , string password)
        {
            return context.NguoiDungs.Where(x => x.Email == email && x.MatKhau == password).ToList();
        }
        public List<NguoiDung> FindSvByName(string name)
        {
            return context.NguoiDungs.Where(x => x.Ten.ToLower().Contains(name)).ToList();
        }
        public bool them(NguoiDung nguoiDung)
        {
            context.NguoiDungs.Add(nguoiDung);
            context.SaveChanges();
            return true;
        }
        public bool sua(NguoiDung nguoiDung)
        {
            context.Update(nguoiDung);
            return context.SaveChanges() > 0;
        }
        public bool xoa(NguoiDung xoaND)
        {
            
            context.NguoiDungs.Remove(xoaND);
            return context.SaveChanges() > 0;
        }
        public NguoiDung findbyname(string ID)
        {
            return context.NguoiDungs.Find(ID);
        }
    }
}
