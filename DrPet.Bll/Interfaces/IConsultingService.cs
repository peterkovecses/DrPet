using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Models;

namespace DrPet.Bll.Interfaces
{
    public interface IConsultingService
    {
        public Task<IReadOnlyCollection<Consulting>> GetConsultingsAsync(DateTime from, DateTime till, int? workerId = null, int? piece = null);

        public Task<IEnumerable<Consulting>> GetMonthlyConsultingsAsync(string? date);
    }
}
