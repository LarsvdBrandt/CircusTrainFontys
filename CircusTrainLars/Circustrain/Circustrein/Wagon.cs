using System.Collections.Generic;

namespace Circustrain
{
    public class Wagon
    {
        //public was private but due the testcases must be made public
        public int Size { get; } = 10;
        public int UsedSize { get; set; } = 0;

        private readonly List<Animal> _animals;
        public IReadOnlyList<Animal> Animals => _animals.AsReadOnly();

        public bool AddAnimalToWagon(Animal animal)
        {
            if (DoesAnimalFit(animal) && IsAnimalCompatableOrNot(animal))
            {
                _animals.Add(animal);
                UsedSize += (int)animal.AnimalSize;
                return true;
            }
            else
                return false;
        }
        //public was private but due the testcases must be made public
        public bool DoesAnimalFit(Animal animal)
        {
            if (UsedSize + (int)animal.AnimalSize <= Size)
                return true;
            else
                return false;
        }

        public Wagon()
        {
            _animals = new List<Animal>();
        }

        //public was private but due the testcases must be made public
        public bool IsAnimalCompatableOrNot(Animal animal)
        {
            bool isCompatible = true;

            foreach (Animal wagonAnimal in Animals)
            {
                if (animal.IsAnimalCompatable(wagonAnimal))
                {
                    isCompatible = false;
                    break;
                }
            }

            return isCompatible;
        }
    }
}