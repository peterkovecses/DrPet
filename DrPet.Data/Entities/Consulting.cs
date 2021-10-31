using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DrPet.Data.Entities
{
    public class Consulting : EntityBase<Consulting>
    {
        public DateTime StartOfConsulting { get; set; }
        public DateTime EndOfConsulting { get; set; }

        public int WorkerId { get; set; }
        public Worker Worker { get; set; }

        public ICollection<Treatment> Treatments { get; set; }

        public override void Configure(EntityTypeBuilder<Consulting> builder)
        {
            builder.HasIndex(ct => new { ct.StartOfConsulting, ct.EndOfConsulting, ct.WorkerId }).IsUnique();

            builder.HasOne(ct => ct.Worker).WithMany(w => w.Consultings)
                .HasForeignKey(ct => ct.WorkerId).HasPrincipalKey(w => w.Id);
        }
    }
}
