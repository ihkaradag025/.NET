using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirstOrnek.Entity
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set;}
        public string KategoriAdi { get; set; }
       // public string KategoriDetay { get; set; } //bunu kaldırırsak sütunu silmiş oluruz
        public ICollection<Urunler> Urunlers { get; set; }

    }
}
