using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DrPet.Web.Interfaces;
using DrPet.Web.Enums;
using Ganss.XSS;

namespace DrPet.Web.Pages.Admin.Doctors
{
    public class EditModel : PageModel
    {
        public IWorkerService WorkerService { get; }
        public IFileOperationService FileOperationService { get; }

        public EditModel(IWorkerService workerService, IFileOperationService fileOperationService)
        {
            WorkerService = workerService;
            FileOperationService = fileOperationService;
        }

        [BindProperty]
        public DoctorDTO Doctor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            Doctor = await WorkerService.GetDoctorAsync(id.Value);

            if (Doctor == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

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

            Doctor.PublicDescription = new HtmlSanitizer().Sanitize(Doctor.PublicDescription);

            await WorkerService.AddOrUpdateDoctorAsync(Doctor);

            return RedirectToPage("./Index");
        }
    }
}
