﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Temporalidad
    {
        public DateTime FechaCreada { get; set; }
        public DateTime UltimaModificacion { get; set; }

        public Temporalidad(DateTime fechaCreada, DateTime ultimaModificacion)
        {
            FechaCreada = fechaCreada;
            UltimaModificacion = ultimaModificacion;
        }
    }
}