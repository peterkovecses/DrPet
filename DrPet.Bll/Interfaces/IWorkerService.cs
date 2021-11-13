using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Models;

namespace DrPet.Bll.Interfaces
{
    public interface IWorkerService
    {
        public Task<IList<Doctor>> GetDoctorsAsync();

        public Task<Doctor> GetDoctorAsync(int id);

        public void DeleteWorker(int id);

        public Task AddOrUpdateDoctorAsync(Doctor doctor);
    }
}
