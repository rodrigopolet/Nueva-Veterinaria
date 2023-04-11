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
    public class CreateModel : PageModel
    {
        private readonly ServiciosCRUD _serviciosCRUD;

        public CreateModel(ServiciosCRUD serviciosCRUD)
        {
            _serviciosCRUD = serviciosCRUD;
        }
        [BindProperty]
        public Animal animal { get; set; }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _serviciosCRUD.AddAnimal(animal);

            return RedirectToPage("./Index");
        }
    }
}
