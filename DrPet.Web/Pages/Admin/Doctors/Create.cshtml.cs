using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DrPet.Web.Interfaces;
using DrPet.Web.Enums;

namespace DrPet.Web.Pages.Admin.Doctors
{
    public class CreateModel : PageModel
    {
        public IWorkerService WorkerService { get; }
        public IAppUserService AppUserService { get; }
        public IFileOperationService FileOperationService { get; }

        public CreateModel(IWorkerService workerService, IAppUserService appUserService, IFileOperationService fileOperationService)
        {
            WorkerService = workerService;
            AppUserService = appUserService;
            FileOperationService = fileOperationService;
        }

        [BindProperty]
        public DoctorDTO Doctor { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) 
                return Page();

            // First connect a doctor with an app user by email
            if (Doctor.Email == null)
            {
                ModelState.AddModelError("Doctor.Email", "E-mail c�m megad�sa k�telez�.");
                return Page();
            }

            var appUserDTO = await AppUserService.GetAppUserAsync(Doctor.Email);                

            // User must be registered first
            if (appUserDTO == null)
            {
                ModelState.AddModelError("Doctor.Email", "Ilyen e-mail c�mmel nem tal�lhat� felhaszn�l�. Els�k�nt az orvosnak felhaszn�l�nak kell regisztr�lnia.");
                return Page();
            }

            // This email address is already recorded for another user
            if (appUserDTO.WorkerId  != null)
            {
                ModelState.AddModelError("Doctor.Email", "Az e-mail c�m m�r megvan adva m�sik orvoshoz.");
                return Page();
            }

            Doctor.AppUserId = appUserDTO.Id;

            // File upload (photo)
            if (Doctor.Photo != null && !string.IsNullOrEmpty(Doctor.Photo.FileName))
            {
                var result = await FileOperationService.SaveFileAsync(Doctor);                

                if (result.Item2 == FileErrorType.NotAllowedExtension)
                {
                    ModelState.AddModelError("Doctor.Photo", "A k�p kiterjeszt�se nem megfelel�.");
                    return Page();
                }

                if (result.Item2 == FileErrorType.Size)
                {
                    ModelState.AddModelError("Doctor.Photo", "Maxim�lis k�pm�ret: 5 MB.");
                    return Page();
                }

                Doctor.PhotoPath = result.Item1;
            }


            // Save the doctor to the database
            await WorkerService.AddOrUpdateDoctorAsync(Doctor);

            return RedirectToPage("./Index");
        }
    }
}
