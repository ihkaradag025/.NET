using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }
        //ContentYazar
        //ContentBaşlık

        public int? HeadingID { get; set; } /*Başlık ile içerik arasında ilişkili alanı tanımladık*/
        public virtual Heading Heading { get; set; } /*yukarıdaki ilişkili alanın hangi sınıftan değer alacağını belirledik*/

        public int? WriterId { get; set; } /*yazar ile içerik arasında ilişkili alanı tanımladık*/
        public virtual Writer Writer { get; set; } /*yukarıdaki ilişkili alanın hangi sınıftan değer alacağını belirledik*/
    }
}
