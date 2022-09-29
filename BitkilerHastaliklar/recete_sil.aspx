<%@ Page Title="" Language="C#" MasterPageFile="~/yonetici.Master" AutoEventWireup="true" CodeBehind="recete_sil.aspx.cs" Inherits="BitkilerHastaliklarStaj.recete_sil" %>
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
      width:60px;
      text-decoration: none;
      display: inline-block;
      height:30px;
      font-size: 15px;
      text-align:center;
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
      width: 50%;
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
      width: 50%;
    }
     .center {
  margin-left: auto;
  margin-right: auto;
}


    </style>
    <form runat="server">
        <div align="center">
    <div><br /></div>
        <h2 style="width:80%; color:white">Reçete Silme</h2>
    <div><br /></div>
    <table class="table table-condensed" style="width:80%">
        
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                   
                    <td>
                        <td>
                            <th style="color:darkorange">Reçete ID</th>
                            <th style="color:white; font-size:18px"><%#Eval("recete_id") %></th>
                        
                        </td>                       
                    </td>
                    <td>
                        <td>
                            <th style="color:darkorange">Bitki ID</th>
                            <th style="color:white; font-size:18px"><%#Eval("recete_bitki_id") %></th>
                        
                        </td>
                        <td>
                            <th style="color:darkorange">Hastalık ID</th>
                            <th style="color:white; font-size:18px"><%#Eval("recete_hastalik_id") %></th>
                       
                    </td>
                    <td><asp:HyperLink ID="HyperLink2" 
                        NavigateUrl='<%# "~/recete_sil_teyit.aspx?recete_id="+Eval("recete_id")%>'
                        runat="server" CssClass="button button1">Sil</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        
    </table></div>
    </form>
</asp:Content>
