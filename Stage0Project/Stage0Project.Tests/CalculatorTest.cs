using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stage0Project.Logic;

namespace Stage0Project.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            CalculatorLogic calc = new CalculatorLogic();

            // Act
            int result = calc.Add(2, 3);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}