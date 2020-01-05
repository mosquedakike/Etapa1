using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEscuela.Entidades
{
    public class Evaluacion
    {
        public string UniqId { get; set; }
        public string Nombre { get; set; }

        public Evaluacion() => UniqId = Guid.NewGuid().ToString();

        public Alumno Alumno { get; set; }

        public Asignatura Asignatura { get; set; }

        public float Calificacion { get; set; }
    }
}
