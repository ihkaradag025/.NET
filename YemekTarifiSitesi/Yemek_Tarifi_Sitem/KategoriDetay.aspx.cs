using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class KategoriDetay : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string kategori_id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        kategori_id = Request.QueryString["Kategoriid"];
        SqlCommand komut = new SqlCommand("select * from Tbl_Yemekler where Kategoriid =@prm1", bgl.baglanti());
        komut.Parameters.AddWithValue("@prm1", kategori_id);
        SqlDataReader dr = komut.ExecuteReader();
        DataList2.DataSource = dr;
        DataList2.DataBind();
        bgl.baglanti().Close();
    }
}