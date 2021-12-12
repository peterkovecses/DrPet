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
        public IWorkerService WorkerService { get; }

        public IndexModel(IWorkerService workerService)
        {
            WorkerService = workerService;
        }

        public DoctorDTO Doctor { get; set; }


        public async Task<IActionResult> OnGetAsync()
        {
            var success = int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out var userId);

            if (!success)
                return NotFound();

            Doctor = await WorkerService.GetDoctorByAppUserIdAsync(userId);

            if (Doctor == null)
                return NotFound();

            return Page();
        }
    }
}
