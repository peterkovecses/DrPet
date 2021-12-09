using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPet.Web.Pages
{
    public class ConsultingsModel : PageModel
    {     
        public DateTime ActualDate { get; set; } = DateTime.Now;

        public void OnGet(DateTime? date)
        {            
            if (date != null)
                ActualDate = (DateTime)date;            
        }
    }
}
