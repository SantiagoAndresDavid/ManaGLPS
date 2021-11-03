using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Diagnostico
    {
        public string ObservacionesExtra { get; set; }
        public CIE CIE { get; set; }

        public Diagnostico(string observacionesExtra,string codigo,string descripcion)
        {
            ObservacionesExtra = observacionesExtra;
            CIE = new CIE(codigo,descripcion) ;
        }
    }
}
