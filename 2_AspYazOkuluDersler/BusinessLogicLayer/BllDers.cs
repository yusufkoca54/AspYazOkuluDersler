using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BllDers
    {
        public static List<EntityDersler> BllDersListele()
        {
            return DataAccessLayerDers.DersListesi();
        }
        public static int derEkleBll(EntityBasvuruForm p)
        {
            if (p.Basvuruogrid > 0  && p.Basvurudersid >0)
            {
                return DataAccessLayerDers.dersEkle(p);
            }
            return -1;
        }

    }
}
