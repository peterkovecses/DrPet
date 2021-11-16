using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrPet.Bll.Models
{
    public class MinStartingTime : ValidationAttribute
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
