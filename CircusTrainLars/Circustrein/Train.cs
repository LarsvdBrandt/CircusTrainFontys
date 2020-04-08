using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        // Properties
        List<Wagon> Wagons { get; set; }

        // Methods
        public Train()
        {
            Wagons = new List<Wagon>();
        }

        public void AddWagon(int wagonSize, Animal animal)
        {
            Wagons.Add(new Wagon());

            Wagons[wagonSize].AddAnimal(animal);
            Wagons[wagonSize].UsedSize = animal.Size;
        }

        public bool IsAnimalCompatible(int wagonIndex, Animal animal)
        {
            bool compatible = true;

            foreach (Animal wagonAnimal in Wagons[wagonIndex].Animals)
            {
                if (wagonAnimal.Food == "Carnivore" && wagonAnimal.Size >= animal.Size)
                {
                    compatible = false;
                    break;
                }
                if (animal.Food == "Carnivore" && wagonAnimal.Size <= animal.Size)
                {
                    compatible = false;
                    break;
                }
            }

            return compatible;
        }

        public bool DoesAnimalFit(int wagonIndex, Animal animal)
        {
            if (Wagons[wagonIndex].UsedSize + animal.Size > 10)
                return true;
            else
                return false;
        }

        public void AddAnimalToWagon(int wagonIndex, Animal animal)
        {
            Wagons[wagonIndex].AddAnimal(animal);
        }

        public List<Wagon> GetWagons()
        {
            return Wagons;
        }
    }
}
