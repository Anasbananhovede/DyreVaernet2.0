using System.Collections.Generic;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DyreVaernet2._0.Pages
{
    public class AdoptDetailsModel : PageModel
    {
        // Vores dyr detaljerne skal vises for
        public Animal SelectedAnimal { get; set; }

        // ID'et vi får
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public void OnGet()
        {
            IAnimalRepository repository = new AnimalRepository();
            List<Animal> allAnimals = repository.GetAll();

            // Finder dyret med det valgte ID
            for (int i = 0; i < allAnimals.Count; i++)
            {
                if (allAnimals[i].Id == Id)
                {
                    SelectedAnimal = allAnimals[i];
                    break;
                }
            }
        }
    }
}
