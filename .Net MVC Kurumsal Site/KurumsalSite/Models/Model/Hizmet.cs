namespace KurumsalSite.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hizmet")]
    public partial class Hizmet
    {
        [Key]
        public int HizmetId { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "500 karakter olmal�d�r")]
        [DisplayName("Hizmet Ba�l�k")]
        public string Baslik { get; set; }

        [StringLength(500)]
        [DisplayName("Hizmet A��klama")]
        public string Aciklama { get; set; }

        [StringLength(500)]
        [DisplayName("Hizmet Resim")]
        public string ResimURL { get; set; }
    }
}
