using System;
using System.Collections.Generic;

namespace MainApp.BLL.Models
{
    public partial class Chatlieu
    {
        public Chatlieu()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        public string Idchatlieu { get; set; } = null!;
        public string Chatlieu1 { get; set; } = null!;

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
