using System.Collections.Generic;

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

        private void NewWagon(int wagonSize, Animal animal)
        {
            _wagons.Add(new Wagon());

            Wagons[wagonSize].AddAnimalToWagon(animal);
        }

        public void GetTrain(List<Animal> animals)
        {
            int spaceInWagon = 0;

            while (animals.Count != 0)
            {
                NewWagon(spaceInWagon, animals[0]);
                Wagon wagon = Wagons[spaceInWagon];
                animals.RemoveAt(0);

                for (int i = animals.Count - 1; i >= 0; i--)
                {
                    Animal animal = animals[i];
                    if (wagon.AddAnimalToWagon(animal) == true)
                    {
                        animals.Remove(animal);
                    }
                }
                spaceInWagon += 1;
            }
        }

        public IReadOnlyList<Wagon> GetWagons()
        {
            return Wagons;
        }

        public IReadOnlyList<Animal> GetListOfAnimals()
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