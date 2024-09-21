using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class AdminYetenekGuncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int x = Convert.ToInt32(Request.QueryString["ID"]);
                var ytnk = db.TBLYETENEKLER.Find(x);
                TextBox1.Text = ytnk.YETENEK;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var ytnk = db.TBLYETENEKLER.Find(x);
            ytnk.YETENEK = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("YeteneklerimAdmin.aspx");
        }
    }
}