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
    public class DataAccessLayerDers
    {
        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();
            SqlCommand komut2 = new SqlCommand("select * from tbldersler", baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();// Eğer Bağlantım Kapalıysa Bağlantımı Aç
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler ent = new EntityDersler();
                ent.Dersid = Convert.ToInt32(dr["dersid"].ToString());
                ent.Dersad = dr["dersAd"].ToString();
                ent.Dersminkont = Convert.ToInt32(dr["DersMinKont"].ToString());
                ent.Dersmaxkont = Convert.ToInt32(dr["dersMaxKont"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int dersEkle(EntityBasvuruForm parametre)
        {                                                       
            SqlCommand komut3 = new SqlCommand("insert into tblbasvuruform (basvuruogrid,basvurudersid) values (@p1,@p2)", baglanti.bgl);
            komut3.Parameters.AddWithValue("@p1", parametre.Basvuruogrid);
            komut3.Parameters.AddWithValue("@p2", parametre.Basvurudersid);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();// Eğer Bağlantım Kapalıysa Bağlantımı Aç
            }

            return komut3.ExecuteNonQuery();


        }
    }
}
