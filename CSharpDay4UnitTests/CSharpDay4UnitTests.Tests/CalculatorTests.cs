using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDay4UnitTests.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddNumbers()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.AddNumbers(3, 6);

            // Assert
            Assert.AreEqual(9, result);
        }
    }
}
