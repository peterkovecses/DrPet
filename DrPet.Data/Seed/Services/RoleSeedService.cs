﻿using DrPet.Data.Seed.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace DrPet.Data.Seed.Services
{
    public class RoleSeedService : IRoleSeedService
    {
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public RoleSeedService(RoleManager<IdentityRole<int>> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task SeedRoleAsync()
        {
            // if the role does not exist
            if (!await _roleManager.RoleExistsAsync("Administrators"))
                // creating the role
                await _roleManager.CreateAsync(new IdentityRole<int> { Name = "Administrators" });

            if (!await _roleManager.RoleExistsAsync("Doctors"))
                await _roleManager.CreateAsync(new IdentityRole<int> { Name = "Doctors" });            
        }
    }
}
