using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPet.Web.Pages.Admin.Pets
{
    public class CreateModel : PageModel
    {
        public IPetService PetService { get; }

        public CreateModel(IPetService petService, IOwnerService ownerService)
        {
            PetService = petService;
        }

        [BindProperty]
        public Pet Pet { get; set; }

        public SelectList Varieties { get; set; }


        public async Task OnGetAsync()
        {
            Varieties = new SelectList(await PetService.GetVarietiesAsync(), "Id", "Name");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await PetService.AddOrUpdatePetAsync(Pet);

            return RedirectToPage("./Index");
        }
    }
}
