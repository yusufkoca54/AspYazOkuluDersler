using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntitiyLayer;

namespace DataAccessLayer
{
    public class DataAccessLayerOgrenci
    {
        public static int ogrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into tblogrenciler (ogrAd,OgrSoyad,ogrNumara,ogrFoto,ogrSifre) values(@p1,@p2,@p3,@p4,@p5)",baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();// Eğer Bağlantım Kapalıysa Bağlantımı Aç
            }

            komut1.Parameters.AddWithValue("@p1", parametre.Ograd);
            komut1.Parameters.AddWithValue("@p2", parametre.Ogrsoyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Ogrnumara);
            komut1.Parameters.AddWithValue("@p4", parametre.Ogrfotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.Ogrsifre);
            return komut1.ExecuteNonQuery();
         

        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from tblogrenciler", baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();// Eğer Bağlantım Kapalıysa Bağlantımı Aç
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ogrid = Convert.ToInt32(dr["ogrid"].ToString());
                ent.Ograd = dr["ogrAd"].ToString();
                ent.Ogrsoyad = dr["ogrSoyad"].ToString();
                ent.Ogrnumara = dr["ogrNumara"].ToString();
                ent.Ogrfotograf = dr["ogrFoto"].ToString();
                ent.Ogrsifre = dr["ogrSifre"].ToString();
                ent.Ogrbakiye =Convert.ToDouble(dr["ogrBakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete From tblogrenciler where ogrid=@p1",baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();// Eğer Bağlantım Kapalıysa Bağlantımı Aç
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }


        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("select * from tblogrenciler where ogrid=@p1", baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();// Eğer Bağlantım Kapalıysa Bağlantımı Aç
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ograd = dr["ogrAd"].ToString();
                ent.Ogrsoyad = dr["ogrSoyad"].ToString();
                ent.Ogrnumara = dr["ogrNumara"].ToString();
                ent.Ogrfotograf = dr["ogrFoto"].ToString();
                ent.Ogrsifre = dr["ogrSifre"].ToString();
                ent.Ogrbakiye = Convert.ToDouble(dr["ogrBakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            
            SqlCommand komut5 = new SqlCommand("update tblogrenciler set ogrAd=@p1,ogrSoyad=@p2,ogrNumara=@p3,ogrFoto=@p4,ogrSifre=@p5 where ogrid=@p6", baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();// Eğer Bağlantım Kapalıysa Bağlantımı Aç
            }
            komut5.Parameters.AddWithValue("@p1", deger.Ograd);
            komut5.Parameters.AddWithValue("@p2", deger.Ogrsoyad);
            komut5.Parameters.AddWithValue("@p3", deger.Ogrnumara);
            komut5.Parameters.AddWithValue("@p4", deger.Ogrfotograf);
            komut5.Parameters.AddWithValue("@p5", deger.Ogrsifre);
            komut5.Parameters.AddWithValue("@p6", deger.Ogrid);
            return komut5.ExecuteNonQuery() > 0;

        }

    }
}
