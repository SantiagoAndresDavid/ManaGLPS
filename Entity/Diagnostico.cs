using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Diagnostico
    {
        public string ObservacionesExtra { get; set; }
        
        public IList<CIE> Diagnosticos { get; set; }

        public Diagnostico()
        { 
            
        }

        public void AgregarCIE(CIE cie)
        {
            Diagnosticos.Add(cie);
        }
        
    }
}
