using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string UniqId { get; set; }
        public string Nombre { get; set; }

        public Alumno() => UniqId = Guid.NewGuid().ToString();


    }
}
