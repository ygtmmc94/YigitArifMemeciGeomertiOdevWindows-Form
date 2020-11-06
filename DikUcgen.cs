using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomometriOdev
{
    class DikUcgen : IUcgen
    {
        public double TabanKenar { get; set; }
        public double Yukseklik { get; set; }

        public double AlanHesapla()
        {
            return (TabanKenar * Yukseklik) / 2;
        }

        public double CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(TabanKenar, 2) + Math.Pow(Yukseklik, 2));
            return hipotenus + TabanKenar + Yukseklik;
        }
    }
}
