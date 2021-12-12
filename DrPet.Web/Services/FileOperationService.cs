﻿using DrPet.Bll.DTOs;
using DrPet.Bll.Helpers;
using DrPet.Web.Enums;
using DrPet.Web.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DrPet.Web.Services
{
    public class FileOperationService : IFileOperationService
    {
        private readonly IWebHostEnvironment _environment;
        private readonly long _maxFileSize;
        private readonly List<string> _allowedExtensions;

        public FileOperationService(IWebHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            _maxFileSize = configuration.GetValue<long>("MaxFileSize");
            _allowedExtensions = configuration.GetSection("AllowedExtensions").Get<List<string>>();
        }

        public async Task<(string, FileErrorType?)> SaveFileAsync(DoctorDTO doctor)
        {
            var fileName = doctor.Photo.FileName;

            var ext = Path.GetExtension(fileName).ToLowerInvariant();

            if (string.IsNullOrEmpty(ext) || !_allowedExtensions.Contains(ext))
            {
                return (null, FileErrorType.NotAllowedExtension);
            }

            if (doctor.Photo.Length > _maxFileSize)
            {
                return (null, FileErrorType.Size);
            }

            var photoPath = $"doctorImages/{doctor.Name.ToLower()}{DateTime.Now}".RemoveStrings(new string[] { " ", ".", "-", ":" }).RemoveAccents();
            photoPath = $"{photoPath}{ext}";

            var filePath = Path.Combine(_environment.WebRootPath, photoPath);

            using (var stream = System.IO.File.Create(filePath))
            {
                await doctor.Photo.CopyToAsync(stream);
            }

            return (photoPath, null);
        }
    }
}
