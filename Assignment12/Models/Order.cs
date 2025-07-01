using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using Assignment12.CustomValidators;

namespace Assignment12.Models
{
    public class Order
    {
        [Display(Name ="Order No")]
        public int? OrderNo { get; set; }

        [Display(Name ="Order Date")]
        [Required(ErrorMessage = "{0} can't be Blank.")]
        [MinimumDateValidator("2000-01-01")]
        public DateAndTime OrderDate { get; set; }
    }
}
