using System.ComponentModel.DataAnnotations;

namespace Assignment12.Models
{
    public class Product
    {
        [Required(ErrorMessage ="{0} can't be blank.")]
        [Display(Name ="Product Code")]
        public int productCode { get; set; }
        [Required(ErrorMessage ="")]
        [Display(Name ="Product Price")]
        public double ProductPrice { get; set; }    

    }
}
