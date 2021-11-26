using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CIE
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public CIE()
        {
        }

        public CIE(string codigo, string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }
    }
}
