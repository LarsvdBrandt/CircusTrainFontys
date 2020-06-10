using System.Collections.Generic;

namespace Circustrain
{
    public class Wagon
    {
        private int Size { get; } = 10;
        public int UsedSize { get; set; } = 0;

        private readonly List<Animal> _animals;
        public IReadOnlyList<Animal> Animals => _animals.AsReadOnly();

        public bool AddAnimalToWagon(Animal animal)
        {
            if (DoesAnimalFit(animal) && IsAnimalNotCompatable(animal))
            {
                _animals.Add(animal);
                UsedSize += (int)animal.AnimalSize;
                return true;
            }
            else
                return false;
        }
        private bool DoesAnimalFit(Animal animal)
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

        private bool IsAnimalNotCompatable(Animal animal)
        {
            bool compatible = true;

            foreach (Animal wagonAnimal in Animals)
            {
                if (animal.IsAnimalCompatable(wagonAnimal))
                {
                    compatible = false;
                    break;
                }
            }

            return compatible;
        }
    }
}