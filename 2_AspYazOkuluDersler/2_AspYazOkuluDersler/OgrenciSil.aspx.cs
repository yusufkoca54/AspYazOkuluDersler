using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EntitiyLayer;
using BusinessLogicLayer;
using DataAccessLayer;

namespace _2_AspYazOkuluDersler
{
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ogrid"].ToString());
            Response.Write(x);
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ogrid = x;
            BllOgrenci.ogrencisilBll(ent.Ogrid);
            Response.Redirect("OgrenciListesi.Aspx");// Tekrar Beni Yönlendir Ogrenci Listesi Aspx Sayfasına
        }
    }
}