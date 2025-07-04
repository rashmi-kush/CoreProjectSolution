﻿using System.ComponentModel.DataAnnotations;

namespace Assignment12.Models
{
    public class Product
    {
        [Required(ErrorMessage ="{0} can't be blank.")]
        [Display(Name ="Product Code")]
        [Range(1,int.MaxValue, ErrorMessage ="{0} should be a valid number.")]
        public int productCode { get; set; }

        [Required(ErrorMessage ="{0} can't be blank.")]
        [Display(Name ="Product Price")]
        [Range(1,double.MaxValue,ErrorMessage ="{0} should be a valid number.")]
        public double ProductPrice { get; set; }

        [Required(ErrorMessage ="{0} can't be blank.")]
        [Display(Name ="Product Quantity")]
        [Range(1,int.MaxValue,ErrorMessage ="{0} should be a valid number.")]
        public int Quantity { get; set; }

    }
}
