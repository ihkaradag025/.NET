﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class AdminYeniYetenekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLYETENEKLER tb = new TBLYETENEKLER();
            tb.YETENEK = TextBox1.Text;
            db.TBLYETENEKLER.Add(tb);
            db.SaveChanges();
            Response.Redirect("YeteneklerimAdmin.aspx");

        }
    }
}