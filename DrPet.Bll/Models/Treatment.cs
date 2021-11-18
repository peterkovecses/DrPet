using System;
using System.ComponentModel.DataAnnotations;

namespace DrPet.Bll.Models
{
    public class Treatment
    {
        public int Id { get; set; }

        [Display(Name = "Időpont")]
        public DateTime Date { get; set; }

        [Display(Name = "Gyógyszer")]
        public int? MedicineId { get; set; }

        [Display(Name = "Gyógyszer")]
        public string? MedicineName { get; set; }

        [Display(Name = "Kezeléstípus")]
        public int TypeId { get; set; }

        [Display(Name = "Kezeléstípus")]
        public string? TypeName { get; set; }

        [Display(Name = "Gazda")]
        public int OwnerId { get; set; }

        [Display(Name = "Gazda")]
        public string? OwnerName { get; set; }

        [Display(Name = "Állat")]
        public int PetId { get; set; }

        [Display(Name = "Állat")]
        public string? PetName { get; set; }

        [Display(Name = "Orvos")]
        public int WorkerId { get; set; }

        [Display(Name = "Orvos")]
        public string? WorkerName { get; set; }

        [Display(Name = "Rendelés azonosító")]
        public int ConsultingId { get; set; }

        [Display(Name = "Vásárlás azonosító")]
        public int PurchaseId { get; set; }

        [Display(Name = "Megjegyzés")]
        public string? Comment { get; set; }
    }
}
