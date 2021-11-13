using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;

namespace DrPet.Web.Pages
{
    public class IndexModel : PageModel
    {
        public IWorkerService WorkerService { get; }
        public IConsultingService ConsultingService { get; }
        public IndexModel(IWorkerService workerService, IConsultingService consultingService)
        {
            WorkerService = workerService;
            ConsultingService = consultingService;
        }        

        public IEnumerable<Doctor> Doctors { get; private set; }
        public IEnumerable<Consulting> Consultings { get; private set; }

        public async Task OnGetAsync()
        {
            Doctors = await WorkerService.GetDoctorsAsync();
            Consultings = await ConsultingService.GetMonthlyConsultingsAsync(null);
            Consultings = Consultings.Take(10);
        }
    }
}
