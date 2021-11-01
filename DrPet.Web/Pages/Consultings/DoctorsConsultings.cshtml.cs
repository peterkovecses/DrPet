using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;

namespace DrPet.Web.Pages.Consultings
{
    public class DoctorsConsultingsModel : PageModel
    {
        public DoctorsConsultingsModel(IConsultingService consultingService) => ConsultingService = consultingService;

        public IConsultingService ConsultingService { get; }

        public IEnumerable<Consulting> Consultings { get; private set; }

        public async Task OnGet(string id)
        {
            int parsedId = -1;
            int.TryParse(id, out parsedId);
            Consultings = await ConsultingService.GetConsultingsAsync(DateTime.Now, DateTime.Now.AddMonths(1), parsedId);
        }
    }
}
