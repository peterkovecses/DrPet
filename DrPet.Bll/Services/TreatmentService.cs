using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Data;
using DrPet.Data.Entities;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DrPet.Bll.Services
{
    public class TreatmentService : ITreatmentService
    {
        public DrPetDbContext DbContext { get; }

        public TreatmentService(DrPetDbContext dbContext)
        {
            DbContext = dbContext;
        }

        private Expression<Func<Treatment, TreatmentDTO>> TreatmentSelector = t => new TreatmentDTO
        {
            Id = t.Id,
            Date = t.Date,
            MedicineId = t.MedicineId,
            MedicineName = t.Medicine.Name,
            TypeId = t.TypeId,
            TypeName = t.Type.Name,
            OwnerId = t.OwnerId,
            OwnerName = t.Owner.Name,
            PetId = t.PetId,
            PetName = t.Pet.Name,
            WorkerId = t.WorkerId,
            WorkerName = t.Worker.Name,            
            ConsultingId = t.ConsultingId,
            PurchaseStatus = t.PurchaseStatus,
            Comment = t.Comment
        };

        public async Task<IList<TreatmentDTO>> GetTreatmentsAsync()
        {
            return (await DbContext.Treatments
                .Select(TreatmentSelector)
                .ToListAsync())
                .OrderByDescending(t => t.Date)
                .ToList();
        }

        public async Task<TreatmentDTO> GetTreatmentAsync(int id)
        {
            return await DbContext.Treatments
                .Where(t => t.Id == id)
                .Select(TreatmentSelector)
                .SingleOrDefaultAsync();
        }

        public async Task AddOrUpdateTreatmentAsync(TreatmentDTO treatmentDTO)
        {
            
            // update
            if (treatmentDTO.Id != 0)
            {
                var treatment = await DbContext.Treatments.FindAsync(treatmentDTO.Id);
                treatment.TypeId = treatmentDTO.TypeId;
                treatment.MedicineId = treatmentDTO.MedicineId;
                treatment.Comment = treatmentDTO.Comment;
            }

            // create
            else
            {
                var treatment = new Treatment
                {
                    Date = treatmentDTO.Date,
                    MedicineId = treatmentDTO.MedicineId,
                    TypeId = treatmentDTO.TypeId,
                    OwnerId = treatmentDTO.OwnerId,
                    PetId = treatmentDTO.PetId,
                    WorkerId = treatmentDTO.WorkerId,
                    ConsultingId = treatmentDTO.ConsultingId,
                    PurchaseStatus = treatmentDTO.PurchaseStatus,
                    Comment = treatmentDTO.Comment
                };

                DbContext.Treatments.Add(treatment);
            }

            await DbContext.SaveChangesAsync();           
        }

        public void DeleteTreatment(int id)
        {
            DbContext.Treatments.Remove(new Treatment { Id = id });
            DbContext.SaveChanges();
        }

        public async Task<IList<MedicineDTO>> GetMedicinesAsync()
        {
            return (await DbContext.Medicines
                .Select(m => new MedicineDTO
                {
                    Id = m.Id,
                    Name = m.Name
                })
                .ToListAsync())
                .OrderBy(m => m.Name)
                .ToList();
        }

        public async Task<IList<TreatmentTypeDTO>> GetTreatmentTypesAsync()
        {
            return (await DbContext.TreatmentTypes
                .Select(t => new TreatmentTypeDTO
                {
                    Id = t.Id,
                    Name = t.Name,
                    Price = t.Price
                })
                .ToListAsync())
                .OrderBy(t => t.Name)
                .ToList();
        }
    }
}
