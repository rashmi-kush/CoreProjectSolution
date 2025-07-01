
using System.ComponentModel.DataAnnotations;

namespace Assignment12.CustomValidators
{
    public class MinimumDateValidatorAttribute : ValidationAttribute
    {
        public string DefaultErrorMessage { get; set; } = "Order Date greater than or equal to {0}";

        public DateTime MinimumDate;
        public MinimumDateValidatorAttribute(string minimumDateString) 
        {
            MinimumDate = Convert.ToDateTime(minimumDateString);
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            { 
                DateTime orderDate = (DateTime)value;
                if (orderDate < MinimumDate)// entered date is lower than 2020-01-01
                {
                    return new ValidationResult(string.Format(ErrorMessage ?? DefaultErrorMessage, MinimumDate.ToString("yyyy-MM-dd")), new string[] { nameof(validationContext.MemberName) });
                }
                return ValidationResult.Success;
            }
            return null;
        }
    }
}
