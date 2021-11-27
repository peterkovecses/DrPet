using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DrPet.Data.Entities
{
    public class AppUser : IdentityUser<int>, IEntityTypeConfiguration<AppUser>
    {
        public string Name { get; set; }

        public ICollection<AppUserWorker>? AppUserWorkers { get; set; }

        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(au => au.Name).HasMaxLength(100);
        }
    }
}
