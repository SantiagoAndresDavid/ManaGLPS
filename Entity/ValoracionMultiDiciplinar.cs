using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ValoracionMultiDiciplinar
    {
        public string InformeIndividual { get; set; }
        public string InformeGrupal { get; set; }

        public CategoriaEvaluacion CategoriaEvaluacion { get; set; }

        public ValoracionMultiDiciplinar(string informeIndividual, string informeGrupal,int escala, string localizacion,int aumento,int disminucion)
        {
            InformeIndividual = informeIndividual;
            InformeGrupal = informeGrupal;
            CategoriaEvaluacion = new CategoriaEvaluacion(escala,localizacion,aumento,disminucion);
        }
    }
}
