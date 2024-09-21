<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="YemekDetay.aspx.cs" Inherits="YemekDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            font-size: xx-large;
            background-color: #CE7171;
        }
        .auto-style6 {
            font-size: x-small;
        }
        .auto-style7 {
            background-color: #FFFFFF;
        }
    .auto-style8 {
        height: 26px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>
    <asp:Label ID="Label3" runat="server" CssClass="auto-style5" ForeColor="#FFFFCC" Text="Label"></asp:Label>
    <br />
    </strong>
    <asp:DataList ID="DataList2" runat="server" Width="446px">
        <ItemTemplate>
            <table class="auto-style1" style="border-bottom-style: groove; border-bottom-width: thin; border-bottom-color: #FFFF00">
                <tr>
                    <td><strong>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                        </strong></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("Yorumicerik") %>'></asp:Label>
                        &nbsp;-
                        <asp:Label ID="Label6" runat="server" CssClass="auto-style6" Text='<%# Eval("YorumTarih") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <br />
    <div class="auto-style7">YORUM YAPMA PANELİ</div>
    <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td><strong>Ad Soyad :</strong></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8"><strong>Mail :</strong></td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox2" runat="server" Width="249px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><strong>Yorum :</strong></td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="66px" TextMode="MultiLine" Width="311px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="Segoe UI" Height="28px" OnClick="Button1_Click" Text="YORUM YAP" Width="137px" />
                </td>
            </tr>
        </table>
</asp:Panel>
</asp:Content>

