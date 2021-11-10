﻿using System;
using System.Collections.Generic;

namespace Entity
{
    public class ConsultaMedica
    {
        public int Codigo { get; set; }
        public string Estado { get; set; }
        public int FaseTratamiento { get; set; }
        public Diagnostico Diagnostico { get; set; }
        public Temporalidad Temporalidad { get; set; }
        public Medicacion Medicacion { get; set; }
        public ValoracionMultiDiciplinar ValoracionMultiDiciplinar { get; set; }
        public ValoracionIngreso ValoracionIngreso { get; set; }


        public ConsultaMedica()
        {

        }
        public ConsultaMedica(int codigo, string estado, int faseTratamiento, string diagnostico, string codigoCIE,
            string descripcionCIE, DateTime fechacreada, DateTime ultimaModificacion, string prescripcion,
            string rehabilitacion, string informeIndividual, string informeGrupal, int escala, string localizacion,
            int aumento, int disminucion, string deportiva, string diagnosticoRemision, string imagenDiagnostico,
            string caracteristicas, string antecedentes)
        {
            Codigo = codigo;
            Estado = estado;
            FaseTratamiento = faseTratamiento;
            Diagnostico = new Diagnostico();
            Temporalidad = new Temporalidad(fechacreada, ultimaModificacion);
            Medicacion = new Medicacion(prescripcion, rehabilitacion);
            ValoracionMultiDiciplinar = new ValoracionMultiDiciplinar(informeIndividual, informeGrupal, escala,
                localizacion, aumento, disminucion);
            ValoracionIngreso = new ValoracionIngreso(deportiva, diagnosticoRemision, imagenDiagnostico,
                caracteristicas, antecedentes);
        }
    }
}