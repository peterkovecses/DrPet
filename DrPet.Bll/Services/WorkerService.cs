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
using Microsoft.AspNetCore.Identity;

namespace DrPet.Bll.Services
{
    public class WorkerService : IWorkerService
    {
        public DrPetDbContext DbContext { get; }
        public UserManager<AppUser> UserManager { get; }

        public WorkerService(DrPetDbContext dbContext, UserManager<AppUser> userManager)
        {
            DbContext = dbContext;
            UserManager = userManager;
        }

        private Expression<Func<Worker, DoctorDTO>> DoctorSelector = d => new DoctorDTO
        {
            Id = d.Id,
            Name = d.Name,
            PublicDescription = d.PublicDescription,
            ShortPublicDescription = d.PublicDescription.Shorten(200),
            PhotoPath = d.PhotoPath
        };

        public async Task<IList<DoctorDTO>> GetDoctorsAsync()
        {
            return (await DbContext.Workers.Where(w => w.Position == Position.Doctor)
                .Select(DoctorSelector)
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
                    PhotoPath = doctorDTO.PhotoPath
                };

                worker.AppUserWorkers = new List<AppUserWorker>
                {
                    new AppUserWorker
                    {
                        AppUserId = doctorDTO.AppUserId,
                        // The WorkerId properties value will be the id what will be given to the Worker entity
                        WorkerId = doctorDTO.Id
                    }
                };

                DbContext.Add(worker);

                var appUser = await DbContext.AppUsers
                .Where(au => au.Email == doctorDTO.Email)
                .SingleAsync();

                await UserManager.AddToRoleAsync(appUser, "Doctors");
            }

            await DbContext.SaveChangesAsync();
        }

        public async Task<int> GetDoctorIdByAppUserIdAsync(int id)
        {
            return await DbContext.AppUserWorkers.Where(auw => auw.AppUserId == id).Select(auw => auw.WorkerId).SingleAsync();
        }

        public async Task<DoctorDTO> GetDoctorByAppUserIdAsync(int id)
        {
            return await DbContext.Workers.Include(w => w.AppUserWorkers).Where(w => w.AppUserWorkers.FirstOrDefault().AppUserId == id).Select(DoctorSelector).SingleAsync();
        }

        public async Task<string> GetDoctorPhotoPathAsync(int id)
        {
            return await DbContext.Workers.Where(w => w.Id == id).Select(w => w.PhotoPath).SingleAsync();
        }
    }
}
