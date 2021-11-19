using System;
using System.ComponentModel.DataAnnotations;

namespace DrPet.Bll.DTOs
{
    public class MinStartingTimeDTO : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime _dateStart = Convert.ToDateTime(value);
                if (_dateStart >= DateTime.Now)
                    return ValidationResult.Success;
                else
                    return new ValidationResult(ErrorMessage);
            }
            
            return new ValidationResult("Az időpont kiválasztása kötelező.");
        }
    }
}
