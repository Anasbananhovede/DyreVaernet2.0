using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain.Models;
using Infrastructure.Repositories;

namespace DyreVaernet2._0.Pages
{
    public class BookVisitModel : PageModel
    {
        // Modtager af dyrets id
        [BindProperty(SupportsGet = true)]
        public int AnimalId { get; set; }

        // Brugeren indtasterer sine oplysninger 
        [BindProperty]
        public string VisitorName { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public DateTime VisitDate { get; set; }

        // Navnet på dyret der ses øverst på siden 
        public string AnimalName { get; set; }

        // Dette vises som en bekræftelse efter booking
        public bool Success { get; set; } = false;

        // Når siden først åbnes via get metoden
        public void OnGet()
        {
            // Finder dyrets navn baseret på det valgte ID
            AnimalRepository repo = new AnimalRepository();
            List<Animal> animals = repo.GetAll();

            // Vi gennemgår listen af dyr og finder det rigtige
            foreach (Animal animal in animals)
            {
                if (animal.Id == AnimalId)
                {
                    AnimalName = animal.Name;
                    break;
                }
            }
        }

        // kører når vores bruger trykker på book et besøg med Post metode
        public void OnPost()
        {
            // oprettelse af ny booking med brugerens data
            Booking booking = new Booking
            {
                AnimalId = AnimalId,
                VisitorName = VisitorName,
                Email = Email,
                VisitDate = VisitDate
            };

            // Gemmer vores booking i vores repository
            BookingRepository bookingRepo = new BookingRepository();
            bookingRepo.Add(booking);

            // Bekræftelse af at bookingen er gennemført
            Success = true;
        }
    }
}

