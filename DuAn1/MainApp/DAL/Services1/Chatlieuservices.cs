﻿

using MainApp.Models;
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
        public List<Chatlieu> SortByName()
        {
            List<Chatlieu> chatlieuSoft = chatlieu.getallSPrepo().ToList();
            chatlieuSoft.Sort((x, y) => x.Chatlieu1.CompareTo(y.Chatlieu1));
            return chatlieuSoft;
        }
        public List<Chatlieu> FindSvByName(string name)
        {
            return chatlieu.FindSvByName(name).ToList();
        }
    }
}
