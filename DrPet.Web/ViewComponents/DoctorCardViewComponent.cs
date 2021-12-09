using DrPet.Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DrPet.Web.ViewComponents
{
    public class DoctorCardViewComponent : ViewComponent
    {
        public IWorkerService WorkerService { get; }
        public DoctorCardViewComponent(IWorkerService workerService)
        {
            WorkerService = workerService;
        }

        public class DoctorCard
        {
            public int DoctorId { get; set; }
            public string DoctorName { get; set; }
            public string PhotoName { get; set; }
            public string PublicDescription { get; set; }
        }

        public IViewComponentResult Invoke(int doctorId, string doctorName, string photoName, string publicDescription)
        {
            var doctorCard = new DoctorCard
            {
                DoctorId = doctorId,
                DoctorName = doctorName,
                PhotoName = photoName,
                PublicDescription = publicDescription
            };

            return View(doctorCard);
        }

    }
}
