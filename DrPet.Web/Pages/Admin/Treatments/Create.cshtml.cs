using System;
using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPet.Web.Pages.Admin.Treatments
{
    public class CreateModel : PageModel
    {
        public ITreatmentService TreatmentService { get; }
        public IConsultingService ConsultingService { get; }
        public IPetService PetService { get; }
        public IWorkerService WorkerService { get; }

        public CreateModel(ITreatmentService treatmentService, IConsultingService consultingService, IPetService petService, IWorkerService workerService)
        {
            TreatmentService = treatmentService;
            ConsultingService = consultingService;
            PetService = petService;
            WorkerService = workerService;
        }

        [BindProperty]
        public TreatmentDTO Treatment { get; set; }

        public SelectList Medicines { get; set; }
        public SelectList TreatmentTypes { get; set; }
        public SelectList Pets { get; set; }
        public SelectList Doctors { get; set; }

        public async Task OnGetAsync()
        {
            Medicines = new SelectList(await TreatmentService.GetMedicinesAsync(), "Id", "Name");
            TreatmentTypes = new SelectList(await TreatmentService.GetTreatmentTypesAsync(), "Id", "Name");
            Pets = new SelectList(await PetService.GetPetsAsync(), "Id", "Name");
            Doctors = new SelectList(await WorkerService.GetDoctorsAsync(), "Id", "Name");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            Treatment.Date = DateTime.Now;

            var consulting = await ConsultingService.GetConsultingAsync(Treatment.Date, Treatment.WorkerId);

            // if the treatment in consulting time
            if (consulting != null)
                Treatment.ConsultingId = consulting.Id;

            // if not in consulting time (make a new consulting for only this treatment)
            else
            {
                consulting = new ConsultingDTO { StartOfConsulting = Treatment.Date, EndOfConsulting = Treatment.Date, WorkerId = Treatment.WorkerId };
                await ConsultingService.AddOrUpdateConsultingAsync(consulting);

                consulting = await ConsultingService.GetConsultingAsync(Treatment.Date, Treatment.WorkerId);
                Treatment.ConsultingId = consulting.Id;
            }

            // get the pet owner's id
            Treatment.OwnerId = await PetService.GetOwnerId(Treatment.PetId);

            var purchase = new PurchaseDTO { Date = Treatment.Date, OwnerId = Treatment.OwnerId, PetId = Treatment.PetId };

            await TreatmentService.AddOrUpdateTreatmentAsync(Treatment, purchase);

            return RedirectToPage("./Index");
        }
    }
}
