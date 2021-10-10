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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            OcultarSubMenuIniciar();
        }

        private void OcultarSubMenuIniciar()
        {
            PnlSubMenuAgregar.Visible = false;
            PnlSubMenuConsultar.Visible = false;
            PnlSubMenuModificar.Visible = false;
            PnlSubMenuActivarDesactivar.Visible = false;

        }
        private void OcultarSubMenus()
        {
            if (PnlSubMenuAgregar.Visible == true)
                PnlSubMenuAgregar.Visible = false;
            if (PnlSubMenuConsultar.Visible == true)
                PnlSubMenuConsultar.Visible = false;
            if (PnlSubMenuModificar.Visible == true)
                PnlSubMenuModificar.Visible = false;
            if (PnlSubMenuActivarDesactivar.Visible == true)
                PnlSubMenuActivarDesactivar.Visible = false;
        }


        private void MostrarSubMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenus();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Abrir(object formHija)
        {
            if (this.PnlContenedor.Controls.Count > 0)
                this.PnlContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(fh);
            this.PnlContenedor.Tag = fh;
            fh.Show();

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnlSubMenuAgregar);
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnlSubMenuConsultar);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnlSubMenuModificar);
        }

        private void btnActivarDesactivar_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnlSubMenuActivarDesactivar);
        }


        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Visible = false;
        }

        private void PctCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int LX, LY;
        private void PctMaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            PctMaximizar.Visible = false;
            PctRestaurar.Visible = true;
        }

        private void PctRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1501, 862);
            this.Location = new Point(LX, LY);
            PctRestaurar.Visible = false;
            PctMaximizar.Visible = true;
        }

        private void PctMinimizar_Click(object sender, EventArgs e)
        {
            PctRestaurar.Visible = true;
            PctMaximizar.Visible = false;
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
