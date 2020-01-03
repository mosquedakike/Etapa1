using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;


namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();

            ImprimirCursosConColecciones(engine.Escuela);
        }
        

        public static void ImprimirCursosConColecciones(Escuela escuela)
        {
            WriteLine("*******************************************");
            WriteLine("Cursos de la escuela con Colecciones");
            WriteLine("*******************************************");
            foreach (var curso in escuela.CursosConList)
            {
                WriteLine($"Nombre: {curso.Nombre} Jornada: {curso.Jornada} ID: {curso.UniqId}");
            }

        }
    }
}
