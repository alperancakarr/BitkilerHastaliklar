<%@ Page Title="" Language="C#" MasterPageFile="~/ziyaretci.Master" AutoEventWireup="true" CodeBehind="ziyaretci_bitki_detay.aspx.cs" Inherits="BitkilerHastaliklarStaj.ziyaretci_bitki_detay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style>
        img {
          border-radius: 20px 20px 20px 20px  ;
        overflow: hidden;  
        }
        table
        { 
        margin-left: 5px;
        margin-right: 5px;
        }
    </style>
    <form runat="server">
     
    <table >
        
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                     <td style="margin-top:    10px">
                        <img class="image"  src="<%#Eval("bitki_fotograf") %>" style="height:300px;width:450px;padding:5px"/>

                    </td>
                    <td>
                        <tr>
                            <th style="color:darkorange">Bitki Adı (Türkçe)</th>
                        </tr>
                        <tr>
                            <th style="color:white; font-size:15px"><%#Eval("bitki_tr") %></th>
                        </tr>
                        <tr>
                            <th style="color:darkorange">Bitki Adı (Latince)</th>
                        </tr>
                        <tr>
                            <th style="color:white; font-size:15px"><%#Eval("bitki_latin") %></th>
                        </tr>
                        <tr>
                            <th style="color:darkorange">Bitki Detay</th>
                        </tr>
                        <tr>
                            <th style="color:white; font-size:15px"><%#Eval("bitki_detay") %></th>
                        </tr>
                   

                    </td>
                   
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        <tr>
             
                            <tr>
                                     <th style="color:darkorange">Bu bitkinin iyi geldiği hastalıklar</th>
                                </tr>
                            <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <th style="color:white; font-size:15px"><%#Eval("hastalik_tr") %></th>

                                </tr>
                            </ItemTemplate>
                            </asp:Repeater>
                        
        </tr>
        
    </table>
    </form>
</asp:Content>
