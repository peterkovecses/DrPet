using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages.Consultings
{
    public class DoctorsConsultingsModel : PageModel
    {
        //public IConsultingService ConsultingService { get; }

        //public DoctorsConsultingsModel(IConsultingService consultingService) => ConsultingService = consultingService;

        public int DoctorId { get; set; }

        //public IEnumerable<ConsultingDTO> Consultings { get; private set; }

        public void OnGet(int id)
        {
            //Consultings = await ConsultingService.GetConsultingsAsync(DateTime.Now, DateTime.Now.AddMonths(1), id, null);
            DoctorId = id;
        }
    }
}
