namespace Circustrain
{
    public class Animal
    {
        public int AnimalSize { get; }
        public string Sort { get; }
        public string Name { get;  }

        public Animal(int animalSize, string sort, string name)
        {
            AnimalSize = animalSize;
            Sort = sort;
            Name = name;
        }

        public bool IsAnimalCompatable(Animal animalInWagon)
        {
            if (animalInWagon.Sort == "Carnivore" && animalInWagon.AnimalSize >= AnimalSize)
            {
                return true;
            }
            else if (Sort == "Carnivore" && animalInWagon.AnimalSize <= AnimalSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}