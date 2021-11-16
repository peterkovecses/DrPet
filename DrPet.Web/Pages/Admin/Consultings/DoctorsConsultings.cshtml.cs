using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.Admin.Consultings
{
    public class DetailsModel : PageModel
    {
        public IConsultingService ConsultingService { get; }

        public DetailsModel(IConsultingService consultingService)
        {
            ConsultingService = consultingService;
        }

        public IList<Consulting> Consultings { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
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
