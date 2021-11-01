using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Models;

namespace DrPet.Bll.Interfaces
{
    public interface IWorkerService
    {
        public Task<IReadOnlyCollection<Doctor>> GetDoctorsAsync();
    }
}
