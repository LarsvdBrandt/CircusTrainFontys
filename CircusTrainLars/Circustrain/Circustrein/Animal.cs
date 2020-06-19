namespace Circustrain
{
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