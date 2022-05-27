using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntitiyLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace _2_AspYazOkuluDersler
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ogrid"].ToString());
            Txtid.Text = x.ToString();
            Txtid.Enabled = false; // bunu yapma sebebimiz öğrenci id değiştirilemesin 

            if (Page.IsPostBack == false)
            {



                EntityOgrenci ent = new EntityOgrenci();
                List<EntityOgrenci> ogrList = BllOgrenci.BllDetay(x);
                TxtAd.Text = ogrList[0].Ograd.ToString();
                TxtSoyad.Text = ogrList[0].Ogrsoyad.ToString();
                TxtNumara.Text = ogrList[0].Ogrnumara.ToString();
                TxtSifre.Text = ogrList[0].Ogrsifre.ToString();
                TxtFotograf.Text = ogrList[0].Ogrfotograf.ToString();
            }




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ograd = TxtAd.Text;
            ent.Ogrsoyad = TxtSoyad.Text;
            ent.Ogrsifre = TxtSifre.Text;
            ent.Ogrnumara = TxtNumara.Text;
            ent.Ogrfotograf = TxtFotograf.Text;
            ent.Ogrid = Convert.ToInt32(Txtid.Text);
            BllOgrenci.ogrenciGuncelleBll(ent);
            Response.Redirect("OgrenciListesi.Aspx");
        }
    }
}