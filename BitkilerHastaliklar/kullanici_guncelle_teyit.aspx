<%@ Page Title="" Language="C#" MasterPageFile="~/yonetici.Master" AutoEventWireup="true" CodeBehind="kullanici_guncelle_teyit.aspx.cs" Inherits="BitkilerHastaliklarStaj.kullanici_guncelle_teyit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style>
   input[type=text], select {
  width: 80%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
  text-align:center;
  margin-right:auto;

    
}
.text{
     width: 80%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
  text-align:center;
  margin-right:auto;

}

.button {
      background-color: white; 
      border: none;
      color: white;
      padding: 15px 32px;
      text-align: center;
      text-decoration: none;
      display: inline-block;
      font-size: 10px;
      margin: 4px 2px;
      cursor: pointer;
      border-radius:10px;
    }
     .button1 {
      background-color: transparent;
      color: white;
      border: 2px solid white; 
      width:80%;
    }
.center {
  margin-left: auto;
  margin-right: auto;
}



</style>
    <div align="center">
    <form class="" runat="server" >
        <table class="center">
            <div>
                <br />
            </div>
            <tr>
                <h2 style="width:80%; color:white">Kullanıcı Güncelleme</h2>
            </tr>
            <div>
                <br />
            </div>
            <tr>
                <asp:TextBox class="text" type="text" ID="kullanici_id_kutusu" runat="server" placeholder="ID"></asp:TextBox>
            </tr>
            <tr>
                <asp:TextBox class="text" type="text" ID="ad_kutusu" runat="server" placeholder="Ad"></asp:TextBox>
            </tr>
            <tr>
                <asp:TextBox class="text"  type="text" ID="soyad_kutusu" runat="server" placeholder="Soyad"></asp:TextBox>
            </tr>
            <tr>
                <asp:TextBox class="text"  type="text" ID="mail_kutusu" runat="server" placeholder="E-mail"></asp:TextBox>
            </tr>
            <tr>
                <asp:TextBox class="text"  type="password" ID="sifre_kutusu" runat="server" placeholder="Şifre" ></asp:TextBox>
            </tr>
            <div>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Kullanıcı Tipi" Font-Bold="true"></asp:Label>
            </div>
            <tr>
                <asp:DropDownList ID="kullanici_tipi_kutusu" runat="server" Height="40px">
						 <asp:ListItem Enabled="true" Text="Kullanıcı" Value="0"></asp:ListItem>
						 <asp:ListItem Text="Yönetici" Value="1"></asp:ListItem>
					</asp:DropDownList>
            </tr>
            <div>
                <br />
            </div>
            <tr>
                
                <asp:Button CssClass="button button1" ID="ekleme_butonu" runat="server" Text="Güncelle" OnClick="ekleme_butonu_Click" />
            </tr>
        </table>
    </form>
    </div>
</asp:Content>
