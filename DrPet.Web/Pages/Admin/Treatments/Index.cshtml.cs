using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.Admin.Treatments
{
    public class IndexModel : PageModel
    {
        public ITreatmentService TreatmentService { get; }

        public IndexModel(ITreatmentService treatmentService)
        {
            TreatmentService = treatmentService;
        }

        public IList<Treatment> Treatments { get; set; }        

        public async Task OnGetAsync()
        {
            Treatments = await TreatmentService.GetTreatmentsAsync();
        }

        public IActionResult OnPost(int id)
        {
            TreatmentService.DeleteTreatment(id);

            return new JsonResult(new { url = "reload" });
        }
    }
}
