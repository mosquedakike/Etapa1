using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;


namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            Printer.DibijarTitulo("BIENVENIDOS A LA ESCUELA");
            engine.Inicializar();

            ImprimirCursosConColecciones(engine.Escuela);
            ReadLine();
        }
        

        public static void ImprimirCursosConColecciones(Escuela escuela)
        {
            Printer.DibijarTitulo("Cursos de la escuela con Colecciones");
            foreach (var curso in escuela.CursosConList)
            {
                WriteLine($"Nombre: {curso.Nombre} Jornada: {curso.Jornada} ID: {curso.UniqId}");
            }

        }
    }
}
