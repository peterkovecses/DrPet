using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Data;
using DrPet.Data.Entities;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DrPet.Bll.Services
{
    public class OwnerService : IOwnerService
    {
        public DrPetDbContext DbContext { get; }

        public OwnerService(DrPetDbContext dbContext)
        {
            DbContext = dbContext;
        }

        private Expression<Func<Owner, OwnerDTO>> OwnerSelector = o => new OwnerDTO
        {
            Id = o.Id,
            Name = o.Name,
            Birthdate = o.Birthdate,
            Location = o.Location,
            Comment = o.Comment

        };

        public async Task<IList<OwnerDTO>> GetOwnersAsync()
        {
            return (await DbContext.Owners
                .Select(OwnerSelector)
                .ToListAsync())
                .OrderBy(o => o.Name)
                .ToList();
        }

        public async Task<OwnerDTO> GetOwnerAsync(int id)
        {
            return await DbContext.Owners
                .Where(o => o.Id == id)
                .Select(OwnerSelector)
                .SingleOrDefaultAsync();
        }

        public async Task AddOrUpdateOwnerAsync(OwnerDTO ownerDTO)
        {
            EntityEntry<Owner> entry;

            // update
            if (ownerDTO.Id != 0)
            {
                var owner = await DbContext.Owners.FindAsync(ownerDTO.Id);
                owner.DateOfUpdate = DateTime.Now;
                entry = DbContext.Entry(owner);
            }

            // create
            else
                entry = DbContext.Add(new Owner { DateOfCreation = DateTime.Now });

            entry.CurrentValues.SetValues(ownerDTO);

            await DbContext.SaveChangesAsync();
        }

        public void DeleteOwner(int id)
        {
            DbContext.Owners.Remove(new Owner { Id = id });
            DbContext.SaveChanges();
        }
    }
}
