﻿using System;
using System.Collections.Generic;

namespace MainApp.BLL.Models
{
    public partial class VaiTro
    {
        public VaiTro()
        {
            NguoiDungs = new HashSet<NguoiDung>();
        }

        public string IdvaiTro { get; set; } = null!;
        public string? Vaitro1 { get; set; }

        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
