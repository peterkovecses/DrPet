using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.Admin.Doctors
{
    public class CreateModel : PageModel
    {
        public IWorkerService WorkerService { get; }
        public IAppUserService AppUserService { get; }

        public CreateModel(IWorkerService workerService, IAppUserService appUserService)
        {
            WorkerService = workerService;
            AppUserService = appUserService;
        }

        [BindProperty]
        public DoctorDTO Doctor { get; set; }

        [BindProperty]
        public string UnsuccessMessage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            var appUser = await AppUserService.GetAppUserAsync(Doctor.Email);

            // User must be registered first
            if (appUser == null)
            {
                UnsuccessMessage = "Ilyen e-mail címmel nem található felhasználó. Elsõként az orvosnak felhasználónak kell regisztrálnia.";
                return Page();
            }

            // This email address is already recorded for another user
            if (appUser.WorkerId  != null)
            {
                UnsuccessMessage = "Az e-mail cím már megvan adva másik orvoshoz.";
                return Page();
            }

            Doctor.AppUserId = appUser.Id;

            await WorkerService.AddOrUpdateDoctorAsync(Doctor);

            return RedirectToPage("./Index");
        }
    }
}
