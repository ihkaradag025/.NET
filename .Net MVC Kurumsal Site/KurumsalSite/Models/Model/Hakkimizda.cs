namespace KurumsalSite.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hakkimizda")]
    public partial class Hakkimizda
    {
        [Key]
        public int HakkimizdaId { get; set; }

        [Required]
        [DisplayName("Hakkýmýzda Açýklama")] //using System.ComponentModel;
        public string Aciklama { get; set; }
    }
}
