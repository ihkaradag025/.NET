<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="TarifOner.aspx.cs" Inherits="TarifOner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style5 {
        width: 107px;
    }
    .auto-style6 {
        width: 107px;
        height: 21px;
        text-align: right;
    }
    .auto-style7 {
        height: 21px;
    }
    .auto-style8 {
        width: 107px;
        text-align: right;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6">Tarif Ad:</td>
        <td class="auto-style7">
            <asp:TextBox ID="TxtTarifAd" runat="server" Height="15px" Width="300px" CssClass="textboxyuvarlak"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Malzemeler :</td>
        <td>
            <asp:TextBox ID="TxtMalzemeler" runat="server" Height="89px" TextMode="MultiLine" Width="268px" CssClass="textboxyuvarlak"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Yapılışı :</td>
        <td>
            <asp:TextBox ID="TxtYapilis" runat="server" Height="146px" TextMode="MultiLine" Width="267px" CssClass="textboxyuvarlak"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Resim:</td>
        <td>
            <asp:FileUpload ID="FluResim" runat="server" Width="300px" CssClass="textboxyuvarlak" />
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Tarif Öneren :</td>
        <td>
            <asp:TextBox ID="TxtTarifOneren" runat="server" Height="15px" Width="300px" CssClass="textboxyuvarlak"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">MAil Adresi :</td>
        <td>
            <asp:TextBox ID="TxtMailAdres" runat="server" Height="15px" TextMode="Email" Width="300px" CssClass="textboxyuvarlak"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnTarifOner" runat="server" Font-Bold="True" Font-Size="Large" Text="Tarif Öner" Width="139px" OnClick="BtnTarifOner_Click" />
        </td>
    </tr>
</table>
</asp:Content>

