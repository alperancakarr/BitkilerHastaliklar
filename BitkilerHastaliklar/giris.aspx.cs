using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class giris : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from kullanici in veritabani.kullanici
                        where
                        kullanici.kullanici_mail == mail_kutusu.Text && kullanici.kullanici_sifre == sifre_kutusu.Text &&
                        kullanici.kullanici_yoneticilik == 0
                        select kullanici;

            var sorgu1 = from kullanici in veritabani.kullanici
                         where
                         kullanici.kullanici_mail == mail_kutusu.Text && kullanici.kullanici_sifre == sifre_kutusu.Text &&
                         kullanici.kullanici_yoneticilik == 1
                         select kullanici;

            if (sorgu.Any())
            {
                Response.Redirect("uyelik_anasayfa.aspx");
            }
            else if (sorgu1.Any())
            {
                Response.Redirect("yonetici_anasayfa.aspx");
            }
            else
            {
                Response.Write("Kullanıcı adı ya da şifre hatalı");
            }
        }
    }
}