using DrPet.Bll.DTOs;
using DrPet.Bll.Interfaces;
using DrPet.Data;
using DrPet.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DrPet.Bll.Services
{
    public class AppUserService : IAppUserService
    {
        public DrPetDbContext DbContext { get; }

        public AppUserService(DrPetDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<AppUserDTO> GetAppUserAsync(string email)
        {
            return await DbContext.AppUsers
                .Where(au => au.Email == email)
                .Select(au => new AppUserDTO
                {
                    Id = au.Id,
                    Email = au.Email,
                    WorkerId = au.AppUserWorkers.Where(auw => auw.AppUserId == au.Id).SingleOrDefault().Id
                })
                .SingleOrDefaultAsync();
        }
    }
}
