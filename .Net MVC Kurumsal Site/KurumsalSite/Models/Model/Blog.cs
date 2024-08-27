namespace KurumsalSite.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Blog")]
    public partial class Blog
    {
        [Key]
        public int BlogId { get; set; }

        [StringLength(250)]
        public string Baslik { get; set; }

        public string Icerik { get; set; }

        [StringLength(250)]
        public string ResimUrl { get; set; }

        public int? KategoriId { get; set; }

        public virtual Kategori Kategori { get; set; }

        public ICollection<Yorum> Yorums { get; set; }
    }
}
