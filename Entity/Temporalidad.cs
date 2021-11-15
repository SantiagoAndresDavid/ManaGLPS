using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Temporalidad
    {
        public int codigo { get; set; }
        public DateTime FechaCreada { get; set; }
        public DateTime UltimaModificacion { get; set; }

        public Temporalidad(DateTime fechaCreada, DateTime ultimaModificacion)
        {
            FechaCreada = fechaCreada;
            UltimaModificacion = ultimaModificacion;
        }
    }
}
