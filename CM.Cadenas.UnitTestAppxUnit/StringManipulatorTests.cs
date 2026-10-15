using Xunit;
using CM.Cadenas;

namespace CM.Cadenas.UnitTestAppxUnit
{
    public class StringManipulatorTests
    {
        private readonly StringManipulator manipulador = new();

        // Pruebas para invertir cadenas.
        [Theory]
        [InlineData("hola", "aloh")]
        [InlineData("Carlos", "solraC")]
        [InlineData("12345", "54321")]
        [InlineData("", "")]
        [InlineData("a", "a")]
        public void ReverseString_DebeInvertirCorrectamente(
            string entrada, string esperado)
        {
            string resultado = manipulador.ReverseString(entrada);
            Assert.Equal(esperado, resultado);
        }

        // Pruebas para eliminar espacios.
        [Theory]
        [InlineData("Hola mundo", "Holamundo")]
        [InlineData("Carlos Moran", "CarlosMoran")]
        [InlineData(" a  b  c ", "abc")]
        [InlineData("", "")]
        [InlineData("SinEspacios", "SinEspacios")]
        public void RemoveSpaces_DebeEliminarEspaciosCorrectamente(
            string entrada, string esperado)
        {
            string resultado = manipulador.RemoveSpaces(entrada);
            Assert.Equal(esperado, resultado);
        }
    }
}

