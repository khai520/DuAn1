using System;
using System.Collections.Generic;

namespace MainApp.Models
{
    public partial class Hoadonct
    {
        public string Mahdct { get; set; } = null!;
        public string Mahd { get; set; } = null!;
        public string Masp { get; set; } = null!;
        public int? Slban { get; set; }
        public decimal? Gia { get; set; }
        public DateTime? Ngayban { get; set; }

        public virtual Hoadon MahdNavigation { get; set; } = null!;
        public virtual Sanpham MaspNavigation { get; set; } = null!;
    }
}
