using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrain
{ 
    public class Animal
    {
        // Propertie
        public int Size { get; }
        public string Food { get; }
        public string Name { get;  }

        // Methods
        public Animal(int size, string food, string name)
        {
            Size = size;
            Food = food;
            Name = name;
        }

        public bool IsAnimalCompatable(Animal wagonAnimal)
        {
            if (wagonAnimal.Food == "Carnivore" && wagonAnimal.Size >= Size || Food == "Carnivore" && wagonAnimal.Size <= Size)
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
