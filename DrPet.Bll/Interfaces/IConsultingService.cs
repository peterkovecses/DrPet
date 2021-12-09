using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.DTOs;

namespace DrPet.Bll.Interfaces
{
    public interface IConsultingService
    {
        public Task<IList<ConsultingDTO>> GetConsultingsAsync(DateTime from, DateTime? till, int? workerId, int? piece);

        public Task<IList<ConsultingDTO>> GetMonthlyConsultingsAsync(DateTime? date, int? workerId, int? piece);

        public Task<IList<ConsultingDTO>> GetActualWeekConsultingsAsync(int? doctorId, int? piece);

        public Task<ConsultingDTO> GetConsultingAsync(DateTime date, int workerId);

        public void DeleteConsulting(int id);

        public Task AddOrUpdateConsultingAsync(ConsultingDTO consulting);

        public Task<ConsultingDTO> GetConsultingAsync(int id);
    }
}
