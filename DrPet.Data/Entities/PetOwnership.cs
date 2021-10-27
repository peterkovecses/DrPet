using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrPet.Data.Entities
{
    public class PetOwnership : EntityBase<PetOwnership>
    {
        public int PetId { get; set; }
        public Pet Pet { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        public override void Configure(EntityTypeBuilder<PetOwnership> builder)
        {
            builder.HasIndex(po => new { po.PetId, po.OwnerId }).IsUnique();

            builder.HasOne(po => po.Owner).WithMany(o => o.PetOwnerships)
                .HasForeignKey(t => t.OwnerId).HasPrincipalKey(o => o.Id);

            builder.HasOne(po => po.Pet).WithMany(p => p.PetOwnerships)
                .HasForeignKey(t => t.PetId).HasPrincipalKey(p => p.Id);                
        }
    }
}
