using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class bitki_guncelle : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            var listele = veritabani.bitki.ToList();
            Repeater1.DataSource = listele;
            Repeater1.DataBind();
        }
        protected void arama_butonu_Click(object sender, EventArgs e)
        {
            var filtrele = from bitkiler in veritabani.bitki
                           where
                           bitkiler.bitki_tr.ToLower().Contains(arama_kutusu.Text.ToLower()) || bitkiler.bitki_latin.ToLower().Contains(arama_kutusu.Text.ToLower())
                           select bitkiler;


            if (filtrele.Any())
            {
                var filtreli_liste = filtrele.ToList();
                Repeater1.DataSource = filtreli_liste;
                Repeater1.DataBind();
            }
        }
    }
}