using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmRegistrarPaciente : Form
    {
        public FrmRegistrarPaciente()
        {
            InitializeComponent();
        }

        public void BorrarMensaje()
        {
            errorProvider1.SetError(TextIdentificacion, "");
            errorProvider1.SetError(TextNombre, "");
            errorProvider1.SetError(TextApellido, "");
            errorProvider1.SetError(TextEdad, "");
            errorProvider1.SetError(TextTelefono, "");
            errorProvider1.SetError(TextDireccion, "");

        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (TextDireccion.Text.Equals(""))
            {
                ok = false;
                errorProvider1.SetError(TextDireccion, "Este campo se encuentra vacio por favor Ingrese una Direccion");
            
            }
            else 
            {
                BorrarMensaje();
            }
            if (TextIdentificacion.Text.Equals("")) 
            {
                ok = false;
                errorProvider1.SetError(TextIdentificacion, "Este campo se encuentra vacio, por favor ingrese una identificacion");
            
            }
            else 
            {
                BorrarMensaje();
            }
            if (TextNombre.Text.Equals("")) 
            {
                ok = false;
                errorProvider1.SetError(TextNombre, "Este campo se encuentra vacio, por favor ingrese un nombre ");
            
            }
            else 
            {
                BorrarMensaje();
            
            }
            if (TextApellido.Text.Equals("")) 
            {
                ok = false;
                errorProvider1.SetError(TextApellido, "Este campo se encuentra vacio, por favor ingrese los apellidos");
            
            }
            else 
            {
                BorrarMensaje();
            }
            if (TextEdad.Text.Equals("")) 
            {
                ok = false;
                errorProvider1.SetError(TextEdad, "Este campo se encuentra vacio, por favor ingrese la edad");
            }
            else 
            {
                BorrarMensaje();
            }
            if(TextTelefono.Text.Equals(""))
            {
                ok = false;
                errorProvider1.SetError(TextTelefono, "Este campo se encuentra vacio, por favor ingrese el telefono");
            }
            else
            {
                BorrarMensaje();
            }
            return ok;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void TextIdentificacion_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(TextIdentificacion.Text, out num))
            {
                errorProvider1.SetError(TextIdentificacion, "Solo se permite valores numericos");
            }
            else
            {
                errorProvider1.SetError(TextIdentificacion, "");
            }
        }

        private void TextNombre_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (int.TryParse(TextNombre.Text, out num))
            {
                errorProvider1.SetError(TextNombre, "Solo se permite valores Letra");
            }
            else
            {
                errorProvider1.SetError(TextNombre, "");
            }
        }

        private void TextApellido_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (int.TryParse(TextApellido.Text, out num))
            {
                errorProvider1.SetError(TextApellido, "Solo se permite valores Letra");
            }
            else
            {
                errorProvider1.SetError(TextApellido, "");
            }
        }

        private void TextEdad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(TextEdad.Text, out num))
            {
                errorProvider1.SetError(TextEdad, "Solo se permite valores numericos");
            }
            else
            {
                errorProvider1.SetError(TextEdad, "");
            }
        }

        private void TextTelefono_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(TextTelefono.Text, out num))
            {
                errorProvider1.SetError(TextTelefono, "Solo se permite valores numericos");
            }
            else
            {
                errorProvider1.SetError(TextTelefono, "");
            }
        }
    }
}
