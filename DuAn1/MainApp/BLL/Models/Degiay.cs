﻿using System;
using System.Collections.Generic;

namespace MainApp.Models
{
    public partial class Degiay
    {
        public Degiay()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        public string Iddegiay { get; set; } = null!;
        public string Degiay1 { get; set; } = null!;

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
