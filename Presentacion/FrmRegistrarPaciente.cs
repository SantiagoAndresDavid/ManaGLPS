using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class FrmRegistrarPaciente : Form
    {
        PacienteService pacienteService;

        public FrmRegistrarPaciente()
        {
            InitializeComponent();
            pacienteService = new PacienteService(ConfigConnectionString.ConnectionString);
            LlenarTabla();
        }

        public void LlenarTabla()
        {
            DGVPaciente.DataSource = pacienteService.BuscarPacientes();
        }


        public void BorrarMensaje()
        {
            errorProvider1.SetError(TXTIdentidad, "");
            errorProvider1.SetError(TXTNombre, "");
            errorProvider1.SetError(TXTApellido, "");
            errorProvider1.SetError(TXTEdad, "");
            errorProvider1.SetError(TXTTelefono, "");
            errorProvider1.SetError(TXTDireccion, "");

        }
        

        private bool ValidarCampos()
        {
            bool ok = true;
            if (TXTDireccion.Text.Equals(""))
            {
                ok = false;
                errorProvider1.SetError(TXTDireccion, "Este campo se encuentra vacio por favor Ingrese una Direccion");
            
            }
            else 
            {
                BorrarMensaje();
            }
            if (TXTIdentidad.Text.Equals("")) 
            {
                ok = false;
                errorProvider1.SetError(TXTIdentidad, "Este campo se encuentra vacio, por favor ingrese una identificacion");
            
            }
            else 
            {
                BorrarMensaje();
            }
            if (TXTNombre.Text.Equals("")) 
            {
                ok = false;
                errorProvider1.SetError(TXTNombre, "Este campo se encuentra vacio, por favor ingrese un nombre ");
            
            }
            else 
            {
                BorrarMensaje();
            
            }
            if (TXTApellido.Text.Equals("")) 
            {
                ok = false;
                errorProvider1.SetError(TXTApellido, "Este campo se encuentra vacio, por favor ingrese los apellidos");
            
            }
            else 
            {
                BorrarMensaje();
            }
            if (TXTEdad.Text.Equals("")) 
            {
                ok = false;
                errorProvider1.SetError(TXTEdad, "Este campo se encuentra vacio, por favor ingrese la edad");
            }
            else 
            {
                BorrarMensaje();
            }
            if(TXTTelefono.Text.Equals(""))
            {
                ok = false;
                errorProvider1.SetError(TXTTelefono, "Este campo se encuentra vacio, por favor ingrese el telefono");
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
            Paciente paciente = new Paciente();
            paciente.Identificacion = Convert.ToInt32(TXTIdentidad.Text);
            paciente.Nombre = TXTNombre.Text;
            paciente.Apellido = TXTApellido.Text;
            paciente.Edad = Convert.ToInt32(TXTEdad.Text);
            paciente.Telefono = Convert.ToInt32(TXTTelefono.Text);
            paciente.Afiliacion = "Activa";
            string mensaje =  pacienteService.Guardar(paciente);
            MessageBox.Show(mensaje, "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextIdentificacion_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(TXTIdentidad.Text, out num))
            {
                errorProvider1.SetError(TXTIdentidad, "Solo se permite valores numericos");
            }
            else
            {
                errorProvider1.SetError(TXTIdentidad, "");
            }
        }

        private void TextNombre_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (int.TryParse(TXTNombre.Text, out num))
            {
                errorProvider1.SetError(TXTNombre, "Solo se permite valores Letra");
            }
            else
            {
                errorProvider1.SetError(TXTNombre, "");
            }
        }

        private void TextApellido_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (int.TryParse(TXTApellido.Text, out num))
            {
                errorProvider1.SetError(TXTApellido, "Solo se permite valores Letra");
            }
            else
            {
                errorProvider1.SetError(TXTApellido, "");
            }
        }

        private void TextEdad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(TXTEdad.Text, out num))
            {
                errorProvider1.SetError(TXTEdad, "Solo se permite valores numericos");
            }
            else
            {
                errorProvider1.SetError(TXTEdad, "");
            }
        }

        private void TextTelefono_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(TXTTelefono.Text, out num))
            {
                errorProvider1.SetError(TXTTelefono, "Solo se permite valores numericos");
            }
            else
            {
                errorProvider1.SetError(TXTTelefono, "");
            }
        }



    }
}
