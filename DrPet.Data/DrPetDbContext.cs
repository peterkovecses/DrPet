using DrPet.Data.Entities;
using DrPet.Data.Seed;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace DrPet.Data
{
    public class DrPetDbContext : DbContext
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            TestDataConfiguration.ConfigureSeedData(modelBuilder);
        }
    }
}
