<%@ Page Title="" Language="C#" MasterPageFile="~/uyelik.Master" AutoEventWireup="true" CodeBehind="uyelik_bitkiler.aspx.cs" Inherits="BitkilerHastaliklarStaj.uyelik_bitkiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
    <style>
    table, th, td {
      margin-top:20px;
      border: 1px  black;
    }
    .image{
        border-radius: 20px 20px 20px 20px  ;
        overflow: hidden;
    }
    .button {
       background-color: white;
      border: none;
      color: white;
      width:70px;
      text-align:center;
      text-decoration: none;
      display: inline-block;
      height:30px;
      font-size: 15px;
      
      cursor: pointer;
      border-radius:10px;
    }
     .button1 {
      background-color: transparent;
      color: white;
      border: 2px solid white;
    }
     .button2 {
      background-color: transparent;
      color: white;
      border: 2px solid #4CAF50; 
    }
     input[type=text] {
      height:30px;
      width: 90%;
      border: 2px solid #ccc;
      border-radius: 10px;
      font-size: 15px;
      background-color: white;
      background-image: url('searchicon.png');
      background-position: 10px 10px; 
      background-repeat: no-repeat;
      padding: 12px 20px 12px 40px;
    }
     input[type=text]:focus {
      width: 90%;
    }

    </style>
    <form runat="server">
        <div align="center">
        <div><br /></div>
                <h2 style="width:80%; color:white">Bitkiler</h2>
    <div><br /></div></div>
    <asp:TextBox class="text"  ID="arama_kutusu" runat="server" placeholder="Bitki Ara..."></asp:TextBox>
    <asp:Button CssClass="button button1" ID="arama_butonu" runat="server" Text="Ara" OnClick="arama_butonu_Click"/>
    <div><br /></div>
    <table class="table table-condensed" >
        
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td>
                        <img class="image" src="<%#Eval("bitki_fotograf") %>" style="height:100px;width:150px;padding:5px"/>

                    </td>
                    <td>
                        <td>
                            <th style="color:darkorange">Bitki Adı (Türkçe)</th>
                            <th style="color:white; font-size:18px"><%#Eval("bitki_tr") %></th>
                        
                        </td>
                        <td>
                            <th style="color:darkorange">Bitki Adı (Latince)</th>
                            <th style="color:white; font-size:18px"><%#Eval("bitki_latin") %></th>
                       
                    </td>
                    <td><asp:HyperLink ID="HyperLink2" 
                        NavigateUrl='<%# "~/uyelik_bitki_detay.aspx?bitki_id="+Eval("bitki_id")%>'
                        runat="server" CssClass="button button1">Detay</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        
    </table>
    </form>
</asp:Content>
