using DrPet.Bll.DTOs;
using DrPet.Web.Enums;
using System.Threading.Tasks;

namespace DrPet.Web.Interfaces
{
    public interface IFileOperationService
    {
        public Task<(string, FileErrorType?)> SaveFileAsync(DoctorDTO doctor);
    }
}
