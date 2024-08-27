namespace KurumsalSite.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="50 Karakter olmalýdýr")]
        public string Eposta { get; set; }

        [Required, StringLength(50, ErrorMessage = "50 Karakter olmalýdýr")]
        
        public string Sifre { get; set; }

        [StringLength(50)]
        public string Yetki { get; set; }
    }
}
