using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DrPet.Bll.Models
{
    public class Medicine
    {
        public int Id { get; set; }

        [Display(Name = "Gyógyszer")]
        public string? Name { get; set; }
    }
}
