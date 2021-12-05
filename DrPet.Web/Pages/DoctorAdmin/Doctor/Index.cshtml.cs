using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using DrPet.Data.Entities;
using System.Security.Claims;

namespace DrPet.Web.Pages.DoctorAdmin.Doctor
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        public IWorkerService WorkerService { get; }

        public IndexModel(UserManager<AppUser> userManager, IWorkerService workerService)
        {
            _userManager = userManager;
            WorkerService = workerService;
        }

        public DoctorDTO Doctor { get; set; }


        public async Task<IActionResult> OnGetAsync()
        {
            var success = int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out var userId);

            if (!success)
                return NotFound();

            var id = await WorkerService.GetDoctorIdByAppUserIdAsync(userId);

            if (id == 0)
                return NotFound();

            Doctor = await WorkerService.GetDoctorAsync(id);

            if (Doctor == null)
                return NotFound();

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            WorkerService.DeleteWorker(id);

            return new JsonResult(new { url = "reload" });
        }
    }
}