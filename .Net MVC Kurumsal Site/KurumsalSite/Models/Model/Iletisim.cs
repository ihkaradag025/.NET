namespace KurumsalSite.Models.Model
{ 
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Iletisim")]
    public partial class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }

        [Required]
        [StringLength(500,ErrorMessage ="500 karakter olmalýdýr")]
        public string Adres { get; set; }

        [StringLength(50)]
        public string Telefon { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Whatsapp { get; set; }

        [StringLength(50)]
        public string Facebook { get; set; }

        [StringLength(50)]
        public string Twitter { get; set; }

        [StringLength(50)]
        public string Instagram { get; set; }
    }
}
