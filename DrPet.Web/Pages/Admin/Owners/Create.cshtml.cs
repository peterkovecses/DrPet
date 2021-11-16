using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.Admin.Owners
{
    public class CreateModel : PageModel
    {
        public IOwnerService OwnerService { get; }

        public CreateModel(IOwnerService ownerService)
        {
            OwnerService = ownerService;
        }

        [BindProperty]
        public Owner Owner { get; set; }

        public void OnGet()
        {

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
