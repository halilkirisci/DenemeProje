using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DenemeProje.Web.Models
{
    public class FormIslemModel
    {
        [Required]
        public string Adi { get; set; }
        [AllowNull]
        [Display(Name ="Soyumuzun Ne olduğu")]
        public string Soyadi { get; set; }
        [Required(ErrorMessage ="Bu alan gereklidir")]
        public DateTime dogum { get; set; }
    }
}
