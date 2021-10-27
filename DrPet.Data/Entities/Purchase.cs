using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrPet.Data.Entities
{
    public class Purchase : EntityBase<Purchase>
    {
        public DateTime Date { get; set; }
        public PurchaseStatus Status { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; }

        public ICollection<Treatment> Treatments { get; set; }

        public override void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasOne(p => p.Owner).WithMany(o => o.Purchases)
                .HasForeignKey(p => p.OwnerId).HasPrincipalKey(o => o.Id);

            builder.HasOne(p => p.Pet).WithMany(pet => pet.Purchases)
                .HasForeignKey(p => p.PetId).HasPrincipalKey(pet => pet.Id);

            builder.Property(o => o.Comment).HasMaxLength(1000);
        }
    }
}
