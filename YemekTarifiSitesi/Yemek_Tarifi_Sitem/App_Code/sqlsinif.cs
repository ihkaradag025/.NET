using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class sqlsinif
{
    public SqlConnection baglanti()
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=XY;Initial Catalog=DBO_yemektarifi;User ID=sa;Password=123456");
        baglan.Open();
        return baglan;
    }
}