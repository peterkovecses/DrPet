﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrPet.Data.Seed.Interfaces
{
    public interface IUserSeedService
    {
        Task SeedUserAsync();
    }
}