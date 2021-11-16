using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Data;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace DrPet.Bll.Services
{
    public class ConsultingService : IConsultingService
    {
        public DrPetDbContext DbContext { get; }

        public ConsultingService(DrPetDbContext dbContext) => DbContext = dbContext;

        private Expression<Func<Data.Entities.Consulting, Consulting>> ConsultingSelector = c => new Consulting
        {
            Id = c.Id,
            StartOfConsulting = c.StartOfConsulting,
            EndOfConsulting = c.EndOfConsulting,
            WorkerId = c.WorkerId,
            WorkerName = c.Worker.Name
        };

        public async Task<IList<Consulting>> GetConsultingsAsync(DateTime from, DateTime? till, int? workerId = null, int? piece = null)
        {
            var consultings = DbContext.Consultings.Where(c => c.StartOfConsulting >= from);

            if (till != null)
                consultings = consultings.Where(c => c.EndOfConsulting < till);

            if (workerId != null)
                consultings = consultings.Where(c => c.WorkerId == workerId);

            consultings = consultings.OrderBy(c => c.StartOfConsulting);

            if (piece != null)
                consultings = consultings.Take(piece.Value);

            return await consultings
                .Select(ConsultingSelector)
                .ToListAsync();
        }        

        public async Task<IList<Consulting>> GetMonthlyConsultingsAsync(string? date)
        {
            DateTime from;
            DateTime till;
            if (date == null)
            {
                from = new(DateTime.Today.Year, DateTime.Today.Month, 1);
                till = from.AddMonths(1);
            }
            else
            {
                from = DateTime.Parse(date);
                from = new DateTime(from.Year, from.Month, 1);
                till = from.AddMonths(1);
            }            
            return await GetConsultingsAsync(from, till);
        }

        public void DeleteConsulting(int id)
        {
            DbContext.Consultings.Remove(new Data.Entities.Consulting { Id = id });
            DbContext.SaveChanges();
        }

        public async Task AddOrUpdateConsultingAsync(Consulting consulting)
        {
            EntityEntry<Data.Entities.Consulting> entry;

            // update
            if (consulting.Id != 0)
                entry = DbContext.Entry(await DbContext.Consultings.FindAsync(consulting.Id));
            // create
            else
                entry = DbContext.Add(new Data.Entities.Consulting()); // empty entity

            entry.CurrentValues.SetValues(consulting);

            await DbContext.SaveChangesAsync();
        }

        public async Task<Consulting> GetConsultingAsync(int id)
        {
            return await DbContext.Consultings
                .Where(c => c.Id == id)
                .Select(ConsultingSelector)
                .SingleOrDefaultAsync();
        }
    }
}
