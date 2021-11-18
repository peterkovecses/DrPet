using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Models;

namespace DrPet.Bll.Interfaces
{
    public interface IConsultingService
    {
        public Task<IList<Consulting>> GetConsultingsAsync(DateTime from, DateTime? till, int? workerId = null, int? piece = null);

        public Task<IList<Consulting>> GetMonthlyConsultingsAsync(string? date);

        public Task<Consulting> GetConsultingAsync(DateTime date, int workerId);

        public void DeleteConsulting(int id);

        public Task AddOrUpdateConsultingAsync(Consulting consulting);

        public Task<Consulting> GetConsultingAsync(int id);
    }
}
