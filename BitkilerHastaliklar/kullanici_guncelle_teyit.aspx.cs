using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class kullanici_guncelle_teyit : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int guncellenecek_kullanici = Convert.ToInt32(Request.QueryString["kullanici_id"]);
                var tabloda_bul = veritabani.kullanici.Find(guncellenecek_kullanici);

                kullanici_id_kutusu.Text = tabloda_bul.kullanici_id.ToString();
                ad_kutusu.Text = tabloda_bul.kullanici_adi.ToString();
                soyad_kutusu.Text = tabloda_bul.kullanici_soyadi.ToString();
                mail_kutusu.Text = tabloda_bul.kullanici_mail.ToString();
                sifre_kutusu.Text = tabloda_bul.kullanici_sifre.ToString();
                kullanici_tipi_kutusu.Text = tabloda_bul.kullanici_yoneticilik.ToString();
            }
        }
        protected void ekleme_butonu_Click(object sender, EventArgs e)
        {

            int guncellenecek_kullanici = Convert.ToInt32(Request.QueryString["kullanici_id"]);
            var tabloda_bul = veritabani.kullanici.Find(guncellenecek_kullanici);

            tabloda_bul.kullanici_adi = ad_kutusu.Text;
            tabloda_bul.kullanici_soyadi = soyad_kutusu.Text;
            tabloda_bul.kullanici_mail = mail_kutusu.Text;
            tabloda_bul.kullanici_sifre = sifre_kutusu.Text;
            tabloda_bul.kullanici_yoneticilik = Convert.ToInt32(kullanici_tipi_kutusu.SelectedValue);

            veritabani.SaveChanges();
            Response.Redirect("kullanici_guncelle.aspx");
        }

    }
}