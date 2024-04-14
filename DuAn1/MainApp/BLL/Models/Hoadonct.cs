using System;
using System.Collections.Generic;

namespace MainApp.Models
{
    public partial class Hoadonct
    {
        public string Mahdct { get; set; } = null!;
        public string? Mahd { get; set; }
        public string? Idctsp { get; set; }
        public int? Slban { get; set; }
        public int? Gia { get; set; }
        public DateTime? Ngayban { get; set; }

        public virtual Ctsanpham? IdctspNavigation { get; set; }
        public virtual Hoadon? MahdNavigation { get; set; }
    }
}
