using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.Admin.Consultings
{
    public class IndexModel : PageModel
    {
        public IConsultingService ConsultingService { get; }

        public IndexModel(IConsultingService consultingService)
        {
            ConsultingService = consultingService;
        }

        public IList<ConsultingDTO> Consultings { get; set; }

        public async Task OnGetAsync()
        {
            Consultings = await ConsultingService.GetConsultingsAsync(DateTime.Now, null, null, null);
        }

        public IActionResult OnPost(int id)
        {
            ConsultingService.DeleteConsulting(id);

            return new JsonResult(new { url = "reload" });
        }
    }
}
