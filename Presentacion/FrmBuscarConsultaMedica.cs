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
    public partial class FrmBuscarConsultaMedica : Form
    {

        ConsultaService _consultaService;
        public FrmBuscarConsultaMedica()
        {
            InitializeComponent();
            OcultarSubMenuIniciar();
            _consultaService = new ConsultaService(ConfigConnectionString.ConnectionString);
        }

        private void OcultarSubMenuIniciar()
        {
            RTBuscarConsulta.Visible = false;
            BtnBuscarConsulta.Visible = false;
            PctConsulta.Visible = false;
            RTBusquedaExpediente.Visible = true;
            BtnGuardarConsultaExpediente.Visible = true;
            PctExpediente.Visible = true;
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
        private bool ValidarCamposPaciente()
        {

            bool ok = true;
            if (RTBuscarConsulta.Text.Equals("Ingrese el codigo del Paciente") || RTBuscarConsulta.Text.Equals(""))
            {
                ok = false;
                errorProvider1.SetError(RTBuscarConsulta, "Estes campo esta vacio, por favor ingrese un codigo");
            }
            else
            {
                errorProvider1.SetError(RTBuscarConsulta, "");
            }


            return ok;
        }
        private bool ValidarCampoExpediente()
        {
            bool ok = true;
            if (RTBusquedaExpediente.Text.Equals("Ingrese el codigo del Expediente") || RTBusquedaExpediente.Text.Equals(""))
            {
                ok = false;
                errorProvider1.SetError(RTBusquedaExpediente, "este campo esta vacio por favor ingrse un codigo");
            }
            else
            {
                errorProvider1.SetError(RTBusquedaExpediente, "");
            }
            return ok;
        }

        private void RTBuscarPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardarConsultaPaciente_Click(object sender, EventArgs e)
        {
            ValidarCamposPaciente();
  
                RTBuscarConsulta.Visible = false;
                BtnBuscarConsulta.Visible = false;
                PctConsulta.Visible = false;
                RTBusquedaExpediente.Visible = false;
                BtnGuardarConsultaExpediente.Visible = false;
                PctExpediente.Visible = false;
                ConsultaMedica consulta =_consultaService.BuscarConsultaMedica(Convert.ToInt32(RTBusquedaExpediente.Text),Convert.ToInt32(RTBuscarConsulta.Text));
                Abrir(new FrmMostrarConsultaMedica(consulta));

        }

        private void RTBusquedaExpediente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardarConsultaExpediente_Click(object sender, EventArgs e)
        {
            ValidarCampoExpediente();
 
                RTBusquedaExpediente.Visible = false;
                BtnGuardarConsultaExpediente.Visible = false;
                PctExpediente.Visible = false;
                RTBuscarConsulta.Visible = true;
                BtnBuscarConsulta.Visible = true;
                PctConsulta.Visible = true;
              
            

        }

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RTBuscarPaciente_Enter(object sender, EventArgs e)
        {
            if (RTBuscarConsulta.Text == "Ingrese el codigo de la Consulta")
            {
                RTBuscarConsulta.Text = "";
                RTBuscarConsulta.ForeColor = Color.Black;
                RTBuscarConsulta.Font = new Font(RTBuscarConsulta.Font, FontStyle.Regular);
            }
        }

        private void RTBuscarPaciente_Leave(object sender, EventArgs e)
        {
            if (RTBuscarConsulta.Text == "")
            {
                RTBuscarConsulta.Text = "Ingrese el codigo de la Consulta";
                RTBuscarConsulta.ForeColor = Color.DimGray;
            }
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

        private void RTBusquedaExpediente_Leave(object sender, EventArgs e)
        {
            if (RTBusquedaExpediente.Text == "")
            {
                RTBusquedaExpediente.Text = "Ingrese el codigo del Expediente";
                RTBusquedaExpediente.ForeColor = Color.DimGray;
            }
        }
    }
}
