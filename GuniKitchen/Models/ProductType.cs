using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuniKitchen.Models
{
    [Table("ProductTypes")]
    public class ProductType
    {
        public int Id { get; set; }

        [Display(Name = "Product Type")]
        [Required]
        public string ProductTypes { get; set; }


        //public Product Product { get; set; }
    }
}
