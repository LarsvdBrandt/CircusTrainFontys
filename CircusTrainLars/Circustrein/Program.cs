﻿using System;
using System.Collections.Generic;

namespace Circustrein
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(3, "Herbivore", "Rabbit"));
            animals.Add(new Animal(3, "Herbivore", "Sheep"));
            animals.Add(new Animal(5, "Herbivore", "Cow"));
            animals.Add(new Animal(1, "Carnivore", "Toad"));
            animals.Add(new Animal(3, "Carnivore", "Cheeta"));
            animals.Add(new Animal(1, "Carnivore", "Snake"));
            animals.Add(new Animal(1, "Herbivore", "Schildpad"));
            animals.Add(new Animal(3, "Carnivore", "Lion"));
            animals.Add(new Animal(3, "Herbivore", "Goat"));
            animals.Add(new Animal(5, "Herbivore", "Elephant"));


            Sorting sorter = new Sorting();
            Train train = sorter.LoadTrain(animals);
            WagonsWrite(train);
        }

        public static void WagonsWrite(Train train)
        {
            List<Wagon> wagons = train.GetWagons();

            foreach (Wagon wagon in wagons)
            {
                Console.WriteLine("");
                Console.WriteLine("New wagon");
                foreach (Animal animal in wagon.Animals)
                {
                    Console.WriteLine(animal.Food + " " + animal.Size.ToString() + " " + animal.Name.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}