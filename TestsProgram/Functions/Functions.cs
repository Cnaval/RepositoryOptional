using Microsoft.VisualStudio.TestTools.UnitTesting;
using prueba;

namespace prueba
{
    [TestClass]
    public class Functions
    {
        [TestMethod]
        public void When_Divisible_by_3_Then_Name()
        {
            // AAA
            // Arrange
            // - Inicializa el nombre
            // - Inicializa un número divisible por 3 --> 3
            var numberDivisibleByThree = number % 3 == 0;
            // Act
            var myNameLogic = new MyName();
            var result = myNameLogic.GetValue(name, lastName, number);
            // Assert
            Assert.AreEqual(result);
        }
    }
}
