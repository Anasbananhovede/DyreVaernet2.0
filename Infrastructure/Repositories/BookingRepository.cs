using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Domain.Models;
using Domain.Interfaces;

namespace Infrastructure.Repositories
{
    // Repository der håndterer bookingerne via JSON-fil
    public class BookingRepository : IBookingRepository
    {
        // Sti til JSON-filen
        private string _filePath = Path.Combine(AppContext.BaseDirectory, "Data", "bookings.json");

        // Henter alle bookinger fra systemet
        public List<Booking> GetAll()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                return JsonSerializer.Deserialize<List<Booking>>(json);
            }

            // Hvis filen ikke findes, returnér en tom liste
            return new List<Booking>();
        }

        // Tilføjer en ny booking og gemmer den i filen
        public void Add(Booking booking)
        {
            List<Booking> bookings = GetAll();

            // Generer nyt ID
            booking.Id = bookings.Count + 1;
            bookings.Add(booking);

            // Gemmer listen tilbage i filen
            string updatedJson = JsonSerializer.Serialize(bookings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, updatedJson);
        }
    }
}
