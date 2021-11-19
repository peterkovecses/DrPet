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
    public class PetService : IPetService
    {
        public DrPetDbContext DbContext { get; }

        public PetService(DrPetDbContext dbContext)
        {
            DbContext = dbContext;
        }

        private Expression<Func<Pet, PetDTO>> PetSelector = p => new PetDTO
        {
            Id = p.Id,
            Name = p.Name,
            Birthdate = p.Birthdate,
            Comment = p.Comment,
            VarietyId = p.VarietyId,
            VarietyName = p.Variety.Name,
            OwnerId = p.PetOwnerships.Select(po => po.OwnerId).SingleOrDefault(),
            OwnerName = p.PetOwnerships.Select(po => po.Owner.Name).SingleOrDefault()            
        };

        public async Task<IList<PetDTO>> GetPetsAsync()
        {
            return (await DbContext.Pets
                .Select(PetSelector)
                .ToListAsync())
                .OrderBy(p => p.Name)
                .ToList();
        }        

        public async Task<PetDTO> GetPetAsync(int id)
        {
            return await DbContext.Pets
                .Where(p => p.Id == id)
                .Select(PetSelector)
                .SingleOrDefaultAsync();
        }

        public void DeletePet(int id)
        {
            DbContext.Pets.Remove(new Data.Entities.Pet { Id = id });
            DbContext.SaveChanges();
        }

        public async Task AddOrUpdatePetAsync(PetDTO pet)
        {
            EntityEntry<Pet> entry;

            // update
            if (pet.Id != 0)
                entry = DbContext.Entry(await DbContext.Pets.FindAsync(pet.Id));
            // create
            else
                entry = DbContext.Add(new Data.Entities.Pet()); // empty entity

            entry.CurrentValues.SetValues(pet);            

            await DbContext.SaveChangesAsync();
        }

        public async Task<IList<VarietyDTO>> GetVarietiesAsync()
        {
            return (await DbContext.Varieties
                .Select(v => new VarietyDTO
                { 
                    Id = v.Id, 
                    Name = v.Name, 
                    SpeciesId = v.SpeciesId 
                })
                .ToListAsync())
                .OrderBy(v => v.Name)
                .ToList();
        }

        public async Task AddOrUpdatePeOwnershipAsync(PetDTO pet)
        {            
            var petOwnership = await DbContext.PetOwnerships.SingleOrDefaultAsync(po => po.PetId == pet.Id);

            var newPetOwnership = new PetOwnership { PetId = pet.Id, OwnerId = pet.OwnerId };

            // update
            if (petOwnership != null)
            {
                DbContext.PetOwnerships.Remove(petOwnership);

                DbContext.PetOwnerships.Add(newPetOwnership);
            }

            // create
            else
                DbContext.PetOwnerships.Add(newPetOwnership);

            await DbContext.SaveChangesAsync();
        }

        public async Task<int> GetOwnerId(int id)
        {
            var petOwnership = await DbContext.PetOwnerships.SingleOrDefaultAsync(po => po.PetId == id);
            return petOwnership.OwnerId;
        }
    }
}
