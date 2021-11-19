using System.ComponentModel.DataAnnotations;

namespace DrPet.Bll.DTOs
{
    public class TreatmentTypeDTO
    {
        public int Id { get; set; }

        [Display(Name = "Kezelés típus")]
        public string? Name { get; set; }

        [Display(Name = "Ár")]
        public double Price { get; set; }        
    }
}
