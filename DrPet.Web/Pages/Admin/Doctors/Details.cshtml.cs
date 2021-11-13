using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.Admin.Doctors
{
    public class DetailsModel : PageModel
    {
        public IWorkerService WorkerService { get; }

        public DetailsModel(IWorkerService workerService)
        {
            WorkerService = workerService;
        }

        public Doctor Doctor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            Doctor = await WorkerService.GetDoctorAsync(id.Value);

            if (Doctor == null)
                return NotFound();

            return Page();
        }
    }
}
