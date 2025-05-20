using DyreVaernet2._0.Model;

namespace DyreVaernet2._0.IRepo
{
    public class AnimalRepo : IAnimalRepo
    {
        List<Animal> _animals = new List<Animal>();
        public AnimalRepo() // int roomID, string name, string description, int capacity, List<string> equipment
        {
            _animals.Add(new Animal(101, "martin", "description 1"));
            _animals.Add(new Animal(102, "Bruno", "description 2"));
            _animals.Add(new Animal(103, "sofus", "description 3"));
            _animals.Add(new Animal(104, "selma", "description 4"));
            _animals.Add(new Animal(105, "enola", "description 5"));
            _animals.Add(new Animal(106, "fister", "description 6"));
            _animals.Add(new Animal(107, "Gurt", "description 7"));
            _animals.Add(new Animal(108, "rexsil", "description 8"));
        }
        public List<Animal> GetAll()
        {
            return _animals;
        }

        public Animal GetByID(int id)
        {
            foreach (Animal animal in _animals)
            {
                if (animal.AnimalID == id)
                {
                    return animal;
                }
            }
            return null;
        }

        public Domain.Models.Animal GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<Domain.Models.Animal> IAnimalRepo.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
