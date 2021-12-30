using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;

namespace DrPet.Web.Pages
{
    public class IndexModel : PageModel
    {
        public IWorkerService WorkerService { get; }
        public IndexModel(IWorkerService workerService)
        {
            WorkerService = workerService;          
        }        

        public IEnumerable<DoctorDTO> Doctors { get; private set; }

        public async Task OnGetAsync()
        {
            var doctors = await WorkerService.GetDoctorsAsync();
            Doctors = doctors.OrderBy(d => d.Id).Take(4);
        }
    }
}
