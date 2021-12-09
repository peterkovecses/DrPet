using DrPet.Bll.DTOs;
using DrPet.Bll.Interfaces;
using DrPet.Web.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DrPet.Web.ViewComponents
{
    public class ConsultingsViewComponent : ViewComponent
    {
        public IConsultingService ConsultingService { get; }
        public ConsultingsViewComponent(IConsultingService consultingService)
        {
            ConsultingService = consultingService;
        }

        public class DisplayConsultings
        {
            public DateTime ActualDate { get; set; } = DateTime.Now;
            public string? ActualMonth { get; set; }
            public IList<ConsultingDTO> Consultings { get; set; }
            public DisplayType DisplayType { get; set; }
        }

        public async Task<IViewComponentResult> InvokeAsync(DisplayType displayType, DateTime? from, DateTime? till, DateTime? date, int? doctorId, int? piece)
        {
            var displayConsultings = new DisplayConsultings { DisplayType = displayType };

            if (displayType == DisplayType.ActualWeak)
                displayConsultings.Consultings = await ConsultingService.GetActualWeekConsultingsAsync(null, null);

            else if (displayType == DisplayType.Monthly)
            {
                if (date != null)
                    displayConsultings.ActualDate = (DateTime)date;

                displayConsultings.Consultings = await ConsultingService.GetMonthlyConsultingsAsync(displayConsultings.ActualDate, null, null);

                if (displayConsultings.Consultings.Any())
                    displayConsultings.ActualMonth = displayConsultings.Consultings[0].StartOfConsulting.ToString("MMMM");

                else
                    displayConsultings.ActualMonth = "";
            }

            else if (displayType == DisplayType.Doctor)
                displayConsultings.Consultings = await ConsultingService.GetConsultingsAsync(DateTime.Now, null, doctorId, null);

            return View(displayConsultings);
        }
    }
}
