﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DrPet.Bll.MyValidations
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
            
            return new ValidationResult("A mező kitöltése kötelező.");
        }
    }
}
