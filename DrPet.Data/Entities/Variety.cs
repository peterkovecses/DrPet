using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DrPet.Data.Entities
{
    public class Variety : EntityBase<Variety>
    {
        public string Name { get; set; }
        public int SpeciesId { get; set; }
        public Species Species { get; set; }

        public ICollection<Pet> Pets { get; set; }

        public override void Configure(EntityTypeBuilder<Variety> builder)
        {
            builder.HasOne(v => v.Species).WithMany(s => s.Varieties)
                .HasForeignKey(v => v.SpeciesId).HasPrincipalKey(s => s.Id);
        }
    }
}