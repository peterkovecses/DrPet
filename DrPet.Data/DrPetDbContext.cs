using DrPet.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace DrPet.Data
{
    public class DrPetDbContext : DbContext
    {
        public DrPetDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ConsultingTime> ConsultingTimes { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetOwnership> PetOwnerships { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<TreatmentType> TreatmentTypes { get; set; }
        public DbSet<Worker> Workers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
