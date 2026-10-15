namespace CM.Temperatura
{
    public class TemperatureConverter
    {
        // Convierte grados Celsius a Fahrenheit.
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9.0 / 5.0) + 32;
        }

        // Convierte grados Fahrenheit a Celsius.
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5.0 / 9.0;
        }
    }
}
