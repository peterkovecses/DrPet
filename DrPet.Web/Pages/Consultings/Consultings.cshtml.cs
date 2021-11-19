using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;

namespace DrPet.Web.Pages
{
    public class ConsultingsModel : PageModel
    {
        public IConsultingService ConsultingService { get; }

        public ConsultingsModel(IConsultingService consultingService) => ConsultingService = consultingService;        

        public DateTime ActualDate { get; set; } = DateTime.Now;

        public string ActualMonth { get; set; }

        public IList<ConsultingDTO> Consultings { get; private set; }

        public async Task OnGetAsync(string? date)
        {
            Consultings = await ConsultingService.GetMonthlyConsultingsAsync(date);
            
            if (date != null && DateTime.TryParse(date, out var actualDate))
                ActualDate = actualDate;

            if (Consultings.Any())
                ActualMonth = Consultings[0].StartOfConsulting.ToString("MMMM");

            else
                ActualMonth = "";
        }
    }
}
