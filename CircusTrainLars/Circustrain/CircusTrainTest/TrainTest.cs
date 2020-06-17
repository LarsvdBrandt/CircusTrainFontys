using Circustrain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CircusTrainTest
{
    [TestClass]
    public class TrainTest
    {
        //Weet niet hoe ik deze test moet uitvoeren
        [TestMethod]
        public void TrainTester()
        {
            // Arrange
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(Size.Small, Sort.Carnivore, "Lion"));

            // Act
            Train train = new Train();
            train.GetTrain(animals);
            IReadOnlyList<Animal> loadedAnimals = train.GetListOfAnimals();

            // Assert
            Assert.IsTrue(loadedAnimals[0].Name == "Lion");
        }

    }
}
