using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace DrPet.Web.Pages.DoctorAdmin.Consultings
{
    public class CreateModel : PageModel
    {
        public IWorkerService WorkerService { get; }
        public IConsultingService ConsultingService { get; }

        public CreateModel(IWorkerService workerService, IConsultingService consultingService)
        {
            WorkerService = workerService;
            ConsultingService = consultingService;
        }

        [BindProperty]
        public ConsultingDTO Consulting { get; set; }

        public int DoctorId { get; set; }

        public async Task OnGetAsync()
        {
            var success = int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out var userId);
            
            if (success)
                DoctorId = await WorkerService.GetDoctorIdByAppUserIdAsync(userId);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            if (Consulting.WorkerId == 0)
                return NotFound();

            await ConsultingService.AddOrUpdateConsultingAsync(Consulting);

            return RedirectToPage("./Index");
        }
    }
}
