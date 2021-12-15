using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Data;
using DrPet.Data.Entities;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using DrPet.Bll.Helpers;

namespace DrPet.Bll.Services
{
    public class ConsultingService : IConsultingService
    {
        public DrPetDbContext DbContext { get; }

        public ConsultingService(DrPetDbContext dbContext) => DbContext = dbContext;

        private Expression<Func<Consulting, ConsultingDTO>> ConsultingSelector = c => new ConsultingDTO
        {
            Id = c.Id,
            StartOfConsulting = c.StartOfConsulting,
            EndOfConsulting = c.EndOfConsulting,
            WorkerId = c.WorkerId,
            WorkerName = c.Worker.Name
        };

        public async Task<IList<ConsultingDTO>> GetConsultingsAsync(DateTime from, DateTime? till, int? workerId, int? piece)
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

        public async Task<IList<ConsultingDTO>> GetMonthlyConsultingsAsync(DateTime? date, int? workerId, int? piece)
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
                from = (DateTime)date;
                from = new DateTime(from.Year, from.Month, 1);
                till = from.AddMonths(1);
            }            
            return await GetConsultingsAsync(from, till, workerId, piece);
        }

        public async Task<IList<ConsultingDTO>> GetActualWeekConsultingsAsync(int? doctorId, int? piece)
        {
            var from = DateTime.Now.FirstDayOfWeek(DayOfWeek.Monday);
            var till = from.AddDays(7);
            return await GetConsultingsAsync(from, till, doctorId, piece);
        }

        public async Task<ConsultingDTO> GetConsultingAsync(DateTime date, int workerId)
        {
            var consultings = DbContext.Consultings.Where(c => c.StartOfConsulting <= date);

            consultings = consultings.Where(c => c.EndOfConsulting >= date);

            consultings = consultings.Where(c => c.WorkerId == workerId);

            return await consultings
                .Select(ConsultingSelector)
                .SingleOrDefaultAsync();
        }

        public void DeleteConsulting(int id)
        {
            DbContext.Consultings.Remove(new Consulting { Id = id });
            DbContext.SaveChanges();
        }

        public async Task AddOrUpdateConsultingAsync(ConsultingDTO consultingDTO)
        {
            EntityEntry<Consulting> entry;

            // update
            if (consultingDTO.Id != 0)
            {
                var consulting = await DbContext.Consultings.FindAsync(consultingDTO.Id);
                entry = DbContext.Entry(consulting);
            }    
            
            // create
            else
                entry = DbContext.Add(new Consulting { DateOfCreation = DateTime.Now });

            entry.CurrentValues.SetValues(consultingDTO);            

            await DbContext.SaveChangesAsync();
        }

        public async Task<ConsultingDTO> GetConsultingAsync(int id)
        {
            return await DbContext.Consultings
                .Where(c => c.Id == id)
                .Select(ConsultingSelector)
                .SingleOrDefaultAsync();
        }        
    }
}
