using System;

namespace Entity
{
    class ConsultaMedica
    {
        public int Codigo { get; set; }
        public Boolean Estado { get; set; }
        public int FaseTratamiento { get; set; }
        public Diagnostico Diagnostico { get; set; }
        public Temporalidad Temporalidad { get; set; }
        public Medicacion Medicacion { get; set; }
        public ValoracionMultiDiciplinar ValoracionMultiDiciplinar { get; set; }
        public ValoracionIngreso ValoracionIngreso { get; set; }

        public ConsultaMedica(int codigo, bool estado, int faseTratamiento,string diagnistico,string codigoCIE, string descripcion,DateTime fechacreada,DateTime ultimaModificacion,string prescripcion,string rehabilitacion, string informeIndividual, string informeGrupal, int escala, string localizacion, int aumento, int disminucion, string deportiva, string diagnosticoRemision, byte imagenDiagnostico, string caracteristicas, string antecedentes)
        {
            Codigo = codigo;
            Estado = estado;
            FaseTratamiento = faseTratamiento;
            Diagnostico = new Diagnostico(diagnistico,codigoCIE,descripcion);
            Temporalidad = new Temporalidad(fechacreada,ultimaModificacion);
            Medicacion = new Medicacion(prescripcion,rehabilitacion);
            ValoracionMultiDiciplinar = new ValoracionMultiDiciplinar(informeIndividual,informeGrupal,escala,localizacion,aumento,disminucion);
            ValoracionIngreso = new ValoracionIngreso(deportiva,diagnosticoRemision,imagenDiagnostico,caracteristicas,antecedentes);
        }
    }
}
