using Domain.Models;
using DyreVaernet2._0.IRepo;

namespace DyreVaernet2._0.Service
{
    public class AnimalService
    {

        private IAnimalRepo _animalRepo;

        public AnimalService(IAnimalRepo animalRepo)
        {
            _animalRepo = animalRepo;
        }

        public List<Animal> GetAll()
        {
            return _animalRepo.GetAll();
        }

        public Animal GetByID(int id)
        {
            return _animalRepo.GetByID(id);
        }
    }
}
