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
    public partial class FrmLogin : Form
    {
        UsuarioService _UsuarioService;
        public FrmLogin()
        {
            InitializeComponent();
            _UsuarioService = new UsuarioService(ConfigConnectionString.ConnectionString);
        }

        private void PctCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PctMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Text == "USUARIO")
            {
                textUsuario.Text = "";
                textUsuario.ForeColor = Color.Black;
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                textUsuario.Text = "USUARIO";
                textUsuario.ForeColor = Color.DimGray;
            }
        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (textContraseña.Text == "CONTRASEÑA")
            {
                textContraseña.Text = "";
                textContraseña.ForeColor = Color.Black;
                textContraseña.UseSystemPasswordChar = true;
            }
        }

        private void textContraseña_Leave(object sender, EventArgs e)
        {
            if (textContraseña.Text == "")
            {
                textContraseña.Text = "CONTRASEÑA";
                textContraseña.ForeColor = Color.DimGray;
                textContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = _UsuarioService.BuscarPorNombre(textUsuario.Text);
            
            if (usuario.NombreDeUsuario.Equals(textUsuario.Text))
            {
                if (usuario.Contraseña.Equals(textContraseña.Text))
                {
                    this.Hide();
                    FrmBienvenida bienvenida = new FrmBienvenida();
                    Form menu = new FrmPrincipal();
                    this.SetVisibleCore(false);
                    menu.Show();
                }
            }
        }
    }
}
