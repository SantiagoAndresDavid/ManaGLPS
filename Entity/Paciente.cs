using System;

namespace Entity
{
    class Paciente
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public string Afiliacion { get; set; }

        public Paciente(int identificacion, string nombre, string apellido, int edad, int telefono, string afiliacion)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Telefono = telefono;
            Afiliacion = afiliacion;
        }
    }
}