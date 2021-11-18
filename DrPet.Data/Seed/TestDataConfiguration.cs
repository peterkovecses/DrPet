using DrPet.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DrPet.Data.Seed
{
    class TestDataConfiguration
    {
        public static void ConfigureSeedData(ModelBuilder modelBuilder)
        {
            var date = new DateTime(2000, 01, 01);

            modelBuilder.Entity<Species>().HasData(
                WithAudit(new Species { Id = 1, Name = "Kutya", LatinName = "Canis lupus familiaris" }),
                WithAudit(new Species { Id = 2, Name = "Macska", LatinName = "Felis catus" })
                );

            modelBuilder.Entity<Variety>().HasData(
                WithAudit(new Variety { Id = 1, Name = "Puli", SpeciesId = 1 }),
                WithAudit(new Variety { Id = 2, Name = "Labrador", SpeciesId = 1 }),
                WithAudit(new Variety { Id = 3, Name = "Amerikai rövidszőrű", SpeciesId = 2 }),
                WithAudit(new Variety { Id = 4, Name = "Perzsa", SpeciesId = 2 })
                );

            modelBuilder.Entity<Medicine>().HasData(
                WithAudit(new Medicine { Id = 1, Name = "Probatbicol (350mg)" }),
                WithAudit(new Medicine { Id = 2, Name = "Placebotinol (10mg)" })
                );

            modelBuilder.Entity<TreatmentType>().HasData(
                WithAudit(new TreatmentType { Id = 1, Name = "Rutinvizsgálat (panasz nélkül)", Price = 10000 }),
                WithAudit(new TreatmentType { Id = 2, Name = "Vizsgálat (akut panaszok)", Price = 12000 }), 
                WithAudit(new TreatmentType { Id = 3, Name = "Kontrollvizsgálat", Price = 8000 }),
                WithAudit(new TreatmentType { Id = 4, Name = "Műtét", Price = 30000 }),
                WithAudit(new TreatmentType { Id = 5, Name = "Gyógyszer felírása", Price = 2500 })
                );

            T WithAudit<T>(T entity) where T : EntityBase
            {
                entity.DateOfCreation = entity.DateOfUpdate = date;
                return entity;
            }
        }        
    }
}
