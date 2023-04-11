using Nueva_Veterinaria.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Nueva_Veterinaria.Services
{
    public class ServiciosCRUD
    {
        List<Animal> lstAnimals = new List<Animal>() {
                new Animal()
                {
                    Id = System.Guid.NewGuid().ToString(),
                    Nombre = "Bruno",
                    Especie = "Perro",
                    Edad = "3 Años",
                    Diagnostico = "Tratamiento anti pulgas.",
                    FechaIngreso = new DateTime(2023, 3, 25).ToString("yyyy-MM-dd")
                },
                new Animal()
                {
                    Id = System.Guid.NewGuid().ToString(),
                    Nombre = "Peggy",
                    Especie = "Gato",
                    Edad = "1 Año",
                    Diagnostico = "Profe póngame 10",
                    FechaIngreso = new DateTime(2023, 6, 25).ToString("yyyy-MM-dd")
                },
                new Animal()
                {
                    Id = System.Guid.NewGuid().ToString(),
                    Nombre = "Zolovino",
                    Especie = "Perro",
                    Edad = "2 Años",
                    Diagnostico = "Necesita una vacuna antirrabica.",
                    FechaIngreso = new DateTime(2023, 1, 18).ToString("yyyy-MM-dd")
                },
                new Animal()
                {
                    Id = System.Guid.NewGuid().ToString(),
                    Nombre = "Croco",
                    Especie = "Cocodrilo",
                    Edad = "4 Años",
                    Diagnostico = "El animal no quiere comer.",
                    FechaIngreso = new DateTime(2023, 3, 21).ToString("yyyy-MM-dd")
                },
                new Animal()
                {
                    Id = System.Guid.NewGuid().ToString(),
                    Nombre = "Gorri",
                    Especie = "Pajaro",
                    Edad = "5 Meses",
                    Diagnostico = "Tiene problemas para volar",
                    FechaIngreso = new DateTime(2023, 5, 31).ToString("yyyy-MM-dd")
                },
                new Animal()
                {
                    Id = System.Guid.NewGuid().ToString(),
                    Nombre = "Horsi",
                    Especie = "Caballo",
                    Edad = "3 Años",
                    Diagnostico = "Baño y corte",
                    FechaIngreso = new DateTime(2023, 9, 23).ToString("yyyy-MM-dd")
                }
            };
        public IEnumerable<Animal> GetAllAnimals()
        {        
            return lstAnimals;
        }
        public void AddAnimal(Animal animal)
        {
            animal.Id = System.Guid.NewGuid().ToString();
            animal.FechaIngreso = DateTime.Now.ToString("yyyy-MM-dd");
            lstAnimals.Add(animal);
        }

        //Actualizar animales 
        public void UpdateAnimal(Animal animal)
        {
            lstAnimals.Where(w => w.Id == animal.Id).ToList().ForEach(s => s.Nombre = animal.Nombre);
            lstAnimals.Where(w => w.Id == animal.Id).ToList().ForEach(s => s.Especie = animal.Especie);
            lstAnimals.Where(w => w.Id == animal.Id).ToList().ForEach(s => s.Edad = animal.Edad);
            lstAnimals.Where(w => w.Id == animal.Id).ToList().ForEach(s => s.Diagnostico = animal.Diagnostico);
        }

        //recuperar datos de animales
        public Animal GetAnimalData(string? id)
        {
            Animal animal = new Animal();
            animal = lstAnimals.Where(a => a.Id == id).FirstOrDefault();
            return animal;
        }

        //borrar animal
        public void DeleteAnimal(string? id)
        {
            var animal = lstAnimals.Where(a => a.Id == id).FirstOrDefault();
            lstAnimals.Remove(animal);
        }
    }
}
