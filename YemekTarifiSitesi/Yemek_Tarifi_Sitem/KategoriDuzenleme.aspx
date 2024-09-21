<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="KategoriDuzenleme.aspx.cs" Inherits="KategoriDuzenleme" %>

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
            <td class="auto-style8"><strong>KATEGORİ AD :</strong></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="213px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>ADET .</strong></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>RESİM :</strong></td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong></strong></td>
            <td>
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="16pt" Height="30px" OnClick="Button1_Click" Text="Güncelle" Width="150px" />
            </td>
        </tr>
    </table>
</asp:Content>

