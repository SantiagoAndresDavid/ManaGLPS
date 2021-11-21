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
    public partial class FrmRegistrarUsuario : Form
    {

        UsuarioService usuarioService;

        public FrmRegistrarUsuario()
        {
            InitializeComponent();
            usuarioService = new UsuarioService(ConfigConnectionString.ConnectionString);
        }
        private void TextCorreoElectronico_Enter(object sender, EventArgs e)
        {
            if (TextCorreoElectronico.Text == "usuario@ejemplo.com")
            {
                TextCorreoElectronico.Text = "";
                TextCorreoElectronico.ForeColor = Color.Black;
                TextCorreoElectronico.Font = new Font(TextCorreoElectronico.Font, FontStyle.Regular);
            }
        }

        private void TextCorreoElectronico_Leave(object sender, EventArgs e)
        {
            if (TextCorreoElectronico.Text == "")
            {
                TextCorreoElectronico.Text = "usuario@ejemplo.com";
                TextCorreoElectronico.ForeColor = Color.DimGray;
                TextCorreoElectronico.Font = new Font(TextCorreoElectronico.Font, FontStyle.Italic);
            }
        }

        private void TextNombreDeUsuario_Enter(object sender, EventArgs e)
        {
            if (TextNombreDeUsuario.Text == "Nombre de usuario")
            {
                TextNombreDeUsuario.Text = "";
                TextNombreDeUsuario.ForeColor = Color.Black;
                TextNombreDeUsuario.Font = new Font(TextNombreDeUsuario.Font, FontStyle.Regular);

            }

        }

        private void TextNombreDeUsuario_Leave(object sender, EventArgs e)
        {
            if (TextNombreDeUsuario.Text == "")
            {
                TextNombreDeUsuario.Text = "Nombre de usuario";
                TextNombreDeUsuario.ForeColor = Color.DimGray;
                TextNombreDeUsuario.Font = new Font(TextNombreDeUsuario.Font, FontStyle.Italic);
            }

        }

        private void TextContraseña_Enter(object sender, EventArgs e)
        {
            if (TextContraseña.Text == "Ingresa tu contraseña")
            {
                TextContraseña.Text = "";
                TextContraseña.ForeColor = Color.Black;
                TextContraseña.UseSystemPasswordChar = true;

            }
        }

        private void TextContraseña_Leave(object sender, EventArgs e)
        {
            if (TextContraseña.Text == "")
            {
                TextContraseña.Text = "Ingresa tu contraseña";
                TextContraseña.ForeColor = Color.DimGray;
                TextContraseña.UseSystemPasswordChar = false;
            }
        }

        private void TextConfirmarContraseña_Enter(object sender, EventArgs e)
        {
            if (TextConfirmarContraseña.Text == "Confirma tu contraseña")
            {
                TextConfirmarContraseña.Text = "";
                TextConfirmarContraseña.ForeColor = Color.Black;
                TextConfirmarContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TextConfirmarContraseña_Leave(object sender, EventArgs e)
        {
            if (TextConfirmarContraseña.Text == "")
            {
                TextConfirmarContraseña.Text = "Confirma tu contraseña";
                TextConfirmarContraseña.ForeColor = Color.DimGray;
                TextConfirmarContraseña.UseSystemPasswordChar = false;
            }
        }
        public void BorrarMensaje()
        {
            errorProvider1.SetError(TextCorreoElectronico, "");
            errorProvider1.SetError(TextNombreDeUsuario, "");
            errorProvider1.SetError(CmbTipoDeUsuario, "");
            errorProvider1.SetError(TextContraseña, "");
            errorProvider1.SetError(TextConfirmarContraseña, "");

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (TextCorreoElectronico.Text.Equals("usuario@ejemplo.com"))
            {
                ok = false;
                errorProvider1.SetError(TextCorreoElectronico, "Ingrese Correo Electronico");

            }
            else
            {
                BorrarMensaje();
            }
            if (TextNombreDeUsuario.Text.Equals("Nombre de usuario"))
            {
                ok = false;
                errorProvider1.SetError(TextNombreDeUsuario, "Ingrese un Nombre de usuario");

            }
            else
            {
                BorrarMensaje();
            }
            if (CmbTipoDeUsuario.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(CmbTipoDeUsuario, "Selecione una opcion");

            }
            else
            {
                BorrarMensaje();
            }
            if (TextContraseña.Text.Equals("Ingresa tu contraseña"))
            {
                ok = false;
                errorProvider1.SetError(TextContraseña, "Ingrese una contraseña");

            }
            else
            {
                BorrarMensaje();
            }
            if (TextConfirmarContraseña.Text.Equals("Confirma tu contraseña"))
            {
                ok = false;
                errorProvider1.SetError(TextConfirmarContraseña, "las contraseñas no inciden");

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
            string correo = TextCorreoElectronico.Text;
            string nombreUsuario = TextNombreDeUsuario.Text;
            string rol = CmbTipoDeUsuario.Text;
            string contraseña = TextContraseña.Text;
            Usuario usuario = new Usuario(nombreUsuario,contraseña,rol,correo);
            string mensaje = usuarioService.Guardar(usuario);
            MessageBox.Show(mensaje, "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        

        private void TextNombreDeUsuario_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (int.TryParse(TextNombreDeUsuario.Text, out num))
            {
                errorProvider1.SetError(TextNombreDeUsuario, "Solo se permite Letra");
            }
            else
            {

                errorProvider1.SetError(TextNombreDeUsuario, "");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
