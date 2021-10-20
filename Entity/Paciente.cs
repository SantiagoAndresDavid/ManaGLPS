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


        public Paciente(int identificacion, string nombre, string apellido, int edad, int telefono)
        {

            this.Identificacion = identificacion;
            this.Nombre = Nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Telefono = telefono;

        }
    }
}
