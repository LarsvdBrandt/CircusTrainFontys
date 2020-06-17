namespace Circustrain
{
    public enum Size
    {
        Small = 1,
        Middle = 3,
        Large = 5
    }

    public enum Sort
    {
        Carnivore = 'c',
        Herbivore = 'h'
    }

    public class Animal
    {
        public Size AnimalSize { get; }
        public Sort Sort { get; }
        public string Name { get; }

        public Animal(Size animalSize, Sort sort, string name)
        {
            AnimalSize = animalSize;
            Sort = sort;
            Name = name;
        }

        public bool IsAnimalCompatable(Animal animalInWagon)
        {
            if (animalInWagon.Sort == Sort.Carnivore && animalInWagon.AnimalSize >= AnimalSize)
            {
                return true;
            }
            else if (Sort == Sort.Carnivore && animalInWagon.AnimalSize <= AnimalSize)
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

/*namespace Circustrain
{
    public class Animal
    {
        public Sizes AnimalSize { get; }
        public Sort Sort { get; }
        public string Name { get; }

        public Animal(Sizes animalSize, Sort sort, string name)
        {
            AnimalSize = animalSize;
            Sort = sort;
            Name = name;
        }

        public bool IsAnimalCompatable(Animal animalInWagon)
        {
            if (animalInWagon.Sort is Sort.Carnivore && animalInWagon.AnimalSize >= AnimalSize)
            {
                return true;
            }
            else if (animalInWagon.Sort is Sort.Carnivore && animalInWagon.AnimalSize <= AnimalSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}*/
