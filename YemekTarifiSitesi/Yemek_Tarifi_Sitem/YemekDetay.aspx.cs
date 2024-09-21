using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class YemekDetay : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string yemek_id ="";

    protected void Page_Load(object sender, EventArgs e)
    {
        yemek_id = Request.QueryString["Yemekid"];
        SqlCommand komut = new SqlCommand("Select YemekAd From Tbl_Yemekler Where Yemekid =@p1",bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", yemek_id);
        SqlDataReader dr = komut.ExecuteReader();
        while (dr.Read())
        {
            Label3.Text = dr[0].ToString();
        }
        bgl.baglanti().Close();

        ///YORUMLARI LİSTELEME
        ///
        SqlCommand komut1 =  new SqlCommand("Select * from Tbl_Yorumlar where Yemekid = @p2", bgl.baglanti());
        komut1.Parameters.AddWithValue("@p2", yemek_id);
        SqlDataReader dr1 = komut1.ExecuteReader();
        DataList2.DataSource=dr1;
        DataList2.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand komut = new SqlCommand("insert into Tbl_Yorumlar (YorumAdSoyad,YorumMail,Yorumicerik,Yemekid) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut.Parameters.AddWithValue("@p2", TextBox2.Text);
        komut.Parameters.AddWithValue("@p3", TextBox3.Text);
        komut.Parameters.AddWithValue("@p4", yemek_id);
        komut.ExecuteNonQuery();
        bgl.baglanti().Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        Response.Write("Tarifiniz Eklenmiştir.");
    }
}