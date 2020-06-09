using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrain
{
    public class Train
    {
        private readonly List<Wagon> _wagons;
        public IReadOnlyList<Wagon> Wagons => _wagons.AsReadOnly();

        public Train()
        {
            _wagons = new List<Wagon>();
        }

        public void Run(List<Animal> animals)
        {
            int wagonSpace = 0;

            while (animals.Count != 0)
            {
                NewWagon(wagonSpace, animals[0]);
                Wagon wagon = Wagons[wagonSpace];
                animals.RemoveAt(0);

                for (int i = animals.Count - 1; i >= 0; i--)
                {
                    Animal animal = animals[i];
                    if (wagon.AddAnimal(animal))
                    {
                        animals.Remove(animal);
                    }
                }
                wagonSpace += 1;
            }
        }

        public void NewWagon(int wagonSize, Animal animal)
        {
            _wagons.Add(new Wagon());

            Wagons[wagonSize].AddAnimal(animal);
        }

        public IReadOnlyList<Wagon> GetWagons()
        {
            return Wagons;
        }

        public IReadOnlyList<Animal> GetAnimals()
        {
            List<Animal> animals = new List<Animal>();

            foreach (Wagon wagon in Wagons)
            {
                foreach (Animal animal in wagon.GetAnimals())
                {
                    animals.Add(animal);
                }
            }

            return animals;
        }
    }
}
