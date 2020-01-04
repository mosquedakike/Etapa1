using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibijarLinea(int tam = 20)
        {
            WriteLine("".PadLeft(tam,'*'));
        }

        public static void DibijarTitulo(string title)
        {
            var tamaño = title.Length + 4;
            DibijarLinea(tamaño);
            WriteLine($"| {title} |");
            DibijarLinea(tamaño);
        }
    }
}
