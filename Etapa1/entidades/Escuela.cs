using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string UniqId { get; set; } = Guid.NewGuid().ToString();

        public string nombre;
        public string Nombre { get; set; }

        public int AñoDeCreacion { get; set; }

        public string Ciudad { get; set; }

        public string Pais { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public Curso[] CursosConArray { get; set; }

        public List<Curso> CursosConList { get; set; }

        public Escuela(string nombre, int año)
        {
             this.nombre = nombre;
             año = AñoDeCreacion;
        }

        public Escuela(string nombre, int año, TiposEscuela tipo, string pais="", string ciudad="")
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
        }

        //public Escuela(string nombre, int año) => (Nombre,AñoDeCreacion) = (nombre,año);

    }
}