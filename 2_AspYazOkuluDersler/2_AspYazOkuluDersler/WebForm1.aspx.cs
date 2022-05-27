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
    public partial class WebForm1 : System.Web.UI.Page
    {   
        public void temizle()
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtNumara.Text = "";
            TxtSifre.Text = "";
            TxtFotograf.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ograd = TxtAd.Text;
            ent.Ogrsoyad = TxtSoyad.Text;
            ent.Ogrnumara = TxtNumara.Text;
            ent.Ogrsifre = TxtSifre.Text;
            ent.Ogrfotograf = TxtFotograf.Text
                ;
            BllOgrenci.ogrenciEkleBll(ent);
            temizle();
        }
    }
}