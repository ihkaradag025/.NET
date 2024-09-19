using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_StokTakipOtomasyonu.ActiveFolder
{
    public static class ActiveClass //Bu sınıf, bir sayfanın aktif olup olmadığını kontrol etmek için
    {

        //Genişletme metodu(extension method), mevcut bir sınıfa veya arayüze yeni metotlar eklemenin bir yoludur, ancak bu sınıfın veya arayüzün orijinal kodunu değiştirmeden.Bu metotlar, statik sınıflar içinde tanımlanır ve this anahtar kelimesi kullanılarak genişletilen tür belirtilir.
        public static string ActivePage(this HtmlHelper html, string control, string action)
        {
            string active = "";
            var routedata = html.ViewContext.RouteData;
            string routecontrol = (string)routedata.Values["controller"];
            string routeaction = (string)routedata.Values["action"];
            if (control == routecontrol && action == routeaction)
            {
                active = "active";
            }

            return active;
        }

    }
}