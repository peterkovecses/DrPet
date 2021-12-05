using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DrPet.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace DrPet.Web.Pages.DoctorAdmin.Consultings
{
    public class CreateModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        public IWorkerService WorkerService { get; }
        public IConsultingService ConsultingService { get; }

        public CreateModel(UserManager<AppUser> userManager, IWorkerService workerService, IConsultingService consultingService)
        {
            _userManager = userManager;
            WorkerService = workerService;
            ConsultingService = consultingService;
        }

        [BindProperty]
        public ConsultingDTO Consulting { get; set; }

        public int DoctorId { get; set; }

        public async Task OnGetAsync()
        {
            // var success = int.TryParse(_userManager.GetUserId(User), out var userId);

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
