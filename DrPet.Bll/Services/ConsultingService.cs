using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Data;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.EntityFrameworkCore;

namespace DrPet.Bll.Services
{
    class ConsultingService : IConsultingService
    {
        public ConsultingService(DrPetDbContext dbContext) => DbContext = dbContext;

        public DrPetDbContext DbContext { get; }

        public async Task<IReadOnlyCollection<Models.Consulting>> GetConsultingsAsync(DateTime from, DateTime till, int? workerId = null, int? piece = null)
        {
            var consultings = DbContext.Consultings.Where(c => c.StartOfConsulting >= from && c.StartOfConsulting < till);
            if (workerId != null)
                consultings = consultings.Where(c => c.WorkerId == workerId);
            consultings = consultings.OrderBy(c => c.StartOfConsulting);
            if (piece != null)
                consultings = consultings.Take(piece.Value);
            return await consultings
                .Select(c => new Consulting(c.Id, c.StartOfConsulting, c.EndOfConsulting, c.WorkerId))
                .ToListAsync();
        }

        public async Task<IEnumerable<Models.Consulting>> GetMonthlyConsultingsAsync()
        {
            return await GetConsultingsAsync(new(DateTime.Today.Year, DateTime.Today.Month, 1), new(DateTime.Today.Year, DateTime.Today.Month + 1, 1));
        }
    }
}
