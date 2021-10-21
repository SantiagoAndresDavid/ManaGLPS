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

        public ConsultaMedica(int codigo, bool estado, int faseTratamiento, Diagnostico diagnostico, Temporalidad temporalidad, Medicacion medicacion, ValoracionMultiDiciplinar valoracionMultiDiciplinar, ValoracionIngreso valoracionIngreso)
        {
            Codigo = codigo;
            Estado = estado;
            FaseTratamiento = faseTratamiento;
            Diagnostico = diagnostico;
            Temporalidad = temporalidad;
            Medicacion = medicacion;
            ValoracionMultiDiciplinar = valoracionMultiDiciplinar;
            ValoracionIngreso = valoracionIngreso;
        }
    }
}
