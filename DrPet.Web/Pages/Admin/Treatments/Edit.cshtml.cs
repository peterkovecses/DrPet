using System.Threading.Tasks;
using DrPet.Bll.Interfaces;
using DrPet.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrPet.Web.Pages.Admin.Treatments
{
    public class EditModel : PageModel
    {
        public ITreatmentService TreatmentService { get; }

        public EditModel(ITreatmentService treatmentService)
        {
            TreatmentService = treatmentService;
        }

        [BindProperty]
        public TreatmentDTO Treatment { get; set; }

        public SelectList Medicines { get; set; }
        public SelectList TreatmentTypes { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Medicines = new SelectList(await TreatmentService.GetMedicinesAsync(), "Id", "Name");
            TreatmentTypes = new SelectList(await TreatmentService.GetTreatmentTypesAsync(), "Id", "Name");

            if (id == null)
                return NotFound();

            Treatment = await TreatmentService.GetTreatmentAsync(id.Value);

            if (Treatment == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await TreatmentService.AddOrUpdateTreatmentAsync(Treatment);

            return RedirectToPage("./Index");
        }
    }
}
