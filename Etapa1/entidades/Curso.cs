using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }

        /*public Curso()
        {
            UniqId = Guid.NewGuid().ToString();
        }*/

        public Curso() =>  UniqId = Guid.NewGuid().ToString();

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Jornada: {Jornada} \nID: {UniqId}";
        }

    }
}
