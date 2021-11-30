using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DrPet.Data.Entities;
using Microsoft.AspNetCore.Identity;

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

        public int Id { get; set; }

        public async Task OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            Id = await WorkerService.GetDoctorIdByAppUserIdAsync(user.Id);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await ConsultingService.AddOrUpdateConsultingAsync(Consulting);

            return RedirectToPage("./Index");
        }
    }
}
