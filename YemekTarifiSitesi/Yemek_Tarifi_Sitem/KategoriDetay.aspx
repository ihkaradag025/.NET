<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="KategoriDetay.aspx.cs" Inherits="KategoriDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style5 {
            font-size: x-large;
        }
        .auto-style6 {
            font-size: large;
        }
        .auto-style8 {
            height: 63px;
        }
        .auto-style7 {
            font-size: medium;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <asp:DataList ID="DataList2" runat="server" Width="444px">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td><strong><a href="YemekDetay.aspx?Yemekid=<%# Eval("Yemekid") %>">
                        <asp:Label ID="Label3" runat="server" BackColor="#FFFFCC" CssClass="auto-style5" ForeColor="#FF3300" Text='<%# Eval("YemekAd") %>'></asp:Label>
                        </a></strong></td>
                </tr>
                <tr>
                    <td><strong><span class="auto-style6">Malzemeler :</span></strong><asp:Label ID="Label4" runat="server" Text='<%# Eval("YemekMalzeme") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><span class="auto-style6"><strong>Yemek Tarifi :</strong></span><asp:Label ID="Label5" runat="server" Text='<%# Eval("YemekTarif") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8"><strong><span class="auto-style7">Eklenme Tarih :</span></strong>
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Yellow" Text='<%# Eval("YemekTarih") %>'></asp:Label>
                            &nbsp; Kategori :
                            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                            &nbsp;<strong><span class="auto-style6">Puan :&nbsp; </span>
                        <asp:Label ID="Label8" runat="server" CssClass="auto-style6" ForeColor="Yellow" Text='<%# Eval("YemekPuan") %>'></asp:Label>
                        </strong></td>
                </tr>
                <tr>
                    <td style="border-bottom-style: groove; border-bottom-width: thick; border-bottom-color: #C0C0C0">&nbsp;</td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</p>
</asp:Content>

