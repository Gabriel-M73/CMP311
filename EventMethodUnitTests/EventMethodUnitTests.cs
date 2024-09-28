using EventInterface;
namespace EventMethodUnitTests
{
    [TestClass]
    public class EventMethodUnitTests
    {
        [TestMethod]
        public void RentalEngine_DiscountCode_LCase()
        {
            // arrange
            Tool tool = new Tool("Tool", "Fastener", "Handle", 50.00);
            IRentEngine rentEngine = tool;
            // act
            double code = rentEngine.RentalEngine("d");
            // assert
            Assert.AreEqual(code, 45.00);
        }

        [TestMethod]
        public void RentalEngine_DiscountCode_UCase()
        {
            // arrange
            Tool tool = new Tool("Tool", "Fastener", "Handle", 50.00);
            IRentEngine rentEngine = tool;
            // act
            double code = rentEngine.RentalEngine("D");
            // assert
            Assert.AreEqual(code, 45.00);
        }

        [TestMethod]
        public void RentalEngine_EmployeeCode_LCase()
        {
            // arrange
            Tool tool = new Tool("Tool", "Fastener", "Handle", 50.00);
            IRentEngine rentEngine = tool;
            // act
            double code = rentEngine.RentalEngine("e");
            // assert
            Assert.AreEqual(code, 37.50);
        }

        [TestMethod]
        public void RentalEngine_EmployeeCode_UCase()
        {
            // arrange
            Tool tool = new Tool("Tool", "Fastener", "Handle", 50.00);
            IRentEngine rentEngine = tool;
            // act
            double code = rentEngine.RentalEngine("E");
            // assert
            Assert.AreEqual(code, 37.50);
        }

        [TestMethod]
        public void RentalEngine_FreeCode_LCase()
        {
            // arrange
            Tool tool = new Tool("Tool", "Fastener", "Handle", 50.00);
            IRentEngine rentEngine = tool;
            // act
            double code = rentEngine.RentalEngine("f");
            // assert
            Assert.AreEqual(code, 0.00);
        }

        [TestMethod]
        public void RentalEngine_FreeCode_UCase()
        {
            // arrange
            Tool tool = new Tool("Tool", "Fastener", "Handle", 50.00);
            IRentEngine rentEngine = tool;
            // act
            double code = rentEngine.RentalEngine("F");
            // assert
            Assert.AreEqual(code, 0.00);
        }

        [TestMethod]
        public void RentalEngine_Late_LCase()
        {
            // arrange
            Tool tool = new Tool("Tool", "Fastener", "Handle", 50.00);
            IRentEngine rentEngine = tool;
            // act
            double code = rentEngine.RentalEngine("l");
            // assert
            Assert.AreEqual(code, 55.00);
        }

        [TestMethod]
        public void RentalEngine_Late_UCase()
        {
            // arrange
            Tool tool = new Tool("Tool", "Fastener", "Handle", 50.00);
            IRentEngine rentEngine = tool;
            // act
            double code = rentEngine.RentalEngine("L");
            // assert
            Assert.AreEqual(code, 55.00);
        }
    }
}