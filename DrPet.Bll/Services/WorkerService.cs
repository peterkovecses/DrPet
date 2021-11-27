using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Data;
using DrPet.Data.Entities;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Helpers;
using DrPet.Bll.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DrPet.Bll.Services
{
    public class WorkerService : IWorkerService
    {
        public DrPetDbContext DbContext { get; }

        public WorkerService(DrPetDbContext dbContext) => DbContext = dbContext;        

        private Expression<Func<Worker, DoctorDTO>> DoctorSelector = d => new DoctorDTO
        {
            Id = d.Id,
            Name = d.Name,
            PublicDescription = d.PublicDescription
        };

        public async Task<IList<DoctorDTO>> GetDoctorsAsync()
        {
            return (await DbContext.Workers.Where(w => w.Position == Position.Doctor)
                .Select(d => new DoctorDTO { Id = d.Id, Name = d.Name, PublicDescription = d.PublicDescription,
                    ShortPublicDescription = d.PublicDescription.Shorten(200) // Helpers\StringHelper.cs
                })
                .ToListAsync())
                .OrderBy(d => d.Name)
                .ToList();
        }

        public async Task<DoctorDTO> GetDoctorAsync(int id)
        {
            return await DbContext.Workers
                .Where(w => w.Id == id)
                .Select(DoctorSelector)
                .SingleOrDefaultAsync();
        }
        public void DeleteWorker(int id)
        {
            DbContext.Workers.Remove(new Worker { Id = id });
            DbContext.SaveChanges();
        }

        public async Task AddOrUpdateDoctorAsync(DoctorDTO doctorDTO)
        {            
            // update
            if (doctorDTO.Id != 0)
            {
                EntityEntry<Worker> entry;
                var worker = await DbContext.Workers.FindAsync(doctorDTO.Id);
                worker.DateOfUpdate = DateTime.Now;
                entry = DbContext.Entry(worker);
                entry.CurrentValues.SetValues(doctorDTO);
            }
            
            // create
            else
            {
                var worker = new Worker
                {
                    Name = doctorDTO.Name,
                    PublicDescription = doctorDTO.PublicDescription,
                    Position = doctorDTO.Position,
                    DateOfCreation = DateTime.Now
                };

                worker.AppUserWorkers = new List<AppUserWorker>
                {
                    new AppUserWorker
                    {
                        AppUserId = doctorDTO.AppUserId,
                        // The WorkerId properties value will be, the id what will be given to the Worker entity
                        WorkerId = doctorDTO.Id
                    }
                };

                DbContext.Add(worker);
            }
            
            await DbContext.SaveChangesAsync();{}
        }
    }
}
