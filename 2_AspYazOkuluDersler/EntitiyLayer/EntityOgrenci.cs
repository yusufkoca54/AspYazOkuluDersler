using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer
{
    public class EntityOgrenci
    {
        private int ogrid;
        private string ograd;
        private string ogrsoyad;
        private string ogrnumara;
        private string ogrfotograf;
        private string ogrsifre;
        private double ogrbakiye;

        public int Ogrid { get => ogrid; set => ogrid = value; }
        public string Ograd { get => ograd; set => ograd = value; }
        public string Ogrsoyad { get => ogrsoyad; set => ogrsoyad = value; }
        public string Ogrnumara { get => ogrnumara; set => ogrnumara = value; }
        public string Ogrfotograf { get => ogrfotograf; set => ogrfotograf = value; }
        public string Ogrsifre { get => ogrsifre; set => ogrsifre = value; }
        public double Ogrbakiye { get => ogrbakiye; set => ogrbakiye = value; }
        
    }
}
