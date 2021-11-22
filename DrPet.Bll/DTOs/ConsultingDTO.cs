using System;
using System.ComponentModel.DataAnnotations;
using DrPet.Bll.MyValidations;

namespace DrPet.Bll.DTOs
{
    public class ConsultingDTO
    {
        public int Id { get; set; }

        [MinStartingTime(ErrorMessage = "Az időpont nem lehet kisebb mint a mostani idő.")]
        [Display(Name = "Rendelés kezdete")]
        public DateTime StartOfConsulting { get; set; }

        [MinEndingTime(ErrorMessage = "Az időpont nem lehet kisebb mint a rendelés kezdetének ideje.")]
        [Display(Name = "Rendelés vége")]
        public DateTime EndOfConsulting { get; set; }

        [Required]
        [Display(Name = "Orvos neve")]
        public int WorkerId { get; set; }

        [Display(Name = "Orvos neve")]
        public string? WorkerName { get; set; }
    }
}
