using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class CIE
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public CIE(string codigo, string descripcion)
        {
            this.Codigo = codigo;
            Descripcion = descripcion;
        }
    }
}
