using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrPet.Data.Entities
{
    public class Medicine : EntityBase<Medicine>
    {
        public string Name { get; set; }

        public ICollection<Treatment> Treatments { get; set; }

        public override void Configure(EntityTypeBuilder<Medicine> builder)
        {
            builder.Property(m => m.Name).HasMaxLength(100);
        }
    }
}
