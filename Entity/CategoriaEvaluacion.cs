using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CategoriaEvaluacion
    {
        public int Codigo { get; set; }
        public int EscalaDolor { get; set; }
        public string Localizacion { get; set; }
        public int FrecuenciaAumento { get; set; }
        public int FrecuenciaDisminucion { get; set; }

        public CategoriaEvaluacion(int escalaDolor, string localizacion, int frecuenciaAumento, int frecuenciaDisminucion)
        {
            EscalaDolor = escalaDolor;
            Localizacion = localizacion;
            FrecuenciaAumento = frecuenciaAumento;
            FrecuenciaDisminucion = frecuenciaDisminucion;
        }
    }
}
