using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace Main.DAL.Services
{
    internal class Chatlieuservices
    {
        ChatLieuRepo chatlieu = new ChatLieuRepo();

        public List<Chatlieu> Getallchatlieu()
        {
            return chatlieu.getallSPrepo().ToList();
        }
        public List<Chatlieu> FindSvByName(string name)
        {
            return chatlieu.FindSvByName(name).ToList();
        }
        
        public bool Them(string id , string name)
        {
            Chatlieu chatlieu1 = new Chatlieu
            {
                Idchatlieu = id ,
                Chatlieu1 = name

            };
            return true;
        }
        public bool Sua(string id , string name)
        {
            Chatlieu chatlieu1 = new Chatlieu
            {
                Idchatlieu = id,
                Chatlieu1 = name
            };
            return chatlieu.sua(id, chatlieu1);

        }
        public bool Xoa (string ID )
        {
            return true;
        }

    }
}
