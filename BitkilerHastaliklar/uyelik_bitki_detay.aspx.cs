using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class uyelik_bitki_detay : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            int bitki_id = Convert.ToInt32(Request.QueryString["bitki_id"]);
            var hastaliklar = veritabani.hastaliklari_getir(bitki_id);

            var detaylar = from x in veritabani.bitki
                           where
                           x.bitki_id == bitki_id
                           select x;

            var listele = detaylar.ToList();
            Repeater1.DataSource = listele;
            Repeater1.DataBind();

            var hastaliklari_listele = hastaliklar.ToList();
            Repeater2.DataSource = hastaliklari_listele;
            Repeater2.DataBind();
        }
    }
}