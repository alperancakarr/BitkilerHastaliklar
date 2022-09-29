using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;
namespace BitkilerHastaliklarStaj
{
    public partial class bitki_sil_teyit : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            int silinecek_bitki = Convert.ToInt32(Request.QueryString["bitki_id"]);
            var tabloda_bul = veritabani.bitki.Find(silinecek_bitki);
            veritabani.bitki.Remove(tabloda_bul);
            veritabani.SaveChanges();
            Response.Redirect("bitki_sil.aspx");
        }
    }
}