using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer
{
    public class EntityDersler
    {
        private int dersid;
        private string dersad;
        private int dersminkont;
        private int dersmaxkont;

        public int Dersid { get => dersid; set => dersid = value; }
        public string Dersad { get => dersad; set => dersad = value; }
        public int Dersminkont { get => dersminkont; set => dersminkont = value; }
        public int Dersmaxkont { get => dersmaxkont; set => dersmaxkont = value; }
    }
}
