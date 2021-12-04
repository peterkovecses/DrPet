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
            OwnerId = p.PetOwnerships.Select(po => po.OwnerId).FirstOrDefault(),
            OwnerName = p.PetOwnerships.Select(po => po.Owner.Name).FirstOrDefault()            
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

        public async Task AddOrUpdatePetAsync(PetDTO petDTO)
        {            
            // update
            if (petDTO.Id != 0)
            {

                var pet = await DbContext.Pets.Include(p => p.PetOwnerships).Where(p => p.Id == petDTO.Id).SingleAsync();


                pet.Name = petDTO.Name;
                pet.Birthdate = petDTO.Birthdate;
                pet.VarietyId = petDTO.VarietyId;
                pet.Comment = petDTO.Comment;
                pet.DateOfUpdate = DateTime.Now;

                var ownership = pet.PetOwnerships.Where(o => o.OwnerId == petDTO.PrevOwnerId).SingleOrDefault();

                if (ownership == null)
                    ownership = new PetOwnership();

                ownership.OwnerId = petDTO.OwnerId;
                ownership.DateOfUpdate = pet.DateOfUpdate;
            }
                
            // create
            else
            {
                var pet = new Pet
                {
                    Name = petDTO.Name,
                    Birthdate = petDTO.Birthdate,
                    VarietyId = petDTO.VarietyId,
                    Comment = petDTO.Comment,
                    DateOfCreation = DateTime.Now
                };

                pet.PetOwnerships = new List<PetOwnership>
                {
                    new PetOwnership
                    {
                        OwnerId = petDTO.OwnerId,
                        PetId = petDTO.Id,
                        DateOfCreation = DateTime.Now
                    }
                };

                DbContext.Add(pet);
            }
                           
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

        public async Task<int> GetOwnerId(int id)
        {
            var petOwnership = await DbContext.PetOwnerships.SingleOrDefaultAsync(po => po.PetId == id);
            return petOwnership.OwnerId;
        }
    }
}
