using Microsoft.EntityFrameworkCore;using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DrPet.Data.Entities
{
    public class Owner : EntityBase<Owner>
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Location { get; set; }

        public ICollection<Treatment> Treatments { get; set; }
        public ICollection<PetOwnership> PetOwnerships { get; set; }

        public override void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.Property(o => o.Name).HasMaxLength(100);
            builder.Property(o => o.Location).HasMaxLength(50);
        }
    }
}
