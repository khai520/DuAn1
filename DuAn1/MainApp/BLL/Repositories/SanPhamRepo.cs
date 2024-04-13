
using MainApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WinFormsApp1.Repositories
{
    internal class SanPhamRepo
    {
        DUAN1Context context = new DUAN1Context();
        

        public List<Sanpham> getallSPrepo()
        {
            return context.Sanphams.ToList();
        }
        public List<Sanpham> FindSvByName(string name)
        {
            return context.Sanphams.Where(x => x.Tensp.ToLower().Contains(name)).ToList();
        }
        public bool them(Sanpham sanpham)
        {
            context.Sanphams.Add(sanpham);
            return context.SaveChanges() > 0;
        }
        public bool sua(Sanpham sanpham)
        {
            context.Update(sanpham);
            return context.SaveChanges() > 0;
        }
        public bool xoa(Sanpham sanpham)
        {
            try
            {
                context.Sanphams.Remove(sanpham);
                return context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public Sanpham findbyname(string ID)
        {
            return context.Sanphams.Find(ID);
        }
    }
}
