using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPet.Web.Pages.Admin.Treatments
{
    public class DetailsModel : PageModel
    {
        public ITreatmentService TreatmentService { get; }

        public DetailsModel(ITreatmentService treatmentService)
        {
            TreatmentService = treatmentService;
        }

        [BindProperty]
        public Treatment Treatment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            Treatment = await TreatmentService.GetTreatmentAsync(id.Value);

            if (Treatment == null)
                return NotFound();

            return Page();
        }
    }
}
