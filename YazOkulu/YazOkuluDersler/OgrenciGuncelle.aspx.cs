using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinesLogicLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
        TxtID.Text = x.ToString();
        TxtID.Enabled = false;

        if (Page.IsPostBack == false)
        {
            List<EntityOgrenci> OgrList = BLLOgrenci.BllGuncelleListe(x);
            TxtAd.Text = OgrList[0].AD.ToString();
            TxtSoyAd.Text = OgrList[0].SOYAD.ToString();
            TxtSifre.Text = OgrList[0].SIFRE.ToString();
            TxtNumara.Text = OgrList[0].NUMARA.ToString();
            TxtFoto.Text = OgrList[0].FOTOGRAF.ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.AD = TxtAd.Text;
        ent.SOYAD = TxtSoyAd.Text;
        ent.NUMARA = TxtNumara.Text;
        ent.SIFRE = TxtSifre.Text;
        ent.FOTOGRAF = TxtFoto.Text;
        ent.ID = Convert.ToInt32(TxtID.Text);
        BLLOgrenci.OgrenciGuncelleBLL(ent);
        Response.Redirect("OgrenciListesi.aspx");

    }
}