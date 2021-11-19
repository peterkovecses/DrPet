using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPet.Web.Pages.Admin.Pets
{
    public class CreateModel : PageModel
    {
        public IPetService PetService { get; }
        public IOwnerService OwnerService { get; }

        public CreateModel(IPetService petService, IOwnerService ownerService)
        {
            PetService = petService;
            OwnerService = ownerService;
        }

        [BindProperty]
        public PetDTO Pet { get; set; }

        public SelectList Varieties { get; set; }
        public SelectList Owners { get; set; }


        public async Task OnGetAsync()
        {
            Varieties = new SelectList(await PetService.GetVarietiesAsync(), "Id", "Name");
            Owners = new SelectList(await OwnerService.GetOwnersAsync(), "Id", "Name");
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
