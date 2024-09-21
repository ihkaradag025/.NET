<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Iletisim.aspx.cs" Inherits="Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 135px;
        }
        .auto-style7 {
            height: 23px;
            width: 135px;
        }
        .auto-style8 {
            width: 135px;
            text-align: right;
        }
        .auto-style9 {
            background-color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3" colspan="2"><strong><span class="auto-style9">MESAJ PANELİ</span></strong></td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Ad Soyad :</strong></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="textboxyuvarlak" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Mail Adresiniz :</strong></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="textboxyuvarlak" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Konu :</strong></td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="textboxyuvarlak" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Mesaj :</strong></td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Height="61px" TextMode="MultiLine"  Width="269px" CssClass="textboxyuvarlak"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Larger" Height="32px" Text="Gönder" Width="179px" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

