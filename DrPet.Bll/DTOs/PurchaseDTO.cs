using System;

namespace DrPet.Bll.DTOs
{
    public class PurchaseDTO
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public PurchaseStatusDTO Status { get; set; } = PurchaseStatusDTO.WaitinForPayment;

        public int OwnerId { get; set; }

        public int PetId { get; set; }
    }
}
