using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinesLogicLayer;

public partial class OgrenciListesi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityOgrenci> OgrList = BLLOgrenci.BllListele(); /*burada new kullanmamamızın sebebi; çünkü bunu 
                                                                tanımlarken static anahtarını kullandık static kullanırsak bir örnek oluşturmadan metoda erişilebilir hale gelir.*/
        Repeater1.DataSource = OgrList;
        Repeater1.DataBind();

    }
}