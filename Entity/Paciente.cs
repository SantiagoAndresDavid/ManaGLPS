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
        public Afiliacion Afiliacion { get; set; }
        public HistoriaMedica HistoriaMedica { get; set; }

        public Paciente(int identificacion, string nombre, string apellido, int edad, int telefono, Afiliacion afiliacion, HistoriaMedica historiaMedica, DateTime fechaCreacion, DateTime FechaEdicion, DateTime fechaFinalizacion, string tituloHistoria, int codigo, string estado)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Telefono = telefono;
            Afiliacion = afiliacion;
            HistoriaMedica = new HistoriaMedica(fechaCreacion, FechaEdicion, fechaFinalizacion, tituloHistoria, codigo, estado);
        }




    }
}
