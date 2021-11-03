using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class ValoracionIngreso
    {
        public string Deportiva { get; set; }
        public String DiagnosticoRemision { get; set; }
        public byte ImagenDiagnostico { get; set; }
        public Lesion Lesion { get; set;}
        public ValoracionIngreso(string deportiva, string diagnosticoRemision, byte imagenDiagnostico, string caracteristicas, string antecedentes)
        {
            Deportiva = deportiva;
            DiagnosticoRemision = diagnosticoRemision;
            ImagenDiagnostico = imagenDiagnostico;
            Lesion = new Lesion(caracteristicas,antecedentes);
        }
    }
}
