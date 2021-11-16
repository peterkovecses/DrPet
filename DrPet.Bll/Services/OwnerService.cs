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
    public class OwnerService : IOwnerService
    {
        public DrPetDbContext DbContext { get; }

        public OwnerService(DrPetDbContext dbContext)
        {
            DbContext = dbContext;
        }

        private Expression<Func<Data.Entities.Owner, Owner>> OwnerSelector = o => new Owner
        {
            Id = o.Id,
            Name = o.Name,
            Birthdate = o.Birthdate,
            Location = o.Location,
            Comment = o.Comment
            
        };

        public async Task<IList<Owner>> GetOwnersAsync()
        {
            var owners = DbContext.Owners;
            return (await owners
                .Select(OwnerSelector)
                .ToListAsync())
                .OrderBy(o => o.Name)
                .ToList();
        }

        public async Task<Owner> GetOwnerAsync(int id)
        {
            return await DbContext.Owners
                .Where(o => o.Id == id)
                .Select(OwnerSelector)
                .SingleOrDefaultAsync();
        }

        public async Task AddOrUpdateOwnerAsync(Owner owner)
        {
            EntityEntry<Data.Entities.Owner> entry;

            // update
            if (owner.Id != 0)
                entry = DbContext.Entry(await DbContext.Owners.FindAsync(owner.Id));
            // create
            else
                entry = DbContext.Add(new Data.Entities.Owner()); // empty entity

            entry.CurrentValues.SetValues(owner);

            await DbContext.SaveChangesAsync();
        }

        public void DeleteOwner(int id)
        {
            DbContext.Owners.Remove(new Data.Entities.Owner { Id = id });
            DbContext.SaveChanges();
        }               
    }
}
