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
        public IConsultingService ConsultingService { get; }

        public DoctorsConsultingsModel(IConsultingService consultingService) => ConsultingService = consultingService;        

        public IEnumerable<Consulting> Consultings { get; private set; }

        public async Task OnGetAsync(int id)
        {            
            Consultings = await ConsultingService.GetConsultingsAsync(DateTime.Now, DateTime.Now.AddMonths(1), id);
        }
    }
}
