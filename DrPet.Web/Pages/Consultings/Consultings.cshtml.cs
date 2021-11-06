using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;

namespace DrPet.Web.Pages
{
    public class ConsultingsModel : PageModel
    {
        public ConsultingsModel(IConsultingService consultingService) => ConsultingService = consultingService;

        public IConsultingService ConsultingService { get; }

        public DateTime ActualMonth { get; set; } = DateTime.Now;

        public IEnumerable<Consulting> Consultings { get; private set; }

        public async Task OnGet(string? date)
        {
            Consultings = await ConsultingService.GetMonthlyConsultingsAsync(date);
            if (date != null)
                if (DateTime.TryParse(date, out var actualDate))
                    ActualMonth = actualDate;
        }
    }
}
