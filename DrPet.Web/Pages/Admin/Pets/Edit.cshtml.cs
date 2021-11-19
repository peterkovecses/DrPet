using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPet.Web.Pages.Admin.Pets
{
    public class EditModel : PageModel
    {
        public IPetService PetService { get; }
        public IOwnerService OwnerService { get; }

        public EditModel(IPetService petService, IOwnerService ownerService)
        {
            PetService = petService;
            OwnerService = ownerService;
        }

        [BindProperty]
        public PetDTO Pet { get; set; }

        public SelectList Varieties { get; set; }
        public SelectList Owners { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Varieties = new SelectList(await PetService.GetVarietiesAsync(), "Id", "Name");
            Owners = new SelectList(await OwnerService.GetOwnersAsync(), "Id", "Name");

            if (id == null)
                return NotFound();

            Pet = await PetService.GetPetAsync(id.Value);

            Pet.PrevOwnerId = Pet.OwnerId;

            if (Pet == null)
                return NotFound();            

            return Page();
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
