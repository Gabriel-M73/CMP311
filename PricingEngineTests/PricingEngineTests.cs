using Microsoft.VisualStudio.TestTools.UnitTesting;
using PricingEngineApp;

namespace PricingEngineTests
{
    [TestClass]
    public class PricingEngineTests
    {
        [TestMethod]
        public void CalculateUnitPrice_BelowMinPrice()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 0.50m);
            // assert
            Assert.AreEqual(unitPrice, 0.50m);

        }

        [TestMethod]
        public void CalculateUnitPrice_MinPrice()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 1.00m);
            // assert
            Assert.AreEqual(unitPrice, 1.000m);
        }

        [TestMethod]
        public void CalculateUnitPrice_BelowMinQty()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(5, 10.00m);
            // assert
            Assert.AreEqual(unitPrice, 10.00m);
        }

        [TestMethod]
        public void CalculateUnitPrice_MinQtyLower()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(11, 30.00m);
            // assert
            Assert.AreEqual(unitPrice, 27.00m);
        }

        [TestMethod]
        public void CalculateUnitPrice_MinQtyUpper()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(20, 50.00m);
            // assert
            Assert.AreEqual(unitPrice,45.00m);
        }

        [TestMethod]
        public void CalculateUnitPrice_QtyGT20()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(30, 100.00m);
            // assert
            Assert.AreEqual(unitPrice,80.00m);
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinPrice()
        {
            // arrange
            PricingEngine engine = new PricingEngine(true);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 0.50m);
            // assert
            Assert.AreEqual(unitPrice, 0.50m);
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinTotal()
        {
            // arrange
            PricingEngine engine = new PricingEngine(true);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(1, 10.00m);
            // assert
            Assert.AreEqual(unitPrice, 10.00m);
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinQty()
        {
            // Test the discount for holiday and quantity = 10 and total
            // discounted amount is above the holiday threshold

            // arrange
            PricingEngine engine = new PricingEngine(true);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 2000.00m);
            // assert
            Assert.AreEqual(unitPrice, 1800.00m);
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayMinQty()
        {
            // Test the discount for holiday and quantity = 10 and total
            // discounted amount is above the holiday threshold

            // arrange
            PricingEngine engine = new PricingEngine(true);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 3000.00m);
            // assert
            Assert.AreEqual(unitPrice, 2700.00m);
        }
    }
}
