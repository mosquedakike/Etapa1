using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escuela numero 1
            var escuela = new Escuela("Platzi",1994);
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";
            escuela.TipoEscuela = TiposEscuela.Kinder;
            Console.WriteLine(escuela);

            //Escuela numero2 con el mismo constructor
            var escuela1 = new Escuela("UPVM",2009,TiposEscuela.Secundaria,"Mexico","CDMX");
            Console.ReadLine();        
        }
    }
}
