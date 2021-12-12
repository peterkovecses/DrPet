using DrPet.Bll.DTOs;
using DrPet.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrPet.Web.Interfaces
{
    public interface IFileOperationService
    {
        public Task<(string, FileErrorType?)> SaveFileAsync(DoctorDTO doctor);
    }
}
