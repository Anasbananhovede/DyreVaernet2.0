using Domain.Models;

namespace DyreVaernet2._0.IRepo
{
    public interface IAnimalRepo
    {
        public List<Animal> GetAll();
        public Animal GetByID(int id);
    }
}
