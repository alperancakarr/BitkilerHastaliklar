using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class kullanici_sil_teyit : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            int silinecek_kullanici = Convert.ToInt32(Request.QueryString["kullanici_id"]);
            var tabloda_bul = veritabani.kullanici.Find(silinecek_kullanici);
            veritabani.kullanici.Remove(tabloda_bul);
            veritabani.SaveChanges();
            Response.Redirect("kullanici_sil.aspx");
        }
    }
}