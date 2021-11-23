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
        public int Codigo { get; set; }
        
        public IList<CIE> CIE { get; set; }


        public Diagnostico()
        {
        }

        public Diagnostico(string observacionesExtra)
        {
            ObservacionesExtra = observacionesExtra;
            Codigo = 0;
            CIE = new List<CIE>();
        }

        public void AgregarCIE(CIE cie)
        {
            CIE.Add(cie);
        }
        
    }
}
