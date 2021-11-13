using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Data;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DrPet.Bll.Services
{
    public class WorkerService : IWorkerService
    {
        public WorkerService(DrPetDbContext dbContext) => DbContext = dbContext;

        public DrPetDbContext DbContext { get; }

        private Expression<Func<Data.Entities.Worker, Doctor>> DoctorSelector = d => new Doctor
        {
            Id = d.Id,
            Name = d.Name,
            PublicDescription = d.PublicDescription
        };


        public async Task<IList<Doctor>> GetDoctorsAsync()
        {
            var doctors = DbContext.Workers.Where(w => w.Position == Position.Doctor);
            return (await doctors
                .Select(d => new Doctor { Id = d.Id, Name = d.Name, PublicDescription = d.PublicDescription,
                    ShortPublicDescription = ShortPublicDescription(d.PublicDescription)
                })
                .ToListAsync())
                .OrderBy(d => d.Name)
                .ToList();
        }

        public static string ShortPublicDescription(string publicDescription)
        {
            if (publicDescription == null)
                return "";
            if (publicDescription.Length < 201)
                return publicDescription;

            return publicDescription.Substring(0, 200) + "...";
        }

        public async Task<Doctor> GetDoctorAsync(int id)
        {
            return await DbContext.Workers
                .Where(w => w.Id == id)
                .Select(DoctorSelector)
                .SingleOrDefaultAsync();
        }
        public void DeleteWorker(int id)
        {
            DbContext.Workers.Remove(new Data.Entities.Worker { Id = id });
            DbContext.SaveChanges();
        }

        public async Task AddOrUpdateDoctorAsync(Doctor doctor)
        {
            EntityEntry<Data.Entities.Worker> entry;

            // update
            if (doctor.Id != 0)
                entry = DbContext.Entry(await DbContext.Workers.FindAsync(doctor.Id));
            // create
            else                
                entry = DbContext.Add(new Data.Entities.Worker()); // empty entity

            entry.CurrentValues.SetValues(doctor);

            await DbContext.SaveChangesAsync();
        }
    }
}
