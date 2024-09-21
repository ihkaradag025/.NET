using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class YemeklerAdminDuzenleme : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.QueryString["Yemekid"];

        if (Page.IsPostBack == false)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Yemekler where Yemekid = @prm1", bgl.baglanti());
            komut.Parameters.AddWithValue("@prm1", id);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TextBox1.Text = dr[1].ToString();
                TextBox2.Text = dr[2].ToString();
                TextBox3.Text = dr[3].ToString();
                TextBox4.Text = dr[6].ToString();
                DropDownList1.SelectedValue = dr[7].ToString();
                

            }
            bgl.baglanti().Close();

        }

        if (Page.IsPostBack == false)
        {
                        
            ////kategori listesi yükleniyor
            SqlCommand komut2 = new SqlCommand("select * from Tbl_Kategoriler", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            DropDownList1.DataTextField = "KategoriAd";
            DropDownList1.DataValueField = "Kategoriid";
            DropDownList1.DataSource = dr2;
            DropDownList1.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand komut = new SqlCommand("update Tbl_Yemekler set YemekAd = @p1,YemekMalzeme = @p2,YemekTarif = @p3,YemekResim = @p4, YemekPuan =@p5,Kategoriid = @p6 where Yemekid = @p7", bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut.Parameters.AddWithValue("@p2", TextBox2.Text);
        komut.Parameters.AddWithValue("@p3", TextBox3.Text);
        komut.Parameters.AddWithValue("@p4", FileUpload1.FileName);
        komut.Parameters.AddWithValue("@p5", TextBox4.Text);
        komut.Parameters.AddWithValue("@P6", DropDownList1.SelectedValue);
        komut.Parameters.AddWithValue("@p7", id);
        komut.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}