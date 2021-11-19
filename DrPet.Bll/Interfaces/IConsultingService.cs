using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.DTOs;

namespace DrPet.Bll.Interfaces
{
    public interface IConsultingService
    {
        public Task<IList<ConsultingDTO>> GetConsultingsAsync(DateTime from, DateTime? till, int? workerId = null, int? piece = null);

        public Task<IList<ConsultingDTO>> GetMonthlyConsultingsAsync(string? date);

        public Task<ConsultingDTO> GetConsultingAsync(DateTime date, int workerId);

        public void DeleteConsulting(int id);

        public Task AddOrUpdateConsultingAsync(ConsultingDTO consulting);

        public Task<ConsultingDTO> GetConsultingAsync(int id);
    }
}
