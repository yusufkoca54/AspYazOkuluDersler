using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BllOgrenci
    {
        public static int ogrenciEkleBll(EntityOgrenci p)
        {
            if (p.Ograd != null && p.Ograd != "" && p.Ogrsoyad != null && p.Ogrsoyad != "" && p.Ogrnumara != null && p.Ogrnumara != "" && p.Ogrsifre != null && p.Ogrsifre != "" && p.Ogrfotograf != null && p.Ogrfotograf != "")
            {
                return DataAccessLayerOgrenci.ogrenciEkle(p);
            }
            return -1; // yani boş döndür işlemi yapma
        }
        public static List<EntityOgrenci> BllListele()
        {
            return DataAccessLayerOgrenci.OgrenciListesi();
        }
        public static bool ogrencisilBll(int p)
        {
            if (p >= 0)
            {
                return DataAccessLayerOgrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DataAccessLayerOgrenci.OgrenciDetay(p);
        }
        public static bool ogrenciGuncelleBll(EntityOgrenci p)
        {
            if (p.Ograd != null && p.Ograd != "" && p.Ogrsoyad != null && p.Ogrsoyad != "" && p.Ogrnumara != null && p.Ogrnumara != "" && p.Ogrsifre != null && p.Ogrsifre != "" && p.Ogrfotograf != null && p.Ogrfotograf != "" && p.Ogrid > 0)
            {
                return DataAccessLayerOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
