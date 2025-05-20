using Domain.Models;
using DyreVaernet2._0.Model;
using DyreVaernet2._0.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DyreVaernet2._0.Pages
{
    public class BookingModel : PageModel
    {

        private readonly ILogger<BookingModel> _logger;



        public BookingModel(ILogger<BookingModel> logger, AnimalService animalService)
        {
            _logger = logger;
        }


        public void OnGet()
        {
        }

        [BindProperty]
        public string FilterChoice { get; set; } // Holds the selected filter choice from the user

        public void OnPost()
        {
            

          
        }
    }
}
