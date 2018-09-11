using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;

namespace KaffeTests
{
    [TestClass]
    public class SortKaffeTest
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PrisTestForMegetRabat20kr()
        {
            //Arrange
            var sortKaffe = new SortKaffe(20);

            //Act
            int pris = sortKaffe.Pris();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PrisTestForMegetRabat21kr()
        {
            //Arrange
            var sortKaffe = new SortKaffe(21);

            //Act
            int pris = sortKaffe.Pris();
        }

        /// <summary>
        /// Rabatten skal være 0 når default ctor kaldes
        /// </summary>
        [TestMethod]
        public void SortKaffeDefaultConstructorRabat()
        {
            //Arrange
            var sortKaffe = new SortKaffe();

            //Act
            sortKaffe.Styrke();

            //Assert
            Assert.AreEqual(sortKaffe.Rabat, 0);
        }
    }
}
