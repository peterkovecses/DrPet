using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DrPet.Data.Entities
{
    public class Worker : EntityBase<Worker>
    {
        public string Name { get; set; }
        public Position Position { get; set; }
        public string? PublicDescription { get; set; }

        public ICollection<Treatment>? Treatments { get; set; }
        public ICollection<Consulting>? Consultings { get; set; }

        public override void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.Property(w => w.Name).HasMaxLength(1000);
        }
    }
}
