using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class ziyaretci_hastalik_detay : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            int hastalik_id = Convert.ToInt32(Request.QueryString["hastalik_id"]);
            var bitkiler = veritabani.bitkileri_getir(hastalik_id);

            var detaylar = from x in veritabani.hastalik
                           where
                           x.hastalik_id == hastalik_id
                           select x;

            var listele = detaylar.ToList();
            Repeater1.DataSource = listele;
            Repeater1.DataBind();

            var bitkileri_listele = bitkiler.ToList();
            Repeater2.DataSource = bitkileri_listele;
            Repeater2.DataBind();
        }
    }
}