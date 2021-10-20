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

        public Diagnostico(string observacionesExtra, CIE cIE)
        {
            ObservacionesExtra = observacionesExtra;
            CIE = cIE;
        }
    }
}
