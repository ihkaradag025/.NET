<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="GununYemegi.aspx.cs" Inherits="GununYemegi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            font-size: large;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6"><strong>
                        <asp:Label ID="Label8" runat="server" CssClass="auto-style5" Text='<%# Eval("GununYemegiAd") %>'></asp:Label>
                        </strong></td>
                </tr>
                <tr>
                    <td class="auto-style7"><strong>Malzemeler : </strong>
                        <asp:Label ID="Label9" runat="server" Text='<%# Eval("GununYemegiMalzeme") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><strong>Tarif : </strong>
                        <asp:Label ID="Label10" runat="server" Text='<%# Eval("GununYemegiTarif") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image2" runat="server" Height="247px" ImageUrl='<%# Eval("GununYemegiResim") %>' Width="421px" />
                    </td>
                </tr>
                <tr>
                    <td><strong>Puan :</strong>
                        <asp:Label ID="Label11" runat="server" Text='<%# Eval("GununYemegiPuan") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><strong>Ekleme Tarihi : </strong>
                        <asp:Label ID="Label12" runat="server" Text='<%# Eval("GununYemegiTarih") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

