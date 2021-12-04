using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using DrPet.Data.Entities;
using System.Security.Claims;

namespace DrPet.Web.Pages.DoctorAdmin.Consultings
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        public IConsultingService ConsultingService { get; }
        public IWorkerService WorkerService { get; }
        public IndexModel(IConsultingService consultingService, UserManager<AppUser> userManager, IWorkerService workerService)
        {
            ConsultingService = consultingService;
            _userManager = userManager;
            WorkerService = workerService;
        }

        public IList<ConsultingDTO> Consultings { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var success = int.TryParse(_userManager.GetUserId(User), out var userId);

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
