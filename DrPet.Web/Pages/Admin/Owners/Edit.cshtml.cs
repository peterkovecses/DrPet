using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.Admin.Owners
{
    public class EditModel : PageModel
    {
        public IOwnerService OwnerService { get; }

        public EditModel(IOwnerService ownerService)
        {
            OwnerService = ownerService;
        }        

        [BindProperty]
        public Owner Owner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            Owner = await OwnerService.GetOwnerAsync(id.Value);

            if (Owner == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await OwnerService.AddOrUpdateOwnerAsync(Owner);

            return RedirectToPage("./Index");
        }
    }
}
