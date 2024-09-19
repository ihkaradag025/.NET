﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer

    {
        [Key]
        public int WriterId { get; set; }
        [StringLength(80)]
        public string WriterName { get; set; }
        [StringLength(80)]
        public string WriterSurName { get; set; }
        [StringLength(100)]
        public string WriterImage { get; set; }
        [StringLength(80)]
        public string WriterMail { get; set; }
        [StringLength(30)]
        public string WriterPassword { get; set; }

        public ICollection<Heading> Headings { get; set; } /*yazar ile başlık arasındaki ilişki için. burada yazar koleksiyon tipinde başlığı karşılıyor. Ana tablo Writer-Alt tablo Heading*/

        public ICollection<Content> Contents { get; set; } /*yazar ile içerik arasındaki ilişki için. burada yazar koleksiyon tipinde içeriği karşılıyor. Ana tablo Writer-Alt tablo Content*/
    }
}
