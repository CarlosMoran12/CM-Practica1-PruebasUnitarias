using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.Temperatura;

namespace CM.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        private readonly TemperatureConverter converter = new();

        [TestMethod]
        [DataRow(0.0, 32.0)]
        [DataRow(100.0, 212.0)]
        [DataRow(-40.0, -40.0)]
        public void CelsiusToFahrenheit_DebeConvertirCorrectamente(
            double celsius, double esperado)
        {
            double resultado = converter.CelsiusToFahrenheit(celsius);
            Assert.AreEqual(esperado, resultado, 0.000001);
        }

        [TestMethod]
        [DataRow(32.0, 0.0)]
        [DataRow(212.0, 100.0)]
        [DataRow(-40.0, -40.0)]
        public void FahrenheitToCelsius_DebeConvertirCorrectamente(
            double fahrenheit, double esperado)
        {
            double resultado = converter.FahrenheitToCelsius(fahrenheit);
            Assert.AreEqual(esperado, resultado, 0.000001);
        }
    }
}

