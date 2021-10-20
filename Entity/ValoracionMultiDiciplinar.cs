using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class ValoracionMultiDiciplinar
    {
        public string InformeIndividual { get; set; }
        public string InformeGrupal { get; set; }

        public CategoriaEvaluacion CategoriaEvaluacion { get; set; }

        public ValoracionMultiDiciplinar(string informeIndividual, string informeGrupal, CategoriaEvaluacion categoriaEvaluacion)
        {
            InformeIndividual = informeIndividual;
            InformeGrupal = informeGrupal;
            CategoriaEvaluacion = categoriaEvaluacion;
        }
    }
}
