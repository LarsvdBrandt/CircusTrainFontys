using System;
using System.Collections.Generic;

namespace Circustrain
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(Size.Small, Sort.Herbivore, "Rabbit"));
            animals.Add(new Animal(Size.Middle, Sort.Herbivore, "Sheep"));
            animals.Add(new Animal(Size.Large, Sort.Herbivore, "Cow"));
            animals.Add(new Animal(Size.Small, Sort.Herbivore, "Toad"));
            animals.Add(new Animal(Size.Middle, Sort.Carnivore, "Cheeta"));
            animals.Add(new Animal(Size.Small, Sort.Carnivore, "Snake"));
            animals.Add(new Animal(Size.Middle, Sort.Herbivore, "Schildpad"));
            animals.Add(new Animal(Size.Large, Sort.Carnivore, "Lion"));
            animals.Add(new Animal(Size.Middle, Sort.Herbivore, "Goat"));
            animals.Add(new Animal(Size.Large, Sort.Herbivore, "Elephant"));
            animals.Add(new Animal(Size.Large, Sort.Carnivore, "Cheeta"));
            animals.Add(new Animal(Size.Large, Sort.Carnivore, "T-rex"));

            Train train = new Train();
            train.GetTrain(animals);
            WriteWagons(train);
        }

        public static void WriteWagons(Train train)
        {
            IReadOnlyList<Wagon> wagons = train.WagonList();

            foreach (Wagon wagon in wagons)
            {
                Console.WriteLine("");
                Console.WriteLine("New wagon");
                foreach (Animal animal in wagon.Animals)
                {
                    Console.WriteLine(animal.Sort + " | " + animal.AnimalSize.ToString() + " | " + animal.Name.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}