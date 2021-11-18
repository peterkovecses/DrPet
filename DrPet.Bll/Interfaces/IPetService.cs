using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Models;

namespace DrPet.Bll.Interfaces
{
    public interface IPetService
    {
        public Task<IList<Pet>> GetPetsAsync();

        public Task<Pet> GetPetAsync(int id);

        public void DeletePet(int id);

        public Task AddOrUpdatePetAsync(Pet pet);

        public Task<IList<Variety>> GetVarietiesAsync();

        public Task AddOrUpdatePeOwnershipAsync(Pet pet);

        public Task<int> GetOwnerId(int id);
    }
}
