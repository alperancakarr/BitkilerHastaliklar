using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;
namespace BitkilerHastaliklarStaj
{
    public partial class kullanici_sil : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            var listele = veritabani.kullanici.ToList();
            Repeater1.DataSource = listele;
            Repeater1.DataBind();
        }
        protected void arama_butonu_Click(object sender, EventArgs e)
        {
            var filtrele = from kullanicilar in veritabani.kullanici
                           where
                           kullanicilar.kullanici_adi.ToLower().Contains(arama_kutusu.Text.ToLower()) || kullanicilar.kullanici_soyadi.ToLower().Contains(arama_kutusu.Text.ToLower()) || 
                           kullanicilar.kullanici_mail.ToLower().Contains(arama_kutusu.Text.ToLower())
                           select kullanicilar;


            if (filtrele.Any())
            {
                var filtreli_liste = filtrele.ToList();
                Repeater1.DataSource = filtreli_liste;
                Repeater1.DataBind();
            }
        }
    }
}