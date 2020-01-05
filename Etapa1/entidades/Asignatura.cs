using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqId { get; set; }
        public string Nombre { get; set; }

        public Asignatura() => UniqId = Guid.NewGuid().ToString();


    }
}
