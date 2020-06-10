using Circustrain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrainTest
{
    [TestClass]
    public class WagonTest
    {
        private Wagon _wagon;
        [TestInitialize]
        public void Setup()
        {
            _wagon = new Wagon();
        }

        [TestMethod]
        public void Wagon_Can_Be_Constructed_With_Default_Capacity()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsNotNull(_wagon);
            Assert.AreEqual(10, _wagon.Size);
        }

        [TestMethod]
        public void When_Animal_Is_Added_UsedSize_Is_Higher()
        {
            //Arrange
            Animal a = new Animal(5, "Herbivore", "Sheep");
            int wagonSize = _wagon.UsedSize;
            int expectedSize = wagonSize + a.AnimalSize;

            //Act
            _wagon.AddAnimalToWagon(a);

            //Assert
            Assert.AreEqual(expectedSize, _wagon.UsedSize);
        }

        [TestMethod]
        public void Cant_Add_Animal_To_Wagon_When_UsedSize_Is_Too_Big()
        {
            //Arrange
            Animal a = new Animal(5, "Herbivore", "Sheep");
            Animal b = new Animal(5, "Herbivore", "Cow");
            Animal c = new Animal(1, "Herbivore", "Rabbit");
            bool AnimalFits = false;

            //Act
            _wagon.AddAnimalToWagon(a);
            _wagon.AddAnimalToWagon(b);
            if(_wagon.DoesAnimalFit(c) == true)
            {
                AnimalFits = true;
            }

            //Assert
            Assert.IsFalse(AnimalFits);
        }



        /*
        [TestMethod]
        public void Cant_Add_Herbivore_With_SameSize_Or_Bigger_Carnivore()
        {
            //Arrange

            Animal a = new Animal(5, "Herbivore", "Sheep");
            Animal b = new Animal(5, "Carnivore", "Lion");
            _wagon.AddAnimalToWagon(a);

            //Act
            _wagon.AddAnimalToWagon(b);

            //Assert
            Assert.IsTrue(expectedSize, w.UsedSize);
        }*/

    }
}