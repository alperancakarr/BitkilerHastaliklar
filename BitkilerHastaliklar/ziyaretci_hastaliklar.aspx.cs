using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class ziyaretci_hastaliklar : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            var listele = veritabani.hastalik.ToList();
            Repeater1.DataSource = listele;
            Repeater1.DataBind();
        }

        protected void arama_butonu_Click(object sender, EventArgs e)
        {
            var filtrele = from hastaliklar in veritabani.hastalik
                        where
                        hastaliklar.hastalik_tr.ToLower().Contains(arama_kutusu.Text.ToLower()) || hastaliklar.hastalik_latin.ToLower().Contains(arama_kutusu.Text.ToLower())
                        select hastaliklar;


            if (filtrele.Any())
            {
                var filtreli_liste = filtrele.ToList();
                Repeater1.DataSource = filtreli_liste;
                Repeater1.DataBind();
            }
        }

       
    }
}