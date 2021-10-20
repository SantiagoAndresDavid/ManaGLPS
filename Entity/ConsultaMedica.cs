using System;

namespace Entity
{
    class CitaMedica
    {
        public int codigo { get; set; }
        public Boolean Estado { get; set; }
        public Diagnostico Diagnostico { get; set; }
        public Temporalidad Temporalidad { get; set; }
        public Medicacion Medicacion { get; set; }
        public ValoracionMultiDiciplinar ValoracionMultiDiciplinar { get; set; }
        public ValoracionIngreso ValoracionIngreso { get; set; }

        public CitaMedica(int codigo, bool estado, Diagnostico diagnostico, Temporalidad temporalidad, Medicacion medicacion, ValoracionMultiDiciplinar valoracionMultiDiciplinar, ValoracionIngreso valoracionIngreso)
        {
            this.codigo = codigo;
            Estado = estado;
            Diagnostico = diagnostico;
            Temporalidad = temporalidad;
            Medicacion = medicacion;
            ValoracionMultiDiciplinar = valoracionMultiDiciplinar;
            ValoracionIngreso = valoracionIngreso;
        }
    }
}
