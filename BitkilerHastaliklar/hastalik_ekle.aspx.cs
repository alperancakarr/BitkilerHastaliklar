using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class hastalik_ekle : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ekleme_butonu_Click(object sender, EventArgs e)
        {


            hastalik _hastalik = new hastalik();
            _hastalik.hastalik_tr = hastalik_tr_kutusu.Text;
            _hastalik.hastalik_latin = hastalik_latin_kutusu.Text;
            _hastalik.hastalik_tanim = hastalik_tanim_kutusu.Text;
            _hastalik.hastalik_detay = hastalik_detay_kutusu.Text;

            veritabani.hastalik.Add(_hastalik);
            veritabani.SaveChanges();

            hastalik_tr_kutusu.Text = "";
            hastalik_latin_kutusu.Text = "";
            hastalik_tanim_kutusu.Text = "";
            hastalik_detay_kutusu.Text = "";

        }
    }
}