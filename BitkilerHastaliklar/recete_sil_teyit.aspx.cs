using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class recete_sil_teyit : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            int silinecek_recete = Convert.ToInt32(Request.QueryString["recete_id"]);
            var tabloda_bul = veritabani.recete.Find(silinecek_recete);
            veritabani.recete.Remove(tabloda_bul);
            veritabani.SaveChanges();
            Response.Redirect("recete_sil.aspx");
        }
    }
}