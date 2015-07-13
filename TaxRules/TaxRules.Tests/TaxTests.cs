using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxRules.Tests
{
    [TestClass]
    public class TaxTests
    {
        [TestMethod]
        public void TestCalculateTodayIsThursday()
        {
            DateTime thursday = DateTime.Now;

            for (int i = 1; i < 8; i++)
            {
                if (thursday.DayOfWeek == DayOfWeek.Thursday)
                    return;

                thursday = thursday.AddDays(1);
            }

            // Arrange
            Tax tax = new Tax(thursday);

            // Act
            decimal result = tax.Calculate(100, DateTime.Parse("1998-05-16"), "John", "Doe");

            // Assert
            Assert.AreEqual(32, result);
        }
    }
}
