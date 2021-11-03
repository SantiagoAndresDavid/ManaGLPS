using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class HistoriaMedica
    {
        public DateTime FechaDeCreacion { get; set; }
        public DateTime UltimaFechaDeEdicion{ get; set; }
        public DateTime FechaDeFinalizacion { get; set; }
        public string Titutlo{ get; set; }
        public int Codigo { get; set; }
        public string Estado { get; set; }
        public IList<ConsultaMedica> Consultas { get; set; }

        public HistoriaMedica(DateTime fechaDeCreacion, DateTime ultimaFechaDeEdicion, DateTime fechaDeFinalizacion, string titutlo, int codigo, string estado)
        {
            FechaDeCreacion = fechaDeCreacion;
            UltimaFechaDeEdicion = ultimaFechaDeEdicion;
            FechaDeFinalizacion = fechaDeFinalizacion;
            Titutlo = titutlo;
            Codigo = codigo;
            Estado = estado;
            Consultas = new List<ConsultaMedica>();
        }

        public void añadirConsultaMedica(ConsultaMedica consulta)
        {
            Consultas.Add(consulta);
        }

    }
}
