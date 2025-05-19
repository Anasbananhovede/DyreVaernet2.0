using System.Collections.Generic;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DyreVaernet2._0.Pages
{
    // PageModel til Adopt-siden
    public class AdoptModel : PageModel
    {
        // Liste over dyr
        public List<Animal> Animals { get; set; }

        public void OnGet()
        {
            // Opretter repository og henter dyrene fra JSON-filen
            IAnimalRepository repository = new AnimalRepository();
            Animals = repository.GetAll();
        }
    }
}
  