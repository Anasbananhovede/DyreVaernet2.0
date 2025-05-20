namespace DyreVaernet2._0.Model
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
  
        public Animal()
        {
            AnimalID = 0;
            Name = "default name";
            Description = "default description";
            
           

        }
        public Animal(int animalID, string name, string description)
        {
            AnimalID = animalID;
            Name = name;
            Description = description;
            
            
            
        }
    }
}
