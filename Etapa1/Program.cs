using System;
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


            //Array declarado con su tamaño
            var arrayCursos = new Curso[3];

            arrayCursos[0] = new Curso() { Nombre = "101" };
            arrayCursos[1] = new Curso() { Nombre = "201" };
            arrayCursos[2] = new Curso() { Nombre = "301", Jornada = TiposJornada.Noche };

            //Array sin tamaño
            escuela.Cursos = new Curso[]{
                new Curso(){ Nombre = "401"},
                new Curso(){ Nombre = "501"},
                new Curso(){ Nombre = "601", Jornada = TiposJornada.Tarde}
            };


           
            for (int i = 0; i < arrayCursos.Length; i++)
            {
                WriteLine("Posicion: " + i + " " + "Curso: " + arrayCursos[i]);
            }

            foreach (var curso in arrayCursos)
            {
                WriteLine($"Nombre: {curso.Nombre} UniqId: {curso.UniqId}");
            }


            ImprimirCursosEscuela(escuela);

            
        }

        public static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("*******************************************");
            WriteLine("Cursos de la escuela");
            WriteLine("*******************************************");
            foreach (var curso in escuela.Cursos)
            {
                WriteLine($"Nombre: {curso.Nombre} ID: {curso.UniqId}");
            }

        }
    }
}
