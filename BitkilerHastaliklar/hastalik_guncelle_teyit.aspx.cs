using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class hastalik_guncelle_teyit : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int guncellenecek_hastaslik = Convert.ToInt32(Request.QueryString["hastalik_id"]);
                var tabloda_bul = veritabani.hastalik.Find(guncellenecek_hastaslik);

                hastalik_id_kutusu.Text = tabloda_bul.hastalik_id.ToString();
                hastalik_tr_kutusu.Text = tabloda_bul.hastalik_tr.ToString();
                hastalik_latin_kutusu.Text = tabloda_bul.hastalik_latin.ToString();
                hastalik_tanim_kutusu.Text = tabloda_bul.hastalik_tanim.ToString();
                hastalik_detay_kutusu.Text = tabloda_bul.hastalik_detay.ToString();
            }
        }
        protected void ekleme_butonu_Click(object sender, EventArgs e)
        {

            int guncellenecek_hastalik = Convert.ToInt32(Request.QueryString["hastalik_id"]);
            var tabloda_bul = veritabani.hastalik.Find(guncellenecek_hastalik);
            tabloda_bul.hastalik_tr = hastalik_tr_kutusu.Text;
            tabloda_bul.hastalik_latin = hastalik_latin_kutusu.Text;
            tabloda_bul.hastalik_tanim = hastalik_tanim_kutusu.Text;
            tabloda_bul.hastalik_detay = hastalik_detay_kutusu.Text;

            veritabani.SaveChanges();
            Response.Redirect("hastalik_guncelle.aspx");
        }

    }
}