﻿using System;
using System.Collections.Generic;

namespace MainApp.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Hoadoncts = new HashSet<Hoadonct>();
        }

        public string Mahd { get; set; } = null!;
        public string? Idkh { get; set; }
        public string? IdnguoiDung { get; set; }
        public string? Idmagiamgia { get; set; }
        public DateTime? Ngayban { get; set; }
        public string? Tensp { get; set; }
        public int? Soluong { get; set; }
        public int? Tongtien { get; set; }
        public string? Trangthai { get; set; }

        public virtual Khachhang? IdkhNavigation { get; set; }
        public virtual Magiamgium? IdmagiamgiaNavigation { get; set; }
        public virtual NguoiDung? IdnguoiDungNavigation { get; set; }
        public virtual ICollection<Hoadonct> Hoadoncts { get; set; }
    }
}
