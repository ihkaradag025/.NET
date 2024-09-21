<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Kategoriler.aspx.cs" Inherits="Kategoriler" %>

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
        .auto-style17 {
            font-weight: bold;
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCCC">
        <table class="auto-style6">
            <tr>
                <td class="auto-style12"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style11" Height="30px" OnClick="Button1_Click" Text="+" Width="30px" />
                    </strong></td>
                <td class="auto-style12">
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style9" Height="30px" OnClick="Button2_Click" Text="-" Width="30px" />
                </td>
                <td><strong>KATEGORİ LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="446px">
            <ItemTemplate>
                <table class="auto-style15">
                    <tr>
                        <td class="auto-style10">
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style9" Text='<%# Eval("KategoriAd") %>'></asp:Label>
                        </td>
                        <td class="auto-style16">
                           <a href="Kategoriler.aspx?Kategoriid=<%#Eval("Kategoriid") %>&islem=sil"><asp:Image ID="Image2" runat="server" Height="40px" ImageUrl="~/Resim/delete.png" Width="40px" /></a> 
                        </td>
                        <td class="auto-style14">
                            <a href="KategoriDuzenleme.aspx?Kategoriid=<%#Eval("Kategoriid")%>"> <asp:Image ID="Image3" runat="server" Height="40px" Width="40px" ImageUrl="~/Resim/update.png" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>

     <asp:Panel ID="Panel3" runat="server" style="background-color : #CCCCCC; margin-top : 15px;">
        <table class="auto-style6">
            <tr>
                <td class="auto-style12"><strong>
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style11" Height="30px"  Text="+" Width="30px" OnClick="Button3_Click" />
                    </strong></td>
                <td class="auto-style12">
                    <asp:Button ID="Button4" runat="server" CssClass="auto-style9" Height="30px"  Text="-" Width="30px" OnClick="Button4_Click" />
                </td>
                <td><strong>KATEGORİ EKLEME</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <table class="auto-style6">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Kategori Ad :</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="215px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Kategori İkon</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="222px" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td><strong>
                    <asp:Button ID="btnEkle" runat="server" CssClass="auto-style17" Height="32px" Text="EKLE" Width="162px" OnClick="btnEkle_Click" />
                    </strong></td>
            </tr>
        </table>
    </asp:Panel>

</asp:Content>

