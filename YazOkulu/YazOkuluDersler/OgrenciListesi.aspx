<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListesi.aspx.cs" Inherits="OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">


    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID </th>
            <th style="width: 100px">Öğrenci Adı </th>
            <th>Öğrenci Soyadı </th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci Bakiye</th>
            <th>İşlemler</th>

        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <%--verileri listelemek için kullanılır--%>
                <ItemTemplate>
                    <%--repeater ın içindeki veriler bunun içine yazılır--%>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <%--buradaki evalin içine entityogrenci deki değerler yazılır 
                                                    katmanlı mimari kullanmasaydık sql deki veriler yazılırdı--%>
                        <td><%# Eval("AD") %></td>
                        <td><%# Eval("SOYAD") %></td>
                        <td><%# Eval("NUMARA") %></td>
                        <td><%# Eval("SIFRE") %></td>
                        <td><%# Eval("FOTOGRAF") %></td>
                        <td><%# Eval("BAKIYE") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciSil.aspx?OGRID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass=" btn btn-danger">SİL</asp:HyperLink>
                            <%--OGRID veri tabanındaki, ID ise EntityOgrenci deki değer--%>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciGuncelle.aspx?OGRID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>


</asp:Content>

