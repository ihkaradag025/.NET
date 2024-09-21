using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class YemeklerAdmin : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string yemek_id;
    string islem;
    string silinenyemek;
    protected void Page_Load(object sender, EventArgs e)
    {
       if (Page.IsPostBack == false)
        {
            yemek_id = Request.QueryString["Yemekid"];
            islem = Request.QueryString["islem"];
            ////kategori listesi yükleniyor
            SqlCommand komut2 = new SqlCommand("select * from Tbl_Kategoriler ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            DropDownList1.DataTextField = "KategoriAd";
            DropDownList1.DataValueField = "Kategoriid";
            DropDownList1.DataSource = dr2;
            DropDownList1.DataBind();
        }
        SqlCommand komut = new SqlCommand("select * from Tbl_Yemekler ", bgl.baglanti());
        SqlDataReader dr = komut.ExecuteReader();
        DataList1.DataSource = dr;
        DataList1.DataBind();
        bgl.baglanti().Close();

        


        //////silme işlemi 
        ///
        if (islem=="sil")
        {
            ///kategori adet eksiltme
            SqlCommand komut4 = new SqlCommand("Select * from Tbl_Yemekler where Yemekid = @pr1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@pr1", yemek_id);
            SqlDataReader dr2 = komut4.ExecuteReader();
            while (dr2.Read())
            {
               silinenyemek = dr2[7].ToString();
            }
            bgl.baglanti().Close();


            SqlCommand komut3 = new SqlCommand("delete from Tbl_Yemekler where Yemekid = @p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", yemek_id);

            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();

            
            
            SqlCommand komut5 = new SqlCommand("Update Tbl_Kategoriler set KategoriAdet = KategoriAdet-1 where Kategoriid = @prm1", bgl.baglanti());
            komut5.Parameters.AddWithValue("@prm1",silinenyemek);
            komut5.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        Panel2.Visible = false;
        Panel4.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel4.Visible = true;
    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        SqlCommand komut = new SqlCommand("insert into Tbl_Yemekler (YemekAd,YemekMalzeme,YemekTarif,YemekResim,Kategoriid) values(@p1,@p2,@p3,@p4,@p5) ", bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut.Parameters.AddWithValue("@p2", TextBox2.Text);
        komut.Parameters.AddWithValue("@p3", TextBox3.Text);
        komut.Parameters.AddWithValue("@P4", FileUpload3.FileName);
        komut.Parameters.AddWithValue("@P5", DropDownList1.SelectedValue);
        komut.ExecuteNonQuery();
        bgl.baglanti().Close();

        ///kategori adeti artırma
        SqlCommand komut2 = new SqlCommand("Update Tbl_Kategoriler set KategoriAdet = KategoriAdet+1 where Kategoriid = @prm1", bgl.baglanti());
        komut2.Parameters.AddWithValue("@prm1", DropDownList1.SelectedValue);
        komut2.ExecuteNonQuery();
        bgl.baglanti().Close();

    }
}