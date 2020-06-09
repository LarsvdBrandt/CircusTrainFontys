using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrain
{ 
    public class Animal
    {
        public int Size { get; }
        public string Sort { get; }
        public string Name { get;  }

        public Animal(int size, string sort, string name)
        {
            Size = size;
            Sort = sort;
            Name = name;
        }

        public bool IsAnimalCompatable(Animal wagonAnimal)
        {
            if (wagonAnimal.Sort == "Carnivore" && wagonAnimal.Size >= Size)
            {
                return true;
            }

            if (Sort == "Carnivore" && wagonAnimal.Size <= Size)
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
