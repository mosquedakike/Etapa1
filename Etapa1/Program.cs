using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;


namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("UPVM",2009,TiposEscuela.Secundaria,"Mexico","CDMX");
            WriteLine(escuela);


            //Coleccion 
            escuela.Cursos2 = new List<Curso>()
            {
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "201", Jornada = TiposJornada.Tarde},
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Noche}
            };

            //Array
            escuela.Cursos = new Curso[]{
                new Curso{ Nombre = "401"},
                new Curso{ Nombre = "501"},
                new Curso{ Nombre = "601", Jornada = TiposJornada.Tarde}
            };

            escuela.Cursos2.Add(new Curso {Nombre="102", Jornada = TiposJornada.Tarde});

            ImprimirCursos2Escuela(escuela);
            ImprimirCursosEscuela(escuela);

            
        }

        private static void ImprimirCursos2Escuela(Escuela escuela)
        {
            WriteLine("*******************************************");
            WriteLine("Cursos de la escuela con Colecciones");
            WriteLine("*******************************************");
            foreach (var curso in escuela.Cursos2)
            {
                WriteLine($"Nombre: {curso.Nombre} ID: {curso.UniqId}");
            }
        }

        public static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("*******************************************");
            WriteLine("Cursos de la escuela con Arraglos");
            WriteLine("*******************************************");
            foreach (var curso in escuela.Cursos)
            {
                WriteLine($"Nombre: {curso.Nombre} ID: {curso.UniqId}");
            }

        }
    }
}
