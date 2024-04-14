using System;
using System.Collections.Generic;

namespace MainApp.Models
{
    public partial class Ctsanpham
    {
        public Ctsanpham()
        {
            Hoadoncts = new HashSet<Hoadonct>();
        }

        public string Idctsp { get; set; } = null!;
        public string? Idncc { get; set; }
        public string? Masp { get; set; }
        public string? Idmau { get; set; }
        public string? Idchatlieu { get; set; }
        public string? Idkichthuoc { get; set; }
        public string? Iddegiay { get; set; }
        public string? Trangthai { get; set; }
        public int? Soluong { get; set; }

        public virtual Chatlieu? IdchatlieuNavigation { get; set; }
        public virtual Degiay? IddegiayNavigation { get; set; }
        public virtual Kichthuoc? IdkichthuocNavigation { get; set; }
        public virtual Mausac? IdmauNavigation { get; set; }
        public virtual NhaCungCap? IdnccNavigation { get; set; }
        public virtual Sanpham? MaspNavigation { get; set; }
        public virtual ICollection<Hoadonct> Hoadoncts { get; set; }
    }
}
