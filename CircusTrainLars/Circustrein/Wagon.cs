using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Wagon
    {
        // Propertie
        public int Size { get; } = 10;
        public int UsedSize { get; set; }
        public List<Animal> Animals { get; set; }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            UsedSize += animal.Size;
        }

        // Methods
        public Wagon()
        {
            Animals = new List<Animal>();
        }
    }
}
