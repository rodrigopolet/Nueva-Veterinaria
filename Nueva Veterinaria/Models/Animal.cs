using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nueva_Veterinaria.Models
{
    public class Animal
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio.")]
        public string Especie { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio.")]
        public string Edad { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio.")]
        public string Diagnostico { get; set; }
        public string FechaIngreso { get; set; }
    }
}
