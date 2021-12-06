using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace DrPet.Web.Pages.DoctorAdmin.Consultings
{
    public class IndexModel : PageModel
    {
        public IConsultingService ConsultingService { get; }
        public IWorkerService WorkerService { get; }
        public IndexModel(IConsultingService consultingService, IWorkerService workerService)
        {
            ConsultingService = consultingService;
            WorkerService = workerService;
        }

        public IList<ConsultingDTO> Consultings { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var success = int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out var userId);

            if (!success)
                return NotFound();

            int id = await WorkerService.GetDoctorIdByAppUserIdAsync(userId);

            if (id == 0)
                return NotFound();

            Consultings = await ConsultingService.GetConsultingsAsync(DateTime.Now, null, id);

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            ConsultingService.DeleteConsulting(id);

            return new JsonResult(new { url = "reload" });
        }
    }
}
