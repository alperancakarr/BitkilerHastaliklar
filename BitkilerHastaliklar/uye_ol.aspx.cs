using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class uye_ol : System.Web.UI.Page
    {
        
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uyelik_butonu_Click(object sender, EventArgs e)
        {
            kullanici _kullanici = new kullanici();
            _kullanici.kullanici_adi = ad_kutusu.Text;
            _kullanici.kullanici_soyadi = soyad_kutusu.Text;
            _kullanici.kullanici_mail = mail_kutusu.Text;
            _kullanici.kullanici_sifre = sifre_kutusu.Text;
            _kullanici.kullanici_yoneticilik = 0;

            veritabani.kullanici.Add(_kullanici);
            veritabani.SaveChanges();

            ad_kutusu.Text = "";
            soyad_kutusu.Text = "";
            mail_kutusu.Text = "";
            sifre_kutusu.Text = "";

        }
    }
}