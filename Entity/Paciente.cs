using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Paciente
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public Afiliacion Afiliacion { get; set; }
        public List<HistoriaMediaca> HistoriasMedicas { get; set; }

        public Paciente(int identificacion, string nombre, string apellido, int edad, int telefono, Afiliacion afiliacion, List<HistoriaMediaca> historiasMedicas)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Telefono = telefono;
            Afiliacion = afiliacion;
            HistoriasMedicas = historiasMedicas;
        }

        public void añadirHistotiaMedica(HistoriaMediaca historia)
        {
            HistoriasMedicas.Add(historia);
        }
    }
}
