using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Lesion
    {
        public string Caracteristicas { get; set; }
        
        public string Antecedentes { get; set;  }

        public Lesion(string caracteristicas, string antecedentes)
        {
            Caracteristicas = caracteristicas;
            Antecedentes = antecedentes;
        }
    }
}
