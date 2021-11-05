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

        public IList<CIE> Diagnosticos { get; set; }

        public Diagnostico(string observacionesExtra,string codigo,string descripcion)
        {
            ObservacionesExtra = observacionesExtra;
            Diagnosticos = new List<CIE>();
            AgregarCIE(codigo,descripcion);
        }

        public void AgregarCIE(string codigo,string descripcion)
        {
            CIE cie = new CIE(codigo,descripcion);
            Diagnosticos.Add(cie);
        }
        
    }
}
