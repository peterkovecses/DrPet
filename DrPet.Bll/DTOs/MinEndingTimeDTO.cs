using System;
using System.ComponentModel.DataAnnotations;

namespace DrPet.Bll.DTOs
{
    public class MinEndingTimeDTO : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var consulting = (ConsultingDTO)validationContext.ObjectInstance;
                DateTime date = Convert.ToDateTime(value);

                if (date >= consulting.StartOfConsulting)
                    return ValidationResult.Success;
                else
                    return new ValidationResult(ErrorMessage);
            }

            return new ValidationResult("Az időpont kiválasztása kötelező.");
        }
    }
}
