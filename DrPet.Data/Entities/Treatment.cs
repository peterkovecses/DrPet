using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DrPet.Data.Entities
{
    public class Treatment : EntityBase<Treatment>
    {
        public DateTime Date { get; set; }
        public int? MedicineId { get; set; }
        public Medicine? Medicine { get; set; }
        public TreatmentLength? Length { get; set; }
        public PurchaseStatus PurchaseStatus { get; set; }

        public int TypeId { get; set; }
        public TreatmentType Type { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public int ConsultingId { get; set; }
        public Consulting Consulting { get; set; }
        public int? AntecedentId { get; set; }
        public Treatment? Antecedent { get; set; }
        
        public ICollection<Treatment>? Consequences { get; set; }

        public override void Configure(EntityTypeBuilder<Treatment> builder)
        {
            builder.Property(t => t.Comment).HasMaxLength(1000);

            builder.HasOne(t => t.Medicine).WithMany(m => m.Treatments)
                .HasForeignKey(t => t.MedicineId).HasPrincipalKey(m => m.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Consulting).WithMany(c => c.Treatments)
                .HasForeignKey(t => t.ConsultingId).HasPrincipalKey(c => c.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Owner).WithMany(o => o.Treatments)
                .HasForeignKey(t => t.OwnerId).HasPrincipalKey(o => o.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Pet).WithMany(p => p.Treatments)
                .HasForeignKey(t => t.PetId).HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Worker).WithMany(w => w.Treatments)
                .HasForeignKey(t => t.WorkerId).HasPrincipalKey(w => w.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Type).WithMany(tt => tt.Treatments)
                .HasForeignKey(t => t.TypeId).HasPrincipalKey(tt => tt.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Antecedent).WithMany(t => t.Consequences)
                .HasForeignKey(t => t.AntecedentId).HasPrincipalKey(t => t.Id);
        }

    }
}