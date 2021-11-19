using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
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

        public IList<DoctorDTO> Doctors { get; set; }

        public async Task OnGetAsync()
        {
            Doctors = await WorkerService.GetDoctorsAsync();
        }

        public IActionResult OnPost(int id)
        {
            WorkerService.DeleteWorker(id);

            return new JsonResult(new { url = "reload" });
        }      
    }
}
