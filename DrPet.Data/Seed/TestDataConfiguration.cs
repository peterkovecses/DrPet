using DrPet.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DrPet.Data.Seed
{
    class TestDataConfiguration
    {
        public static void ConfigureSeedData(ModelBuilder modelBuilder)
        {
            var date = new DateTime(2020, 01, 01);

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

            modelBuilder.Entity<Pet>().HasData(
                WithAudit(new Pet { Id = 1, Name = "Blöki", VarietyId = 1, Birthdate = new(2020, 10, 12), Comment = "Versenydíjas (2019)" }),
                WithAudit(new Pet { Id = 2, Name = "Pimpedli", VarietyId = 1, Birthdate = new(2020, 10, 12) }),
                WithAudit(new Pet { Id = 3, Name = "Banán", VarietyId = 2, Birthdate = new(2020, 10, 12) }),
                WithAudit(new Pet { Id = 4, Name = "Ms. Purry", VarietyId = 3, Birthdate = new(2020, 10, 12) })
                );

            modelBuilder.Entity<Owner>().HasData(
                WithAudit(new Owner { Id = 1, Name = "Gazdi Dezső", Birthdate = new(1995, 10, 12), Location = "Győr" }),
                WithAudit(new Owner { Id = 2, Name = "Béka Bandi", Birthdate = new(1995, 10, 12), Location = "Győrújbarát" })
                );

            modelBuilder.Entity<PetOwnership>().HasData(
                WithAudit(new PetOwnership { Id = 1, PetId = 1, OwnerId = 1 }),
                WithAudit(new PetOwnership { Id = 2, PetId = 2, OwnerId = 1 }),
                WithAudit(new PetOwnership { Id = 3, PetId = 3, OwnerId = 2 }),
                WithAudit(new PetOwnership { Id = 4, PetId = 4, OwnerId = 2 })
                );

            modelBuilder.Entity<Medicine>().HasData(
                WithAudit(new Medicine { Id = 1, Name = "Probatbicol (350mg)" }),
                WithAudit(new Medicine { Id = 2, Name = "Placebotinol (50mg)" })
                );

            modelBuilder.Entity<TreatmentType>().HasData(
                WithAudit(new TreatmentType { Id = 1, Name = "Rutinvizsgálat (panasz nélkül)", Price = 10000 }),
                WithAudit(new TreatmentType { Id = 2, Name = "Vizsgálat (akut panaszok)", Price = 12000 }),
                WithAudit(new TreatmentType { Id = 3, Name = "Kontrollvizsgálat", Price = 8000 }),
                WithAudit(new TreatmentType { Id = 4, Name = "Műtét", Price = 30000 }),
                WithAudit(new TreatmentType { Id = 5, Name = "Gyógyszer felírása", Price = 2500 })
                );

            modelBuilder.Entity<Worker>().HasData(
                WithAudit(new Worker { Id = 1, Name = "Dr. Szabó ildikó", Position = Position.Doctor, PublicDescription = "Duis ac sapien laoreet, gravida justo vel, posuere leo. Curabitur mi diam, interdum vel neque in, consequat suscipit ex. Morbi porta sagittis nunc, a dictum tortor viverra et. Mauris egestas at dui in ultrices. Suspendisse tempor imperdiet justo, eget maximus nibh vulputate nec. Quisque vel urna sed ipsum venenatis facilisis. Nam rutrum, augue id rhoncus fermentum, lorem quam suscipit orci, nec lobortis lacus velit a justo. Suspendisse commodo lacus nec sagittis efficitur. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis dictum aliquet sapien. Nulla id pellentesque nisi. Aliquam viverra, est vel auctor pretium, mauris magna rhoncus nisl, vel dictum arcu velit non dui. Nullam dignissim elit quis lectus aliquam, nec aliquam est molestie. Donec aliquet sed mauris in molestie. Phasellus vitae elit vel mi interdum viverra. Integer vel leo tempus, aliquam enim a, hendrerit ipsum. Pellentesque finibus libero libero, volutpat ullamcorper dui facilisis at. Praesent sit amet lacus mollis, egestas dolor nec, porta est. Integer dapibus ex ipsum, eu semper massa maximus sed. Aenean sodales, nulla ac semper blandit, quam diam dignissim nisi, lobortis posuere ipsum diam vitae justo. Ut fringilla elementum orci at faucibus. Nullam posuere porta purus, eu aliquet felis aliquam volutpat. Phasellus turpis libero, lobortis sit amet diam eget, tempor varius libero. Quisque cursus ullamcorper laoreet." }),
                WithAudit(new Worker { Id = 2, Name = "Dr. Horváth Tibor", Position = Position.Doctor, PublicDescription = "Duis ac sapien laoreet, gravida justo vel, posuere leo. Curabitur mi diam, interdum vel neque in, consequat suscipit ex. Morbi porta sagittis nunc, a dictum tortor viverra et. Mauris egestas at dui in ultrices. Suspendisse tempor imperdiet justo, eget maximus nibh vulputate nec. Quisque vel urna sed ipsum venenatis facilisis. Nam rutrum, augue id rhoncus fermentum, lorem quam suscipit orci, nec lobortis lacus velit a justo. Suspendisse commodo lacus nec sagittis efficitur. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis dictum aliquet sapien. Nulla id pellentesque nisi. Aliquam viverra, est vel auctor pretium, mauris magna rhoncus nisl, vel dictum arcu velit non dui. Nullam dignissim elit quis lectus aliquam, nec aliquam est molestie. Donec aliquet sed mauris in molestie. Phasellus vitae elit vel mi interdum viverra. Integer vel leo tempus, aliquam enim a, hendrerit ipsum. Pellentesque finibus libero libero, volutpat ullamcorper dui facilisis at. Praesent sit amet lacus mollis, egestas dolor nec, porta est. Integer dapibus ex ipsum, eu semper massa maximus sed. Aenean sodales, nulla ac semper blandit, quam diam dignissim nisi, lobortis posuere ipsum diam vitae justo. Ut fringilla elementum orci at faucibus. Nullam posuere porta purus, eu aliquet felis aliquam volutpat. Phasellus turpis libero, lobortis sit amet diam eget, tempor varius libero. Quisque cursus ullamcorper laoreet." }),
                WithAudit(new Worker { Id = 3, Name = "Dr. Kiss Erika", Position = Position.Doctor, PublicDescription = "Duis ac sapien laoreet, gravida justo vel, posuere leo. Curabitur mi diam, interdum vel neque in, consequat suscipit ex. Morbi porta sagittis nunc, a dictum tortor viverra et. Mauris egestas at dui in ultrices. Suspendisse tempor imperdiet justo, eget maximus nibh vulputate nec. Quisque vel urna sed ipsum venenatis facilisis. Nam rutrum, augue id rhoncus fermentum, lorem quam suscipit orci, nec lobortis lacus velit a justo. Suspendisse commodo lacus nec sagittis efficitur. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis dictum aliquet sapien. Nulla id pellentesque nisi. Aliquam viverra, est vel auctor pretium, mauris magna rhoncus nisl, vel dictum arcu velit non dui. Nullam dignissim elit quis lectus aliquam, nec aliquam est molestie. Donec aliquet sed mauris in molestie. Phasellus vitae elit vel mi interdum viverra. Integer vel leo tempus, aliquam enim a, hendrerit ipsum. Pellentesque finibus libero libero, volutpat ullamcorper dui facilisis at. Praesent sit amet lacus mollis, egestas dolor nec, porta est. Integer dapibus ex ipsum, eu semper massa maximus sed. Aenean sodales, nulla ac semper blandit, quam diam dignissim nisi, lobortis posuere ipsum diam vitae justo. Ut fringilla elementum orci at faucibus. Nullam posuere porta purus, eu aliquet felis aliquam volutpat. Phasellus turpis libero, lobortis sit amet diam eget, tempor varius libero. Quisque cursus ullamcorper laoreet." }),
                WithAudit(new Worker { Id = 4, Name = "Dr. Kovács József", Position = Position.Doctor, PublicDescription = "Duis ac sapien laoreet, gravida justo vel, posuere leo. Curabitur mi diam, interdum vel neque in, consequat suscipit ex. Morbi porta sagittis nunc, a dictum tortor viverra et. Mauris egestas at dui in ultrices. Suspendisse tempor imperdiet justo, eget maximus nibh vulputate nec. Quisque vel urna sed ipsum venenatis facilisis. Nam rutrum, augue id rhoncus fermentum, lorem quam suscipit orci, nec lobortis lacus velit a justo. Suspendisse commodo lacus nec sagittis efficitur. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis dictum aliquet sapien. Nulla id pellentesque nisi. Aliquam viverra, est vel auctor pretium, mauris magna rhoncus nisl, vel dictum arcu velit non dui. Nullam dignissim elit quis lectus aliquam, nec aliquam est molestie. Donec aliquet sed mauris in molestie. Phasellus vitae elit vel mi interdum viverra. Integer vel leo tempus, aliquam enim a, hendrerit ipsum. Pellentesque finibus libero libero, volutpat ullamcorper dui facilisis at. Praesent sit amet lacus mollis, egestas dolor nec, porta est. Integer dapibus ex ipsum, eu semper massa maximus sed. Aenean sodales, nulla ac semper blandit, quam diam dignissim nisi, lobortis posuere ipsum diam vitae justo. Ut fringilla elementum orci at faucibus. Nullam posuere porta purus, eu aliquet felis aliquam volutpat. Phasellus turpis libero, lobortis sit amet diam eget, tempor varius libero. Quisque cursus ullamcorper laoreet." })
                );

            //modelBuilder.Entity<AppUserWorker>().HasData(
            //    WithAudit(new AppUserWorker { Id = 1, AppUserId = 1, WorkerId = 1 }),
            //    WithAudit(new AppUserWorker { Id = 2, AppUserId = 2, WorkerId = 2 }),
            //    WithAudit(new AppUserWorker { Id = 3, AppUserId = 3, WorkerId = 3 }),
            //    WithAudit(new AppUserWorker { Id = 4, AppUserId = 4, WorkerId = 4 })
            //    );

            modelBuilder.Entity<Consulting>().HasData(
                WithAudit(new Consulting { Id = 1, StartOfConsulting = DateTime.Now, EndOfConsulting = DateTime.Now.AddHours(8), WorkerId = 1 }),
                WithAudit(new Consulting { Id = 2, StartOfConsulting = DateTime.Now.AddHours(24), EndOfConsulting = DateTime.Now.AddHours(32), WorkerId = 2 }),
                WithAudit(new Consulting { Id = 3, StartOfConsulting = DateTime.Now.AddHours(48), EndOfConsulting = DateTime.Now.AddHours(56), WorkerId = 3 }),
                WithAudit(new Consulting { Id = 4, StartOfConsulting = DateTime.Now.AddHours(72), EndOfConsulting = DateTime.Now.AddHours(80), WorkerId = 4 })
                );

            T WithAudit<T>(T entity) where T : EntityBase
            {
                entity.DateOfCreation = entity.DateOfUpdate = date;
                return entity;
            }
        }        
    }
}
