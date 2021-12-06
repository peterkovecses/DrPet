using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using DrPet.Bll.Interfaces;
using System.Security.Claims;

namespace DrPet.Web.Pages.DoctorAdmin
{
    public class IndexModel : PageModel
    {
        public IWorkerService WorkerService { get; }
        public IndexModel(IWorkerService workerService)
        {
            WorkerService = workerService;
        }

        public string Name { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var success = int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out var userId);

            if (!success)
                return NotFound();

            var doctor = await WorkerService.GetDoctorByAppUserIdAsync(userId);

            if (doctor == null)
                return NotFound();

            Name = doctor.Name;

            return Page();
        }
    }
}
