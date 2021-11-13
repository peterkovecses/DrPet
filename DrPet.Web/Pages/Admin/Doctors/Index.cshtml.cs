using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.Admin.Doctors
{
    public class IndexModel : PageModel
    {
        public IWorkerService WorkerService { get; }

        public IndexModel(IWorkerService workerService)
        {
            WorkerService = workerService;
        }

        public IList<Doctor> Doctors { get; set; }

        public IActionResult OnPost(int id)
        {
            WorkerService.DeleteWorker(id);

            return new JsonResult(new { url = "reload" });
        }

        public async Task OnGetAsync()
        {
            Doctors = await WorkerService.GetDoctorsAsync();
        }        
    }
}
