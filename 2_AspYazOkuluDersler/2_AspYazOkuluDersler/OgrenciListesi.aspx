<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="_2_AspYazOkuluDersler.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Ogrenci Id</th>
            <th>Ogrenci Ad</th>
            <th>Ogrenci Soyad</th>
            <th>Ogrenci Numara</th>
            <th>Ogrenci Sifre</th>
            <th>Ogrenci Fotograf</th>
            <th>Bakiye</th>
            <th>İşlemler</th>
            
6
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Ogrid")%></td>
                        <td><%#Eval("Ograd")%></td>
                        <td><%#Eval("Ogrsoyad")%></td>
                        <td><%#Eval("Ogrnumara")%></td>
                        <td><%#Eval("OgrSifre")%></td>
                        <td><%#Eval("OgrFotograf")%></td>
                        <td><%#Eval("Ogrbakiye")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciSil.aspx?ogrid="+ Eval("Ogrid")%>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciGuncelle.aspx?Ogrid="+ Eval("Ogrid")%>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
