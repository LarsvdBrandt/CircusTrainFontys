using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
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
    }
}
