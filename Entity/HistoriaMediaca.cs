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
        public int Id { get; set; }
        public bool Estado { get; set; }


        public HistoriaMediaca(DateTime fechaDeCreacion, DateTime ultimaFechaDeEdicion, DateTime fechaDeFinalizacion, string titulo, int id, bool estado)
        {

            this.FechaDeCreacion = fechaDeCreacion;
            this.UltimaFechaDeEdicion = ultimaFechaDeEdicion;
            this.FechaDeFinalizacion = fechaDeFinalizacion;
            this.Titutlo = titulo;
            this.Id = id;
            this.Estado = estado;


        }
    }
}
