using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.DTOs;

namespace DrPet.Bll.Interfaces
{
    public interface IOwnerService
    {
        public Task<IList<OwnerDTO>> GetOwnersAsync();

        public Task<OwnerDTO> GetOwnerAsync(int id);

        public void DeleteOwner(int id);

        public Task AddOrUpdateOwnerAsync(OwnerDTO owner);
    }
}
