using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BitkilerHastaliklarStaj.Veritabani;

namespace BitkilerHastaliklarStaj
{
    public partial class recete_ekle : System.Web.UI.Page
    {
        BitkilerHastaliklarStajEntities2 veritabani = new BitkilerHastaliklarStajEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ekleme_butonu_Click(object sender, EventArgs e)
        {
            recete _recete = new recete();
            _recete.recete_bitki_id = Convert.ToInt32(recete_bitki_id_kutusu.Text);
            _recete.recete_hastalik_id = Convert.ToInt32(recete_hastalik_id_kutusu.Text);

            veritabani.recete.Add(_recete);
            veritabani.SaveChanges();

            recete_bitki_id_kutusu.Text = "";
            recete_hastalik_id_kutusu.Text = "";

        }

    }
}