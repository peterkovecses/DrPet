using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DrPet.Bll.Models
{
    public class TreatmentType
    {
        public int Id { get; set; }

        [Display(Name = "Kezelés típus")]
        public string? Name { get; set; }

        [Display(Name = "Ár")]
        public double Price { get; set; }        
    }
}
