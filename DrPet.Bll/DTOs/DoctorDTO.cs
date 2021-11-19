﻿using DrPet.Data;
using System.ComponentModel.DataAnnotations;

namespace DrPet.Bll.DTOs
{
    public class DoctorDTO
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Név")]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Leírás")]
        public string? PublicDescription { get; set; }

        [Display(Name = "Leírás")]
        public string? ShortPublicDescription { get; set; }

        public Position Position { get; set; } = Position.Doctor;
    }    
}