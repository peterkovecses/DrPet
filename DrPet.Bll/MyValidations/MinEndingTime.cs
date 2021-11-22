using System;
using System.ComponentModel.DataAnnotations;
using DrPet.Bll.DTOs;

namespace DrPet.Bll.MyValidations
{
    public class MinEndingTime : ValidationAttribute
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

            return new ValidationResult("A mező kitöltése kötelező.");
        }
    }
}
