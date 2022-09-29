using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class kullanici_ekle : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ekleme_butonu_Click(object sender, EventArgs e)
        {
            kullanici _kullanici = new kullanici();
            _kullanici.kullanici_adi = ad_kutusu.Text;
            _kullanici.kullanici_soyadi = soyad_kutusu.Text;
            _kullanici.kullanici_mail = mail_kutusu.Text;
            _kullanici.kullanici_sifre = sifre_kutusu.Text;
            _kullanici.kullanici_yoneticilik = Convert.ToInt32(kullanici_tipi.SelectedValue);

            veritabani.kullanici.Add(_kullanici);
            veritabani.SaveChanges();

            ad_kutusu.Text = "";
            soyad_kutusu.Text = "";
            mail_kutusu.Text = "";
            sifre_kutusu.Text = "";
        }
    }
}