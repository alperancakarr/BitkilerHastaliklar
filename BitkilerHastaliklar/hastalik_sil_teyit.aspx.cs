using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class hastalik_sil_teyit : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            int silinecek_hastalik = Convert.ToInt32(Request.QueryString["hastalik_id"]);
            var tabloda_bul = veritabani.hastalik.Find(silinecek_hastalik);
            veritabani.hastalik.Remove(tabloda_bul);
            veritabani.SaveChanges();
            Response.Redirect("hastalik_sil.aspx");
        }
    }
}