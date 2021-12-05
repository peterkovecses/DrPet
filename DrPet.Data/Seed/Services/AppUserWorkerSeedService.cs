using DrPet.Data.Seed.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrPet.Data.Entities;

namespace DrPet.Data.Seed.Services
{
    public class AppUserWorkerSeedService : IAppUserWorkerSeedService
    {
        public DrPetDbContext DbContext { get; }

        public AppUserWorkerSeedService(DrPetDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task SeedAppUserWorkerAsync()
        {
            if (!DbContext.AppUserWorkers.Any())
            {
                var appUserWorkers = new List<AppUserWorker>
                {
                    new AppUserWorker { AppUserId = 1, WorkerId = 1 },
                    new AppUserWorker { AppUserId = 2, WorkerId = 2 },
                    new AppUserWorker { AppUserId = 3, WorkerId = 3 },
                    new AppUserWorker { AppUserId = 4, WorkerId = 4 }
                };

                foreach (var appUserWorker in appUserWorkers)
                {
                    DbContext.Add(appUserWorker);
                }

                await DbContext.SaveChangesAsync();
            }
        }
    }
}
