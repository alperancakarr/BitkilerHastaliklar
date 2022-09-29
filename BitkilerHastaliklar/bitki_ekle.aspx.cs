using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class bitki_ekle : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ekleme_butonu_Click(object sender, EventArgs e)
        {
            bitki _bitki = new bitki();
            _bitki.bitki_tr = bitki_tr_kutusu.Text;
            _bitki.bitki_latin = bitki_latin_kutusu.Text;
            _bitki.bitki_fotograf = bitki_fotograf_kutusu.Text;
            _bitki.bitki_detay = bitki_detay_kutusu.Text;

            veritabani.bitki.Add(_bitki);
            veritabani.SaveChanges();

            bitki_tr_kutusu.Text = "";
            bitki_latin_kutusu.Text = "";
            bitki_fotograf_kutusu.Text = "";
            bitki_detay_kutusu.Text = "";


        }

     
    }
}