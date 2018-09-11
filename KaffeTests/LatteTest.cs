using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;

namespace KaffeTests
{
    [TestClass]
    public class LatteTest
    {
        [TestMethod()]
        public void prisTestLatte()
        {
            //Arrange
            var latte = new Latte();

            //Act
            int pris = latte.Pris();

            //assert
            Assert.AreEqual(40, pris);

        }
    }
}
