using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomometriOdev
{
    class DikDörtgen : IDortgen
    {
        
        public double UzunKenar { get; set; }
        public double KisaKenar { get; set; }

        public double CevreHesapla()
        {
            return (UzunKenar + KisaKenar) * 2;
        }

        public double AlanHesapla()
        {
            return UzunKenar * KisaKenar;
        }
    

    }
}
