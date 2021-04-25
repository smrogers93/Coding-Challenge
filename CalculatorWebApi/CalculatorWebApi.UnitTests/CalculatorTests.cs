using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorWebApi.UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AvailableOperations_MethodIsCalled_ReturnsString()
        {
            var calculator = new Calculator();

            var result = calculator.AvailableOperations();

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void AddOrDivide_AddIsPassed_ReturnsASum()
        {
            var calculator = new Calculator();

            var result = calculator.AddOrDivide("add", 5, 5);

            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void AddOrDivide_DivideIsPassed_ReturnsAQuotient()
        {
            var calculator = new Calculator();

            var result = calculator.AddOrDivide("divide", 55, 11);

            Assert.AreEqual(result, 5);
        }
    }
}
