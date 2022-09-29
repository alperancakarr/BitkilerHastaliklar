using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class bitki_guncelle_teyit : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int guncellenecek_bitki = Convert.ToInt32(Request.QueryString["bitki_id"]);
                var tabloda_bul = veritabani.bitki.Find(guncellenecek_bitki);

                bitki_id_kutusu.Text = tabloda_bul.bitki_id.ToString();
                bitki_tr_kutusu.Text = tabloda_bul.bitki_tr.ToString();
                bitki_latin_kutusu.Text = tabloda_bul.bitki_latin.ToString();
                bitki_fotograf_kutusu.Text = tabloda_bul.bitki_fotograf.ToString();
                bitki_detay_kutusu.Text = tabloda_bul.bitki_detay.ToString();
            }
        }
        protected void ekleme_butonu_Click(object sender, EventArgs e)
        {

            int guncellenecek_bitki = Convert.ToInt32(Request.QueryString["bitki_id"]);
            var tabloda_bul = veritabani.bitki.Find(guncellenecek_bitki);
            tabloda_bul.bitki_tr = bitki_tr_kutusu.Text;
            tabloda_bul.bitki_latin = bitki_latin_kutusu.Text;
            tabloda_bul.bitki_fotograf = bitki_fotograf_kutusu.Text;
            tabloda_bul.bitki_detay = bitki_detay_kutusu.Text;

            veritabani.SaveChanges();
            Response.Redirect("bitki_guncelle.aspx");
        }

    }
}