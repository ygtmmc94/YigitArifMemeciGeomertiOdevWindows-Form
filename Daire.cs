﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomometriOdev
{
    class Daire
    {
        public double YariCap { get; set; }

        public double CevreHesapla()
        {
            return 2 * Math.PI * YariCap;

        }

        public double AlanHesapla()
        {
            return Math.PI * YariCap * YariCap;
        }
            
    }
}
