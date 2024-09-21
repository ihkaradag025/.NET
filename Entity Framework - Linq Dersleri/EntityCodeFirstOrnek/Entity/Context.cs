using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityCodeFirstOrnek.Entity
{
    class Context : DbContext
    {
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }

       // public DbSet<Musteri> Musteris  { get; set; }// bunu kaldırırsak tabloyu silmiş oluruz
    }
}
