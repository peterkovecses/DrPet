using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.DTOs;

namespace DrPet.Bll.Interfaces
{
    public interface IPetService
    {
        public Task<IList<PetDTO>> GetPetsAsync();

        public Task<PetDTO> GetPetAsync(int id);

        public void DeletePet(int id);

        public Task AddOrUpdatePetAsync(PetDTO pet);

        public Task<IList<VarietyDTO>> GetVarietiesAsync();

        public Task<int> GetOwnerId(int id);
    }
}
