using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrPet.Data.Entities
{
    public class AppUserWorker : EntityBase<AppUserWorker>
    {
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }

        public override void Configure(EntityTypeBuilder<AppUserWorker> builder)
        {
            builder.HasIndex(apw => new { apw.AppUserId, apw.WorkerId }).IsUnique();

            builder.HasOne(apw => apw.AppUser).WithMany(au => au.AppUserWorkers)
                .HasForeignKey(apw => apw.AppUserId).HasPrincipalKey(au => au.Id);

            builder.HasOne(apw => apw.Worker).WithMany(w => w.AppUserWorkers)
                .HasForeignKey(apw => apw.WorkerId).HasPrincipalKey(w => w.Id);
        }
    }    
}
