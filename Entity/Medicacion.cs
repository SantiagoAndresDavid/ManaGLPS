using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Medicacion
    {
        public int codigo { get; set; }
        public string Prescripcion { get; set; }
        public string Rehabilitacion { get; set; }

        public Medicacion(string prescripcion, string rehabilitacion)
        {
            Prescripcion = prescripcion;
            Rehabilitacion = rehabilitacion;
        }
    }
}
