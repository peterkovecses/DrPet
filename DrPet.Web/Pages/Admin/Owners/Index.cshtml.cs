using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.Admin.Owners
{
    public class IndexModel : PageModel
    {
        public IOwnerService OwnerService { get; }

        public IndexModel(IOwnerService ownerService)
        {
            OwnerService = ownerService;
        }

        public IList<OwnerDTO> Owners { get; set; }

        public async Task OnGetAsync()
        {
            Owners = await OwnerService.GetOwnersAsync();
        }

        public IActionResult OnPost(int id)
        {
            OwnerService.DeleteOwner(id);

            return new JsonResult(new { url = "reload" });
        }
    }
}
