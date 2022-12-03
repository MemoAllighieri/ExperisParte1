using System;

namespace Parte01
{
    public class ChangeString
    {
        static string[] abecedario = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        public static string Build(string cadena)
        {
            string rpta = "";
            foreach (var a in cadena)
            {
                char letraminuscula = char.ToLower(a);
                int indice = Array.IndexOf(abecedario, letraminuscula.ToString());
                rpta += indice != -1 ? (a.Equals(char.ToLower(a)) ? abecedario[indice + 1] : char.ToUpper(char.Parse(abecedario[indice + 1]))) : letraminuscula.ToString();
            }
            return rpta;
        }
    }
}