using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.DTOs;

namespace DrPet.Bll.Interfaces
{
    public interface ITreatmentService
    {
        public Task<IList<TreatmentDTO>> GetTreatmentsAsync();

        public Task<TreatmentDTO> GetTreatmentAsync(int id);

        public void DeleteTreatment(int id);

        public Task AddOrUpdateTreatmentAsync(TreatmentDTO treatment);

        public Task<IList<MedicineDTO>> GetMedicinesAsync();

        public Task<IList<TreatmentTypeDTO>> GetTreatmentTypesAsync();
    }
}
