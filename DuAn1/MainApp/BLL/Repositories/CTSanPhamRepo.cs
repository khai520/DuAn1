
using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class CTSanPhamRepo
    {
        DUAN1Context context = new DUAN1Context();
        public List<Ctsanpham> getallSPrepo()
        {
            return context.Ctsanphams.ToList();
        }
        public List<Ctsanpham> FindSvByName(string name)
        {
            return context.Ctsanphams.Where(x => x.Tengiay.ToLower().Contains(name)).ToList();
        }
        public bool them(Ctsanpham ctsanpham)
        {
            context.Ctsanphams.Add(ctsanpham);
            return context.SaveChanges() > 0;
        }
        public bool sua(Ctsanpham ctsanpham)
        {
            context.Update(ctsanpham);
            
            return context.SaveChanges() > 0;
        }
        public bool xoa(Ctsanpham sp)
        {
            try
            {
                context.Ctsanphams.Remove(sp);
                return context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
        public Ctsanpham findbyname(string ID)
        {
            return context.Ctsanphams.Find(ID);
        }
    }
}
