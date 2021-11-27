
namespace DrPet.Bll.DTOs
{
    public class AppUserDTO
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        // For the database query it is important to be nullable:
        public int? WorkerId { get; set; }
    }
}
