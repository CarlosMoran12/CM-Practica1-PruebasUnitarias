using System;
using System.Linq;

namespace CM.Cadenas
{
    public class StringManipulator
    {
        // Invierte una cadena de texto.
        public string ReverseString(string input)
        {
            ArgumentNullException.ThrowIfNull(input);
            return new string(input.Reverse().ToArray());
        }

        // Elimina espacios en blanco.
        public string RemoveSpaces(string input)
        {
            ArgumentNullException.ThrowIfNull(input);
            return new string(input.Where(c => !char.IsWhiteSpace(c)).ToArray());
        }
    }
}
