using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPet.Web.Pages.Admin.Consultings
{
    public class CreateModel : PageModel
    {
        public IConsultingService ConsultingService { get; }
        public IWorkerService WorkerService { get; }

        public CreateModel(IConsultingService consultingService, IWorkerService workerService)
        {
            ConsultingService = consultingService;
            WorkerService = workerService;
        }

        [BindProperty]
        public ConsultingDTO Consulting { get; set; }

        public SelectList Doctors { get; set; }

        public async Task OnGetAsync()
        {
            Doctors = new SelectList(await WorkerService.GetDoctorsAsync(), "Id", "Name");                
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
