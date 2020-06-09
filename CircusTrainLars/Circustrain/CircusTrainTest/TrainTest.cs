using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrainTest
{
    [TestClass]
    public class TrainTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        public void IsDangerousForMe_TwoCarnivoreSameSize_True()
        {
            //Arrange
            var carnivoreSmall = new Carnivore(Size.Small);
            var carnivoreSmallCompare = new Carnivore(Size.Small);
            //Act
            var ret = carnivoreSmall.IsDangerousForMe(carnivoreSmallCompare);
            //Assert
            Assert.IsTrue(ret);
        }
    }
}
