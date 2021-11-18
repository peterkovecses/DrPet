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

namespace DrPet.Bll.Interfaces
{
    public interface ITreatmentService
    {
        public Task<IList<Treatment>> GetTreatmentsAsync();

        public Task<Treatment> GetTreatmentAsync(int id);

        public void DeleteTreatment(int id);

        public Task AddOrUpdateTreatmentAsync(Treatment treatment, Purchase purchase);

        public Task<IList<Medicine>> GetMedicinesAsync();

        public Task<IList<TreatmentType>> GetTreatmentTypesAsync();
    }
}
