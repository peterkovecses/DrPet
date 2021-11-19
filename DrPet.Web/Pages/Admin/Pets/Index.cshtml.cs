using System.Collections.Generic;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.Admin.Pets
{
    public class IndexModel : PageModel
    {
        public IPetService PetService { get; }

        public IndexModel(IPetService petService)
        {
            PetService = petService;
        }

        public IList<PetDTO> Pets { get; set; }

        public async Task OnGetAsync()
        {
            Pets = await PetService.GetPetsAsync();
        }

        public IActionResult OnPost(int id)
        {
            PetService.DeletePet(id);

            return new JsonResult(new { url = "reload" });
        }
    }
}
