using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class HistoriaMediaca
    {
        public DateTime FechaDeCreacion { get; set; }
        public DateTime UltimaFechaDeEdicion{ get; set; }
        public DateTime FechaDeFinalizacion { get; set; }
        public string Titutlo{ get; set; }
        public int Codigo { get; set; }
        public bool Estado { get; set; }
        public List<ConsultaMedica> Consultas { get; set; }

        public HistoriaMediaca(DateTime fechaDeCreacion, DateTime ultimaFechaDeEdicion, DateTime fechaDeFinalizacion, string titutlo, int codigo, bool estado, List<ConsultaMedica> consultas)
        {
            FechaDeCreacion = fechaDeCreacion;
            UltimaFechaDeEdicion = ultimaFechaDeEdicion;
            FechaDeFinalizacion = fechaDeFinalizacion;
            Titutlo = titutlo;
            Codigo = codigo;
            Estado = estado;
            Consultas = consultas;
        }
    }
}
