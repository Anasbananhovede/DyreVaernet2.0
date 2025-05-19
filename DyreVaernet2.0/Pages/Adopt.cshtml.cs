using System.Collections.Generic;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DyreVaernet2._0.Pages
{

    public class AdoptModel : PageModel
    {
        // Liste over vores dy der skal ses/vises
        public List<Animal> Animals { get; set; }

        // arten gemmes n�r brugeren v�lger i dropdown menuen 
        [BindProperty(SupportsGet = true)]
        public string Species { get; set; }

        public void OnGet()
        {
            // Opretter repository og henter dyrene fra JSON-filen
            IAnimalRepository repository = new AnimalRepository();
            List<Animal> allAnimals = repository.GetAll();

            // Hvis der er valgt en art, filtreres dyrene
            if (!string.IsNullOrEmpty(Species))
            {
                // Der oprettes en tom liste til at kunne filtere dyrene 
                Animals = new List<Animal>();

                // Vi opretter/ g�re brug af for l�kke for at kunne filtrer 
                for (int i = 0; i < allAnimals.Count; i++)
                {
                    if (allAnimals[i].Species == Species)
                    {
                        // Hvis dyret er af den valgte art, tilf�jes det til listen
                        Animals.Add(allAnimals[i]);
                    }
                }
            }
            else
            {
                // Hvis der ikke er valgt nogen art, vises alle dyr
                Animals = allAnimals;
            }
        }
    }
}