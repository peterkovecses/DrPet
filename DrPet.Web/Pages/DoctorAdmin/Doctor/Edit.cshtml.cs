using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.DoctorAdmin.Doctor
{
    public class EditModel : PageModel
    {
        public IWorkerService WorkerService { get; }

        public EditModel(IWorkerService workerService)
        {
            WorkerService = workerService;
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

            await WorkerService.AddOrUpdateDoctorAsync(Doctor);

            return RedirectToPage("./Index");
        }
    }
}
