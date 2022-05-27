using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer
{
    public class EntityOgretmen
    {
        private int ogrtid;
        private string ogrtadsoyad;
        private int ogrtbrans;

        public int Ogrtid { get => ogrtid; set => ogrtid = value; }
        public string Ogrtadsoyad { get => ogrtadsoyad; set => ogrtadsoyad = value; }
        public int Ogrtbrans { get => ogrtbrans; set => ogrtbrans = value; }
    }
}
