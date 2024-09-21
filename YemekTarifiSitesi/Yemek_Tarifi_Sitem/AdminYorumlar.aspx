<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminYorumlar.aspx.cs" Inherits="AdminYorumlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            font-size: x-large;
        }
        .auto-style10 {
            
            height: 44px;
            text-align: left;
            width: 594px;
        }
        .auto-style11 {
            font-weight: bold;
            font-size: x-large;
        }
        .auto-style12 {
            width: 30px;
        }
        .auto-style14 {
            text-align: right;
            
            height: 44px;
            width: 196px;
        }
        .auto-style15 {
            width: 423px;
        }
        .auto-style16 {
            height: 44px;
            text-align: right;
            width: 305px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCCC">
        <table class="auto-style6">
            <tr>
                <td class="auto-style12"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style11" Height="30px"  Text="+" Width="30px" OnClick="Button1_Click" />
                    </strong></td>
                <td class="auto-style12">
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style9" Height="30px"  Text="-" Width="30px" OnClick="Button2_Click" />
                </td>
                <td><strong>ONAYLI YORUM LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="446px">
            <ItemTemplate>
                <table class="auto-style15">
                    <tr>
                        <td class="auto-style10">
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style9" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                        </td>
                        <td class="auto-style16">
                           <a href="AdminYorumlar.aspx?Yorumid=<%#Eval("Yorumid") %>&islem=sil"><asp:Image ID="Image2" runat="server" Height="40px" ImageUrl="~/Resim/delete.png" Width="40px" /></a> 
                        </td>
                        <td class="auto-style14">
                            <a href="AdminYorumDetay.aspx?Yorumid=<%#Eval("Yorumid")%>"> <asp:Image ID="Image3" runat="server" Height="40px" Width="40px" ImageUrl="~/Resim/update.png" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" BackColor="#CCCCCC">
        <table class="auto-style6">
            <tr>
                <td class="auto-style12"><strong>
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style11" Height="30px"  Text="+" Width="30px" OnClick="Button3_Click" />
                    </strong></td>
                <td class="auto-style12">
                    <asp:Button ID="Button4" runat="server" CssClass="auto-style9" Height="30px"  Text="-" Width="30px" OnClick="Button4_Click" />
                </td>
                <td><strong>ONAYSIZ YORUM LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <asp:DataList ID="DataList2" runat="server" Width="446px">
            <ItemTemplate>
                <table class="auto-style15">
                    <tr>
                        <td class="auto-style10">
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style9" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                        </td>
                        <td class="auto-style16">
                           <a href="AdminYorumlar.aspx?Yorumid=<%#Eval("Yorumid") %>&islem=sil"><asp:Image ID="Image2" runat="server" Height="40px" ImageUrl="~/Resim/delete.png" Width="40px" /></a> 
                        </td>
                        <td class="auto-style14">
                            <a href="AdminYorumDetay.aspx?Yorumid=<%#Eval("Yorumid")%>"> <asp:Image ID="Image3" runat="server" Height="40px" Width="40px" ImageUrl="~/Resim/update.png" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>

     </asp:Content>

