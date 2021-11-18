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
    public class PetService : IPetService
    {
        public DrPetDbContext DbContext { get; }

        public PetService(DrPetDbContext dbContext)
        {
            DbContext = dbContext;
        }

        private Expression<Func<Data.Entities.Pet, Pet>> PetSelector = p => new Pet
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

        public async Task<IList<Pet>> GetPetsAsync()
        {
            var pets = DbContext.Pets;
            return (await pets
                .Select(PetSelector)
                .ToListAsync())
                .OrderBy(p => p.Name)
                .ToList();
        }        

        public async Task<Pet> GetPetAsync(int id)
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

        public async Task AddOrUpdatePetAsync(Pet pet)
        {
            EntityEntry<Data.Entities.Pet> entry;

            // update
            if (pet.Id != 0)
                entry = DbContext.Entry(await DbContext.Pets.FindAsync(pet.Id));
            // create
            else
                entry = DbContext.Add(new Data.Entities.Pet()); // empty entity

            entry.CurrentValues.SetValues(pet);            

            await DbContext.SaveChangesAsync();
        }

        public async Task<IList<Variety>> GetVarietiesAsync()
        {
            var varieties = DbContext.Varieties;
            return (await varieties
                .Select(v => new Variety
                { 
                    Id = v.Id, 
                    Name = v.Name, 
                    SpeciesId = v.SpeciesId 
                })
                .ToListAsync())
                .OrderBy(v => v.Name)
                .ToList();
        }

        public async Task AddOrUpdatePeOwnershipAsync(Pet pet)
        {            
            var petOwnership = await DbContext.PetOwnerships.SingleOrDefaultAsync(po => po.PetId == pet.Id);

            var newPetOwnership = new Data.Entities.PetOwnership { PetId = pet.Id, OwnerId = pet.OwnerId };

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
    }
}
