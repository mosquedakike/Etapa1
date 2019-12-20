using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("UPVM",2009,TiposEscuela.Secundaria,"Mexico","CDMX");
            Console.WriteLine(escuela);

            var curso1 = new Curso()
            {
                Nombre = "101"
            };

            var curso2 = new Curso()
            {
                Nombre = "201",
                Jornada = TiposJornada.Noche
            };

            Console.WriteLine(curso1);
        }
    }
}
