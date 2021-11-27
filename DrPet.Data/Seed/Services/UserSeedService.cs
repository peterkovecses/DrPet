using DrPet.Data.Entities;
using DrPet.Data.Seed.Interfaces;
using DrPet.Web.Settings;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DrPet.Data.Seed.Services
{
    public class UserSeedService : IUserSeedService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AdminSettings _adminSettings;

        public UserSeedService(UserManager<AppUser> userManager, IOptions<AdminSettings> adminSettings)
        {
            _userManager = userManager;
            _adminSettings = adminSettings.Value;
        }

        public async Task SeedUserAsync()
        {
            // if there is no user with this role
            if (!(await _userManager.GetUsersInRoleAsync("Administrators")).Any())
            {
                var appUser = new AppUser
                {
                    UserName = _adminSettings.UserName,
                    Email = _adminSettings.Email,
                    Name = _adminSettings.Name,
                    SecurityStamp = Guid.NewGuid().ToString() // random string
                };

                // create the user
                var createResult = await _userManager.CreateAsync(appUser, _adminSettings.Password);

                // if the registration needs to be confirmed
                if (_userManager.Options.SignIn.RequireConfirmedAccount)
                {
                    // confirm the registration
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);
                    var result = await _userManager.ConfirmEmailAsync(appUser, code);
                }

                // set the user's permissions
                var addToRoleResult = await _userManager.AddToRoleAsync(appUser, "Administrators");

                if (!createResult.Succeeded || !addToRoleResult.Succeeded)
                {
                    throw new ApplicationException("Nem sikerült létrehozni az adminisztrátor felhasználót: " +
                        string.Join(", ", createResult.Errors.Concat(addToRoleResult.Errors).Select(e => e.Description)));
                }
            }
        }
    }
}
