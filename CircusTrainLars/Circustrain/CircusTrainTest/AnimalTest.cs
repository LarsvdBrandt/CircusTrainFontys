using Circustrain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrainTest
{
    [TestClass]
    public class AnimalTest
    {
        public Wagon _wagon;
        [TestInitialize]
        public void Setup()
        {
            _wagon = new Wagon();
        }

        //IsAnimalCompatable
        [TestMethod]
        public void Cant_Add_Herbivore_With_SameSize_Carnivore()
        {
            //Arrange
            Animal a = new Animal(Size.Large, Sort.Carnivore, "Lion");
            Animal b = new Animal(Size.Large, Sort.Herbivore, "Elephant");

            //Act
            bool animalIsNotCompatable = a.IsAnimalCompatable(b);

            //Assert
            Assert.IsTrue(animalIsNotCompatable);
        }

        [TestMethod]
        public void Cant_Add_Herbivore_With_BiggerSize_Carnivore()
        {
            //Arrange

            Animal a = new Animal(Size.Large, Sort.Carnivore, "Lion");
            Animal b = new Animal(Size.Small, Sort.Herbivore, "Rabbit");

            //Act
            bool animalIsNotCompatable = a.IsAnimalCompatable(b);

            //Assert
            Assert.IsTrue(animalIsNotCompatable);
        }

        [TestMethod]
        public void Can_Add_Herbivore_With_SmallerSize_Carnivore()
        {
            //Arrange
            Animal a = new Animal(Size.Large, Sort.Herbivore, "Cow");
            Animal b = new Animal(Size.Small, Sort.Herbivore, "snake");

            //Act
            bool animalIsNotCompatable = a.IsAnimalCompatable(b);

            //Assert
            Assert.IsFalse(animalIsNotCompatable);
        }

        [TestMethod]
        public void Can_Add_Herbivore_With_BiggerSize_Herbivore()
        {
            //Arrange
            Animal a = new Animal(Size.Large, Sort.Herbivore, "Giraffe");
            Animal b = new Animal(Size.Large, Sort.Herbivore, "Cow");

            //Act
            bool animalIsNotCompatable = a.IsAnimalCompatable(b);

            //Assert
            Assert.IsFalse(animalIsNotCompatable);
        }

    }
}
