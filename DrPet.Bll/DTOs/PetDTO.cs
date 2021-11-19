using System;
using System.ComponentModel.DataAnnotations;

namespace DrPet.Bll.DTOs
{
    public class PetDTO
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Név")]
        public string? Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Születési dátum")]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Megjegyzés")]
        public string? Comment { get; set; }

        [Display(Name = "Fajta")]
        public int VarietyId { get; set; }

        [Display(Name = "Fajta")]
        public string? VarietyName { get; set; }

        [Display(Name = "Gazda")]
        public int OwnerId { get; set; }

        [Display(Name = "Gazda")]
        public string? OwnerName { get; set; }

        public int PrevOwnerId { get; set; }
    }
}
