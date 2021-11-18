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
    public class TreatmentService : ITreatmentService
    {
        public DrPetDbContext DbContext { get; }

        public TreatmentService(DrPetDbContext dbContext)
        {
            DbContext = dbContext;
        }

        private Expression<Func<Data.Entities.Treatment, Treatment>> TreatmentSelector = t => new Treatment
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
            Comment = t.Comment
        };

        public async Task<IList<Treatment>> GetTreatmentsAsync()
        {
            var treatments = DbContext.Treatments;
            return (await treatments
                .Select(TreatmentSelector)
                .ToListAsync())
                .OrderByDescending(t => t.Date)
                .ToList();
        }

        public async Task<Treatment> GetTreatmentAsync(int id)
        {
            return await DbContext.Treatments
                .Where(t => t.Id == id)
                .Select(TreatmentSelector)
                .SingleOrDefaultAsync();
        }

        public async Task AddOrUpdateTreatmentAsync(Treatment treatment, Purchase? purchase)
        {
            //EntityEntry<Data.Entities.Treatment> entry;
            
            // update
            if (treatment.Id != 0)
            {
                var t = await DbContext.Treatments.FindAsync(treatment.Id);
                t.TypeId = treatment.TypeId;
                t.MedicineId = treatment.MedicineId;
                t.Comment = treatment.Comment;


            }

            // create (if create, purchase is never null)
            else
            {
                // make a Purchase entity ford the database
                var p = new Data.Entities.Purchase
                {
                    Date = purchase.Date,
                    OwnerId = purchase.OwnerId,
                    PetId = purchase.PetId,
                    Status = Data.PurchaseStatus.WaitinForPayment
                };

                DbContext.Purchases.Add(p);
                // for get the PurchaseId
                await DbContext.SaveChangesAsync();

                var purchases = DbContext.Purchases.Where(p => p.OwnerId == purchase.OwnerId);
                purchases = purchases.Where(p => p.PetId == purchase.PetId);
                purchases = purchases.Where(p => p.Date == purchase.Date);

                // I have the PurchaseId
                treatment.PurchaseId = purchases.FirstOrDefault().Id;

                var t = new Data.Entities.Treatment
                {
                    Date = treatment.Date,
                    MedicineId = treatment.MedicineId,
                    TypeId = treatment.TypeId,
                    OwnerId = treatment.OwnerId,
                    PetId = treatment.PetId,
                    WorkerId = treatment.WorkerId,
                    ConsultingId = treatment.ConsultingId,
                    PurchaseId = treatment.PurchaseId,
                    Comment = treatment.Comment
                };

                DbContext.Treatments.Add(t);
            }

            await DbContext.SaveChangesAsync();           
        }

        public void DeleteTreatment(int id)
        {
            DbContext.Treatments.Remove(new Data.Entities.Treatment { Id = id });
            DbContext.SaveChanges();
        }

        public async Task<IList<Medicine>> GetMedicinesAsync()
        {
            var medicines = DbContext.Medicines;
            return (await medicines
                .Select(m => new Medicine
                {
                    Id = m.Id,
                    Name = m.Name
                })
                .ToListAsync())
                .OrderBy(m => m.Name)
                .ToList();
        }

        public async Task<IList<TreatmentType>> GetTreatmentTypesAsync()
        {
            var treatmentTypes = DbContext.TreatmentTypes;
            return (await treatmentTypes
                .Select(t => new TreatmentType
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
