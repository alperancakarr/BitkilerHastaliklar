<%@ Page Title="" Language="C#" MasterPageFile="~/yonetici.Master" AutoEventWireup="true" CodeBehind="hastalik_ekle.aspx.cs" Inherits="BitkilerHastaliklarStaj.hastalik_ekle" %>
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
                <h2 style="width:80%; color:white">Hastalık Ekleme</h2>
            </tr>
            <div>
                <br />
            </div>
            <tr>
                <asp:TextBox class="text" type="text" ID="hastalik_tr_kutusu" runat="server" placeholder="Hastalık Adı (Türkçe)"></asp:TextBox>
            </tr>
            <tr>
                <asp:TextBox class="text"  type="text" ID="hastalik_latin_kutusu" runat="server" placeholder="Hastalık Adı (Latince)"></asp:TextBox>
            </tr>
            <tr>
                <asp:TextBox class="text"  type="text" ID="hastalik_tanim_kutusu" runat="server" placeholder="Hastalık Tanım"></asp:TextBox>
            </tr>
            <tr>
                <asp:TextBox class="text"  type="text" ID="hastalik_detay_kutusu" runat="server" placeholder="Hastalık Detay" height="100px"></asp:TextBox>
            </tr>
            <div>
                <br />
            </div>
            <tr>
                
                <asp:Button CssClass="button button1" ID="ekleme_butonu" runat="server" Text="Ekle" OnClick="ekleme_butonu_Click" />
            </tr>
        </table>
    </form>
    </div>
</asp:Content>