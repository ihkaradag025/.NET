<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="YemeklerAdminDuzenleme.aspx.cs" Inherits="YemeklerAdminDuzenleme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style8 {
            text-align: right;
        }
        .auto-style9 {
            text-align: right;
            height: 35px;
        }
        .auto-style10 {
            height: 35px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style8"><strong>YEMEK AD :</strong></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="281px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>MALZEME .</strong></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="118px" TextMode="MultiLine" Width="283px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9"><strong>TARİF:</strong></td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox3" runat="server" Height="96px" TextMode="MultiLine" Width="282px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>RESİM : </strong></td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>PUAN : </strong></td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Width="41px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>KATEGORİ :</strong></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="24px" Width="199px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="16pt" Height="30px" OnClick="Button1_Click" Text="Güncelle" Width="150px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

