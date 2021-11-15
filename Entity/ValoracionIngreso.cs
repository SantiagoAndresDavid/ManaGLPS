using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ValoracionIngreso
    {
        public int Codigo { get; set; }
        
        public string Deportiva { get; set; }
        public String DiagnosticoRemision { get; set; }
        public string ImagenDiagnostico { get; set; }
        public Lesion Lesion { get; set;}
        public ValoracionIngreso(string deportiva, string diagnosticoRemision, string imagenDiagnostico, string caracteristicas, string antecedentes)
        {
            Deportiva = deportiva;
            DiagnosticoRemision = diagnosticoRemision;
            ImagenDiagnostico = imagenDiagnostico;
            Lesion = new Lesion(caracteristicas,antecedentes);
        }
    }
}
