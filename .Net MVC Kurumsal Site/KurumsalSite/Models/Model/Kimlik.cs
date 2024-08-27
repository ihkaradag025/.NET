namespace KurumsalSite.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kimlik")]
    public partial class Kimlik
    {
        [Key]
        public int KimlikId { get; set; }

        [DisplayName("Site Ba�l�k")]
        [Required, StringLength(100, ErrorMessage = "100 Karakter olmal�d�r")]
        public string Title { get; set; }

        [DisplayName("Anahtar Kelimeler")]
        [Required, StringLength(250, ErrorMessage = "250 Karakter olmal�d�r")]
        public string Keywords { get; set; }

        [DisplayName("Site A��klama")]
        [Required, StringLength(500, ErrorMessage = "500 Karakter olmal�d�r")]
        public string Description { get; set; }

        [DisplayName("Site Logo")]
        public string LogoURL { get; set; }

        [DisplayName("Site �nvan")]
        public string Unvan { get; set; }
    }
}
