using System.ComponentModel.DataAnnotations;

namespace DrPet.Bll.DTOs
{
    public class MedicineDTO
    {
        public int Id { get; set; }

        [Display(Name = "Gyógyszer")]
        public string? Name { get; set; }
    }
}
