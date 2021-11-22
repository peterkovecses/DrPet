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

        public async Task AddOrUpdateDoctorAsync(DoctorDTO doctor)
        {
            EntityEntry<Worker> entry;

            // update
            if (doctor.Id != 0)
            {
                var worker = await DbContext.Workers.FindAsync(doctor.Id);
                worker.DateOfUpdate = DateTime.Now;
                entry = DbContext.Entry(worker);
            }
            
            // create
            else                
                entry = DbContext.Add(new Worker { DateOfCreation = DateTime.Now }); // empty entity

            entry.CurrentValues.SetValues(doctor);

            await DbContext.SaveChangesAsync();{}
        }
    }
}
