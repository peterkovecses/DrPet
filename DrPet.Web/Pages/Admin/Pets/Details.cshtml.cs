using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPet.Web.Pages.Admin.Pets
{
    public class DetailsModel : PageModel
    {
        public IPetService PetService { get; }

        public DetailsModel(IPetService petService)
        {
            PetService = petService;
        }

        [BindProperty]
        public PetDTO Pet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            Pet = await PetService.GetPetAsync(id.Value);

            if (Pet == null)
                return NotFound();

            return Page();
        }
    }
}
