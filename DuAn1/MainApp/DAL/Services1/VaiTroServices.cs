using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace WinFormsApp1.Services
{
    internal class VaiTroServices
    {
        VaiTroRepo vaiTroRepo = new VaiTroRepo();
        List<VaiTro> list = new List<VaiTro>();
        public List<VaiTro> GetVaiTros(List<VaiTro> list1)
        {
            return list = list1;

        }

    }
}
