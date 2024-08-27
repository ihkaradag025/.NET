using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }

        [DisplayName("Resim")]
        public string BlogImage { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }

    }
}