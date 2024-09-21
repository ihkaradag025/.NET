<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminYorumDetay.aspx.cs" Inherits="AdminYorumDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style8 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style8"><strong>AD SOYAD :</strong></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="213px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>MAİL: </strong>&nbsp; </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="211px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>İÇERİK :</strong></td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Height="69px" TextMode="MultiLine" Width="191px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>YEMEK :</strong></td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Width="188px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="16pt" Height="30px" OnClick="Button1_Click" Text="Onayla" Width="150px" />
            </td>
        </tr>
    </table>
</asp:Content>

