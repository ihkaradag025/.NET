namespace KurumsalSite.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kategori")]
    public partial class Kategori
    {
       [Key]
        public int KategoriId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Kategori Adý")]
        public string KategoriAd { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

      
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
