using DrPet.Data.Entities;
using DrPet.Data.Seed;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace DrPet.Data
{
    public class DrPetDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public DrPetDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Consulting> Consultings { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Variety> Varieties { get; set; }
        public DbSet<PetOwnership> PetOwnerships { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<TreatmentType> TreatmentTypes { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserWorker> AppUserWorkers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            TestDataConfiguration.ConfigureSeedData(modelBuilder);
        }
    }
}
