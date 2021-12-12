using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.DTOs;

namespace DrPet.Bll.Interfaces
{
    public interface IWorkerService
    {
        public Task<IList<DoctorDTO>> GetDoctorsAsync();

        public Task<DoctorDTO> GetDoctorAsync(int id);

        public void DeleteWorker(int id);

        public Task AddOrUpdateDoctorAsync(DoctorDTO doctor);

        public Task<int> GetDoctorIdByAppUserIdAsync(int id);

        public Task<DoctorDTO> GetDoctorByAppUserIdAsync(int id);

        public Task<string> GetDoctorPhotoPathAsync(int id);
    }
}
