using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.Admin.Owners
{
    public class DetailsModel : PageModel
    {
        public IOwnerService OwnerService { get; }

        public DetailsModel(IOwnerService ownerService)
        {
            OwnerService = ownerService;
        }

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
    }
}
