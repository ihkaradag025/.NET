using KurumsalSite.Models.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KurumsalSite.Models.DataContext
{
    public partial class KurumsalDBContext: DbContext
    {
        public KurumsalDBContext() : base("name=KurumsalWebDB") //Base e yazdýðýmýz isimle webconfig dosyasýndaki connectionstring e yazdýðýmýz isim ayný olmalý.

        {
        }

        public virtual DbSet<Admin> Admin { get; set; }   //using KurumsalSite.Models.Model; hepsi için bu olmalý
        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<Hakkimizda> Hakkimizda { get; set; }
        public virtual DbSet<Hizmet> Hizmet { get; set; }
        public virtual DbSet<Iletisim> Iletisim { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kimlik> Kimlik { get; set; }

        public virtual DbSet<Slider> Slider { get; set; }

        public virtual DbSet<Yorum> Yorum { get; set; }


    }
}
