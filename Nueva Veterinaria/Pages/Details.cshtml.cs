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
    public class DetailsModel : PageModel
    {
        private readonly ServiciosCRUD _serviciosCRUD;

        public DetailsModel(ServiciosCRUD serviciosCRUD)
        {
            _serviciosCRUD = serviciosCRUD;
        }

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
    }
}
    

