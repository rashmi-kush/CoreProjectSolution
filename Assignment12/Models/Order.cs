using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Assignment12.Models
{
    public class Order
    {
        [Display(Name ="Order No")]
        public int? OrderNo { get; set; }
        [Display(Name ="Order Date")]
        [Required(ErrorMessage = "{0} can't be Blank.")]
        [Mini]
        public DateAndTime OrderDate { get; set; }
    }
}
