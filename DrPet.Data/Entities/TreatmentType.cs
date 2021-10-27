using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DrPet.Data.Entities
{
    public class TreatmentType : EntityBase<TreatmentType>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ICollection<Treatment> Treatments { get; set; }

        public override void Configure(EntityTypeBuilder<TreatmentType> builder)
        {
            builder.Property(tt => tt.Name).HasMaxLength(50);
            builder.HasIndex(tt => tt.Name).IsUnique();
        }
    }
}