<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="AdminYetenekGuncelle.aspx.cs" Inherits="CvEntityProje.AdminYetenekGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h4 style="margin-left:20px;">YETENEK GÜNCELLEME SAYFASI</h4>
    <br />  

    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" style="margin-left:20px;" placeholder="Yeteneği Yazınız"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server"  CssClass="btn btn-info" style="margin-left:20px;" Text="Kaydet" OnClick="Button1_Click"  />
</asp:Content>
