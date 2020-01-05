using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            
        }

        public void Inicializar()
        {
            Escuela = new Escuela("UPVM", 2009, TiposEscuela.Secundaria, "Mexico", "CDMX");

            CargarCuroso();

            CargarAsignaturas();

            CargarEvaluaciones();

        }
        

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.CursosConList)
            {
                var AsignaturasConList = new List<Asignatura>()
                {
                    new Asignatura(){Nombre="Ingles I"},
                    new Asignatura(){Nombre="Matematicas"},
                    new Asignatura(){Nombre="Fundamentos de Fisica"},
                    new Asignatura(){Nombre="Logica de Programacion"}
                };
                curso.Asignaturas = AsignaturasConList;
            }
        }

        private List<Alumno> GenerarAlumnosRandom(int cantidad )
        {
            string[] FirstName = { "Jose", "Luis", "Lirya", "Emmma", "Yolanda", "Rodrigo", "Cecilia" };
            string[] SecondName= { "Miguel", "Enrique", "Angel", "Jon", "Freddy", "Antonio", "Itzel" };
            string[] LastName = { "Hernández", "Mosqueda", "Navarrete", "Orozco", "Guzman", "Valencia", "Peñaloza" };

            var ListaAlumnos = from n1 in FirstName
                               from n2 in SecondName
                               from a1 in LastName
                               select new Alumno { Nombre = $"{n1} {n2} {a1}"};
            return ListaAlumnos.OrderBy((al)=>al.UniqId).Take(cantidad).ToList();
        }

        private void CargarEvaluaciones()
        {
            //throw new NotImplementedException();
        }

        private void CargarCuroso()
        {
            Escuela.CursosConList = new List<Curso>()
            {
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "401", Jornada = TiposJornada.Tarde},
                new Curso(){ Nombre = "501", Jornada = TiposJornada.Tarde}
            };

            Random rnd = new Random();
            foreach (var c in Escuela.CursosConList)
            {
                int cantRandom = rnd.Next(5, 20);
                c.Alumnos = GenerarAlumnosRandom(cantRandom);
            }
        }

    }
}
