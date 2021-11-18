using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrPet.Bll.Models
{
    public class MinEndingTime : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var consulting = (Consulting)validationContext.ObjectInstance;
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
