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
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
