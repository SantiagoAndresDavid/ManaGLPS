using BLL;
using Entity;
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
    public partial class FrmBuscarExpediente : Form
    {
        HistoriaMedicaService _historiaMedicaService;
        public FrmBuscarExpediente()
        {
            InitializeComponent();
            _historiaMedicaService = new HistoriaMedicaService(ConfigConnectionString.ConnectionString);
        }

        private void RTBusquedaExpediente_TextChanged(object sender, EventArgs e)
        {
            
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

        private bool ValidarCampos()
        {

            bool ok = true;
            if (RTBusquedaExpediente.Text == "Ingrese el codigo del Expediente" || RTBusquedaExpediente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(RTBusquedaExpediente, "Este campo esta vacio, Por favor ingrese un codigo");

            }
            else
            {
                errorProvider1.SetError(RTBusquedaExpediente, "");
            }
            return ok;
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            HistoriaMedica historiaMedica = _historiaMedicaService.Buscar(Convert.ToInt32(RTBusquedaExpediente.Text));
            Abrir(new FrmMostrarExpediente(historiaMedica));
            RTBusquedaExpediente.Visible = false;
            BtnGuardar.Visible = false;
            PctPaciente.Visible = false;



        }

        private void RTBusquedaExpediente_Enter(object sender, EventArgs e)
        {
            if (RTBusquedaExpediente.Text == "Ingrese el codigo del Expediente")
            {
                RTBusquedaExpediente.Text = "";
                RTBusquedaExpediente.ForeColor = Color.Black;
                RTBusquedaExpediente.Font = new Font(RTBusquedaExpediente.Font, FontStyle.Regular);

            }
        }

        private void RTBusquedaPaciente_Leave(object sender, EventArgs e)
        {
            if (RTBusquedaExpediente.Text == "")
            {
                RTBusquedaExpediente.Text = "Ingrese el codigo del Expediente";
                RTBusquedaExpediente.ForeColor = Color.DimGray;
                RTBusquedaExpediente.Font = new Font(RTBusquedaExpediente.Font, FontStyle.Italic);
            }
        }

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
