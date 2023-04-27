using System.ComponentModel.DataAnnotations;

namespace DenemeProje.Web.Data.DbModels
{
    public class Categories
    {
        public int CategoryID { get; set; }

        [Display(Name ="Kategori")]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }

    }
}
