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

namespace Presentacion
{
    public partial class FrmDesactivarOActivarCitaMedica : Form
    {
        ConsultaService _consultaService;

        public FrmDesactivarOActivarCitaMedica()
        {
            InitializeComponent();
            OcultarSubMenuIniciar();
            _consultaService = new ConsultaService(ConfigConnectionString.ConnectionString);
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

        private void OcultarSubMenuIniciar()
        {
            RTBuscarExpediente.Visible = true;
            BtnBuscarExpediente.Visible = true;
            RTBuscarCitaMedica.Visible = false;
            BtnBuscarCitaMedica.Visible = false;
        }


        private void BtnBuscarCitaMedica_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OK;

            try
            {
                RTBuscarExpediente.Visible = false;
                BtnBuscarExpediente.Visible = false;
                RTBuscarCitaMedica.Visible = false;
                BtnBuscarCitaMedica.Visible = false;
                string xd = _consultaService.ModificarEstado(Convert.ToInt32(RTBuscarExpediente.Text),Convert.ToInt32(RTBuscarCitaMedica.Text));
                DialogResult dr = MessageBox.Show("Se ha ModificadoCorrectamente", "Mensaje de Informacion", botones, MessageBoxIcon.Information);
            }
            catch
            {
                RTBuscarExpediente.Visible = true;
                BtnBuscarExpediente.Visible = true;
                DialogResult dr = MessageBox.Show("Se ha ModificadoCorrectamente" + e , "Mensaje de Informacion", botones, MessageBoxIcon.Information);
            }
        }

        private void BtnBuscarExpediente_Click(object sender, EventArgs e)
        {
            RTBuscarExpediente.Visible = false;
            BtnBuscarExpediente.Visible = false;
            RTBuscarCitaMedica.Visible = true;
            BtnBuscarCitaMedica.Visible = true;
        }


        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void RTBuscarCitaMedica_Leave(object sender, EventArgs e)
        {
            if (RTBuscarCitaMedica.Text == "")
            {
                RTBuscarCitaMedica.Text = "Ingrese el codigo de la Cita Medica";
                RTBuscarCitaMedica.ForeColor = Color.DimGray;
            }
        }

        private void RTBuscarCitaMedica_Enter(object sender, EventArgs e)
        {
            if (RTBuscarCitaMedica.Text == "Ingrese el codigo de la Cita Medica")
            {
                RTBuscarCitaMedica.Text = "";
                RTBuscarCitaMedica.ForeColor = Color.Black;
            }
        }

        private void RTBuscarExpediente_Enter(object sender, EventArgs e)
        {
            if (RTBuscarExpediente.Text == "Ingrese el codigo del Expediente")
            {
                RTBuscarExpediente.Text = "";
                RTBuscarExpediente.ForeColor = Color.Black;
            }
        }

        private void RTBuscarExpediente_Leave(object sender, EventArgs e)
        {
            if (RTBuscarExpediente.Text == "")
            {
                RTBuscarExpediente.Text = "Ingrese el codigo del Expediente";
                RTBuscarExpediente.ForeColor = Color.DimGray;
            }
        }


        private void RTBuscarCitaMedica_TextChanged(object sender, EventArgs e)
        {
        }


        private void RTBuscarExpediente_TextChanged(object sender, EventArgs e)
        {
        }
    }
}