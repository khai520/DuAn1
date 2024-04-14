using System;
using System.Collections.Generic;

namespace MainApp.Models
{
    public partial class Magiamgium
    {
        public Magiamgium()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        public string Idmagiamgia { get; set; } = null!;
        public string? Tenma { get; set; }
        public int? Phamtramgiam { get; set; }
        public DateTime? Ngaybatdau { get; set; }
        public DateTime? Ngayketthuc { get; set; }

        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
