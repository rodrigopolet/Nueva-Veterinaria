using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Nueva_Veterinaria.Models;
using Nueva_Veterinaria.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nueva_Veterinaria.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ServiciosCRUD _serviciosCRUD;

        public IndexModel(ILogger<IndexModel> logger, ServiciosCRUD serviciosCRUD)
        {
            _logger = logger;
            _serviciosCRUD = serviciosCRUD;
        }

        public List<Animal> Animals { get; set; }

        public void OnGet()
        {
            Animals = _serviciosCRUD.GetAllAnimals().ToList();
        }
    }
}
