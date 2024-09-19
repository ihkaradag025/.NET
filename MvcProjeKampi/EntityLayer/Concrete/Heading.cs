using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(80)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public int? CategoryID { get; set; }  /*kategori ile başlık arasında ilişkili alanı tanımladık*/
        public virtual Category Category { get; set; } /*yukarıdaki ilişkili alanın hangi sınıftan değer alacağını belirledik*/

        public int? WriterId { get; set; }  /*yazar ile başlık arasında ilişkili alanı tanımladık*/
        public virtual Writer Writer { get; set; } /*yukarıdaki ilişkili alanın hangi sınıftan değer alacağını belirledik*/

        public ICollection<Content> Contents { get; set; } /*Başlık ile içerik arasındaki ilişki için. burada Başlık koleksiyon tipinde içeriği karşılıyor. Ana tablo Hading-Alt tablo Content*/
    }
}
