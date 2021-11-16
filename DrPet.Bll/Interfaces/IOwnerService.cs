using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Models;

namespace DrPet.Bll.Interfaces
{
    public interface IOwnerService
    {
        public Task<IList<Owner>> GetOwnersAsync();

        public Task<Owner> GetOwnerAsync(int id);

        public void DeleteOwner(int id);

        public Task AddOrUpdateOwnerAsync(Owner owner);
    }
}
