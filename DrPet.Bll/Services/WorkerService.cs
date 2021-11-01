using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Data;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.EntityFrameworkCore;

namespace DrPet.Bll.Services
{
    public class WorkerService : IWorkerService
    {
        public WorkerService(DrPetDbContext dbContext) => DbContext = dbContext;

        public DrPetDbContext DbContext { get; }

        public async Task<IReadOnlyCollection<Doctor>> GetDoctorsAsync()
        {
            var doctors = DbContext.Workers.Where(w => w.Position == Position.Doctor);
            return await doctors
                .Select(d => new Doctor(d.Id, d.Name, d.PublicDescription))
                .ToListAsync();
        }
    }
}
