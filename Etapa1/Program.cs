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

            var escuela2 = new Escuela("UNAM", 1800, TiposEscuela.Universidad, "Mexico", "CDMX");

            //Declaración de colecciones

            //Coleccion 
            escuela.CursosConList = new List<Curso>()
            {
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Tarde},
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Noche}
            };

            //Coleccion con [AddRange]
            var otraColeccion = new List<Curso>{
                new Curso{Nombre="101010", Jornada = TiposJornada.Noche}
            };

            //Array
            escuela.CursosConArray = new Curso[]{
                new Curso{ Nombre = "401"},
                new Curso{ Nombre = "501"},
                new Curso{ Nombre = "601", Jornada = TiposJornada.Tarde}
            };

            //Agregando nuevos Cursos a la coleccion [CursosConList]
            escuela.CursosConList.Add(new Curso { Nombre="102", Jornada = TiposJornada.Tarde});
            escuela.CursosConList.Add(new Curso { Nombre="10", Jornada = TiposJornada.Noche});

            //otraColeccion.Clear();
            escuela.CursosConList.AddRange(otraColeccion);

            Curso temp = new Curso
            {
                Nombre="Ingles", Jornada=TiposJornada.Mañana
            };

            //Agregando un nuevo objeto a la lista [CursosConList]
            escuela.CursosConList.Add(temp);

            ImprimirCursosConArreglos(escuela);
            ImprimirCursosConColecciones(escuela);

            //Removiendo el objeto [temp] de la coleccion [CursosConList]
            escuela.CursosConList.Remove(temp);

            //Removiendo el objeto [obj] que cumpla con la condicion del metodo [predicado]
            //escuela.CursosConList.RemoveAll(Predicado);
            escuela.CursosConList.RemoveAll(delegate (Curso cur)
            {
                return cur.Nombre == "301";
            });

            escuela.CursosConList.RemoveAll((cur)=>cur.Nombre=="101" && cur.Jornada == TiposJornada.Mañana);

            ImprimirCursosConColecciones(escuela);
            //El HashCode es una propiedad que tienen todos los objetos y es un identificador que se les asigna
            WriteLine(escuela.CursosConArray[0].GetHashCode());
            WriteLine(escuela.CursosConArray[1].GetHashCode());

            Console.ReadLine();
        }

        private static bool Predicado(Curso obj)
        {
            return obj.Nombre == "301";
        }

        private static void ImprimirCursosConArreglos(Escuela escuela)
        {
            WriteLine("*******************************************");
            WriteLine("Cursos de la escuela con Arraglos");
            WriteLine("*******************************************");
            foreach (var curso in escuela.CursosConArray)
            {
                WriteLine($"Nombre: {curso.Nombre} Jornada: {curso.Jornada} ID: {curso.UniqId}");
            }
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
