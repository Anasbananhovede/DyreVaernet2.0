using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Domain.Interfaces;
using Domain.Models;

namespace Infrastructure.Repositories
{
    // Repository der læser dyredata fra en json-fil
    public class AnimalRepository : IAnimalRepository
    {
        // sti til json-filen med dyrene
        private string _path = Path.Combine(AppContext.BaseDirectory, "Infrastructure", "Data", "animals.json");

        // Metode til at hente alle dyr
        public List<Animal> GetAll()
        {
            if (File.Exists(_path))
            {
                string json = File.ReadAllText(_path);
                List<Animal> animals = JsonSerializer.Deserialize<List<Animal>>(json);
                return animals;
            }
            else
            {
                // Hvis filen ikke findes, returneres en tom liste
                return new List<Animal>();
            }
        }
    }
}
