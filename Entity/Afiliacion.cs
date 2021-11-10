using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Afiliacion
    {
        public Boolean Estado { get; set; }

        public Afiliacion(bool estado)
        {
            Estado = estado;
        }
    }
}
