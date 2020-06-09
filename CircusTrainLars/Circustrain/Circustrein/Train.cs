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

        public void LoadTrain(List<Animal> animals)
        {
            int wagonIndex = 0;

            while (animals.Count != 0)
            {
                AddWagon(wagonIndex, animals[0]);
                Wagon wagon = Wagons[wagonIndex];
                animals.RemoveAt(0);

                for (int i = animals.Count - 1; i >= 0; i--)
                {
                    Animal animal = animals[i];
                    if (wagon.AddAnimal(animal))
                    {
                        animals.Remove(animal);
                    }
                }
                wagonIndex += 1;
            }
        }

        public void AddWagon(int wagonSize, Animal animal)
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
