using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPet.Web.Pages.Admin.Consultings
{
    public class EditModel : PageModel
    {
        public IConsultingService ConsultingService { get; }
        public IWorkerService WorkerService { get; }

        public EditModel(IConsultingService consultingService, IWorkerService workerService)
        {
            ConsultingService = consultingService;
            WorkerService = workerService;
        }

        [BindProperty]
        public ConsultingDTO Consulting { get; set; }

        public SelectList Doctors { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            Consulting = await ConsultingService.GetConsultingAsync(id.Value);

            if (Consulting == null)
                return NotFound();

            Doctors = new SelectList(await WorkerService.GetDoctorsAsync(), "Id", "Name");

            return Page();
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
