using System;
using System.ComponentModel.DataAnnotations;

namespace DrPet.Bll.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public PurchaseStatus Status { get; set; } = PurchaseStatus.WaitinForPayment;

        public int OwnerId { get; set; }

        public int PetId { get; set; }
    }
}
