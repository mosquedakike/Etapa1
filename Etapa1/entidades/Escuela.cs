namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { Nombre = value; }
        }

        public int AñoDeCreacion { get; set; }

        public string Ciudad { get; set; }

        public string Pais { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public Escuela(string nombre, int año)
        {
             this.nombre = nombre;
             año = AñoDeCreacion;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
        }

        //public Escuela(string nombre, int año) => (Nombre,AñoDeCreacion) = (nombre,año);

    }
}