<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Hakkimizda.aspx.cs" Inherits="Hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList2" runat="server" Width="446px">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Hakkimizda") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <br />
    <asp:Image ID="Image1" runat="server" Height="160px" ImageUrl="~/Resim/team_hakkimzda.jpg" Width="449px" BorderColor="Yellow" BorderStyle="Groove" BorderWidth="1px" />

</asp:Content>

