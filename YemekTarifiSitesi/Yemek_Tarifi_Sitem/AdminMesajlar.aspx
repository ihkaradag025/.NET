<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminMesajlar.aspx.cs" Inherits="AdminMesajlar" %>

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
        .auto-style15 {
            width: 423px;
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
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style11" Height="30px" Text="+" Width="30px" OnClick="Button1_Click1" />
                    </strong></td>
                <td class="auto-style12">
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style9" Height="30px"  Text="-" Width="30px" OnClick="Button2_Click1" />
                </td>
                <td><strong>MESAJ LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="446px">
            <ItemTemplate>
                <table class="auto-style15">
                    <tr>
                        <td class="auto-style10">
                            <table class="auto-style6">
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td>Mesaj Gönderen :</td>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("MesajGonderen") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Başlık : </td>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("MesajBaslik") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Mail Adresi : </td>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("MesajMail") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="border-bottom-style: groove; border-bottom-width: medium; border-bottom-color: #FFFF00">Mesaj İçerik : </td>
                                    <td style="border-bottom-style: groove; border-bottom-width: medium; border-bottom-color: #FFFF00">
                                        <asp:TextBox ID="TextBox4" runat="server" Height="51px" Text='<%# Eval("Mesajicerik") %>' TextMode="MultiLine" Width="212px"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>

     

</asp:Content>

