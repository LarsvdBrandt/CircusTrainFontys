using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Sorting
    {
        public Train LoadTrain(List<Animal> animals)
        {
            Train train = new Train();
            int wagonIndex = 0;

            while (animals.Count != 0)
            {
                train.AddWagon(wagonIndex, animals[0]);
                animals.RemoveAt(0);

                for (int i = animals.Count - 1; i >= 0; i--)
                {
                    if (train.DoesAnimalFit(wagonIndex, animals[i]))
                        continue;

                    if (train.IsAnimalCompatible(wagonIndex, animals[i]))
                    {
                        train.AddAnimalToWagon(wagonIndex, animals[i]);
                        animals.Remove(animals[i]);
                    }
                }
                wagonIndex += 1;
            }
            return train;
        }
    }
}
