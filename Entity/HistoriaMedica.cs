using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HistoriaMedica
    {
        public DateTime FechaDeCreacion { get; set; }
        public DateTime UltimaFechaDeEdicion { get; set; }
        public DateTime FechaDeFinalizacion { get; set; }
        public string Titutlo { get; set; }
        public int Codigo { get; set; }
        public string Estado { get; set; }
        public IList<ConsultaMedica> Consultas { get; set; }

        public Paciente Paciente { get; set; }

        public HistoriaMedica()
        {

        }

        public HistoriaMedica(DateTime fechaDeCreacion, DateTime ultimaFechaDeEdicion, DateTime fechaDeFinalizacion,
            string titutlo, int codigo, string estado, int identificacion, string nombre, string apellido, int edad,
            int telefono, string afiliacion,ConsultaMedica consulta)
        {
            FechaDeCreacion = fechaDeCreacion;
            UltimaFechaDeEdicion = ultimaFechaDeEdicion;
            FechaDeFinalizacion = fechaDeFinalizacion;
            Titutlo = titutlo;
            Codigo = codigo;
            Estado = estado;
            Consultas = new List<ConsultaMedica>();
            añadirConsultaMedica(consulta);
            Paciente = new Paciente(identificacion,nombre,apellido,edad, telefono,afiliacion);
        }

        public void añadirConsultaMedica(ConsultaMedica consulta)
        {
            Consultas.Add(consulta);
        }
    }
}