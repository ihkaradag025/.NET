using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AdminYorumDetay : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.QueryString["Yorumid"];

        if (Page.IsPostBack == false)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Yorumlar YR inner join Tbl_Yemekler YM ON (YR.Yemekid = YM.Yemekid) where Yorumid = @prm1", bgl.baglanti());
            komut.Parameters.AddWithValue("@prm1", id);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TextBox1.Text = dr[1].ToString();
                TextBox2.Text = dr[2].ToString();
                TextBox3.Text = dr[5].ToString();
                TextBox4.Text = dr[8].ToString();
            }
            bgl.baglanti().Close();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand komut = new SqlCommand("update Tbl_Yorumlar set YorumOnay = 1 where Yorumid = @p1", bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", id);
        komut.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}