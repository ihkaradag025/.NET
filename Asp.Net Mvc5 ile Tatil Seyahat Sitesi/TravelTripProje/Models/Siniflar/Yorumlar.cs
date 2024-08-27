using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int YorumId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public bool OnayDurum { get; set; }
        

        public int? Blogid { get; set; }
        public virtual Blog Blog { get; set; }
    }
}