using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntitiyLayer;
using BusinessLogicLayer;
using DataAccessLayer;

namespace _2_AspYazOkuluDersler
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(Page.IsPostBack == false)
            {
            
            List<EntityDersler> entDers = BllDers.BllDersListele();
            DropDownList1.DataSource = BllDers.BllDersListele();//DROPDOWNLİST1 İN VERİ KAYNAĞI NE OLSUN
            DropDownList1.DataTextField = "DersAd"; // data text field nedir kullanıcı panelinde bize gözükecek olan veri tabanı alanımız
            DropDownList1.DataValueField = "Dersid"; // burda yapmak istediğimiz arka planda tutacak olan değerimin değeri yani id değeri
            DropDownList1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString(); text boxa dersad ın id değerini yazdırdık

            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.Basvuruogrid = int.Parse(TextBox1.Text);
            ent.Basvurudersid = int.Parse(DropDownList1.SelectedValue.ToString());
            BllDers.derEkleBll(ent);
        }
    }
}