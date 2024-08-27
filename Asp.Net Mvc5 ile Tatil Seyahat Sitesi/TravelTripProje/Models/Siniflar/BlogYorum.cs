using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class BlogYorum  ///bu sınıf bir viewde birden fazla tablodan değer çekebilmek için oluşturuldu.Çünkü bir viewde bir model oluşturulabiliyor. Bu işi daha önce partialview ile yapmışken şimdi bu sınıfı oluşturarak yapıyoruz.
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
        public IEnumerable<Yorumlar> Deger4 { get; set; }
       
    }
    }