using System;
using System.ComponentModel.DataAnnotations;

namespace DrPet.Bll.Models
{
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Név")]
        public string? Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Születési dátum")]
        public DateTime Birthdate { get; set; }

        [Required]
        [Display(Name = "Lokáció")]
        public string? Location { get; set; }

        [Display(Name = "Megjegyzés")]
        public string? Comment { get; set; }
    }
}
