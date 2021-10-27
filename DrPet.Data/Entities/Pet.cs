using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DrPet.Data.Entities
{
    public class Pet : EntityBase<Pet>
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int VarietyId { get; set; }
        public Variety Variety { get; set; }
        public TreatmentStatus Status { get; set; }

        public ICollection<PetOwnership> PetOwnerships { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<Treatment> Treatments { get; set; }

        public override void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(50);

            builder.HasOne(p => p.Variety).WithMany(v => v.Pets)
                .HasForeignKey(p => p.VarietyId).HasPrincipalKey(v => v.Id);
        }
    }
}