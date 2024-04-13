using System;
using System.Collections.Generic;

namespace MainApp.BLL.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
            Hoadoncts = new HashSet<Hoadonct>();
        }

        public string Masp { get; set; } = null!;
        public string? Tensp { get; set; }
        public int? Soluong { get; set; }
        public decimal? Giaban { get; set; }
        public string? Trangthai { get; set; }

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
        public virtual ICollection<Hoadonct> Hoadoncts { get; set; }
    }
}
