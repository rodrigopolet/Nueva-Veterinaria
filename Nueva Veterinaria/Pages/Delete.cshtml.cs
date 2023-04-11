using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nueva_Veterinaria.Models;
using Nueva_Veterinaria.Services;

namespace Nueva_Veterinaria.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly ServiciosCRUD _serviciosCRUD;
        public DeleteModel(ServiciosCRUD serviciosCRUD)
        {
            _serviciosCRUD = serviciosCRUD;
        }
        [BindProperty]
        public Animal animal { get; set; }

        public ActionResult OnGet(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            animal = _serviciosCRUD.GetAnimalData(id);

            if (animal == null)
            {
                return NotFound();
            }
            return Page();
        }

        public ActionResult OnPost()
        {
            _serviciosCRUD.DeleteAnimal(animal.Id);

            return RedirectToPage("./Index");
        }
    }
}
