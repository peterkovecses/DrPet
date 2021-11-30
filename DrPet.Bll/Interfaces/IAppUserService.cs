using DrPet.Bll.DTOs;
using System.Threading.Tasks;

namespace DrPet.Bll.Interfaces
{
    public interface IAppUserService
    {
        public Task<AppUserDTO> GetAppUserAsync(string email);        
    }
}
