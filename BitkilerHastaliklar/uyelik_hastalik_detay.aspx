<%@ Page Title="" Language="C#" MasterPageFile="~/uyelik.Master" AutoEventWireup="true" CodeBehind="uyelik_hastalik_detay.aspx.cs" Inherits="BitkilerHastaliklarStaj.uyelik_hastalik_detay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style>
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
                    <td>
                        <tr>
                            <th style="color:darkorange">Hastalık Adı (Türkçe)</th>
                        </tr>
                        <tr>
                            <th style="color:white; font-size:15px"><%#Eval("hastalik_tr") %></th>
                        </tr>
                        <tr>
                            <th style="color:darkorange">Hastalık Adı (Latince)</th>
                        </tr>
                        <tr>
                            <th style="color:white; font-size:15px"><%#Eval("hastalik_latin") %></th>
                        </tr>
                        <tr>
                            <th style="color:darkorange">Hastalık Tanım</th>
                        </tr>
                        <tr>
                            <th style="color:white; font-size:15px"><%#Eval("hastalik_tanim") %></th>
                        </tr>
                         <tr>
                            <th style="color:darkorange">Hastalık Detay</th>
                        </tr>
                        <tr>
                            <th style="color:white; font-size:15px"><%#Eval("hastalik_detay") %></th>
                        </tr>

                   

                    </td>
                   
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        <tr>
             
                            
                                <tr>
                                     <th style="color:darkorange">Bu hastalığa iyi gelen bitkiler</th>
                                </tr>
                            <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <th style="color:white; font-size:15px"><%#Eval("bitki_tr") %></th>

                                </tr>
                            </ItemTemplate>
                            </asp:Repeater>
                        
        </tr>
        
    </table>
    </form>
</asp:Content>
