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
        public FrmBuscarConsultaMedica()
        {
            InitializeComponent();
            OcultarSubMenuIniciar();
        }

        private void OcultarSubMenuIniciar()
        {
            RTBuscarPaciente.Visible = true;
            BtnGuardarConsultaPaciente.Visible = true;
            RTBusquedaExpediente.Visible = false;
            BtnGuardarConsultaExpediente.Visible = false;
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

        private void RTBuscarPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardarConsultaPaciente_Click(object sender, EventArgs e)
        {
            if (RTBuscarPaciente.Text == "1234")
            { 
                RTBuscarPaciente.Visible = false;
                BtnGuardarConsultaPaciente.Visible = false;
                RTBusquedaExpediente.Visible = true;
                BtnGuardarConsultaExpediente.Visible = true;
                

            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("Este paciente no se ha encontrado, por favor Intentelo nuevamente", "Mensaje de Informacion", botones, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    RTBuscarPaciente.Text = "";
                    RTBuscarPaciente.Visible = true;
                    BtnGuardarConsultaPaciente.Visible = true;
                }
            }
        }

        private void RTBusquedaExpediente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardarConsultaExpediente_Click(object sender, EventArgs e)
        {

            if (RTBusquedaExpediente.Text == "1234")
            {
                RTBusquedaExpediente.Visible = false;
                BtnGuardarConsultaExpediente.Visible = false;
                Abrir(new FrmFormularioConsultaMedica());
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("Este expediente no se ha encontrado, por favor Intentelo nuevamente", "Mensaje de Informacion", botones, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    RTBusquedaExpediente.Text = "";
                    RTBusquedaExpediente.Visible = true;
                    BtnGuardarConsultaExpediente.Visible = true;
                }
            }
        }

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RTBuscarPaciente_Enter(object sender, EventArgs e)
        {
            if (RTBuscarPaciente.Text == "Ingrese el codigo del Paciente")
            {
                RTBuscarPaciente.Text = "";
                RTBuscarPaciente.ForeColor = Color.Black;
            }
        }

        private void RTBuscarPaciente_Leave(object sender, EventArgs e)
        {
            if (RTBuscarPaciente.Text == "")
            {
                RTBuscarPaciente.Text = "Ingrese el codigo del Paciente";
                RTBuscarPaciente.ForeColor = Color.DimGray;
            }
        }

        private void RTBusquedaExpediente_Enter(object sender, EventArgs e)
        {
            if (RTBusquedaExpediente.Text == "Ingrese el codigo del Expediente")
            {
                RTBusquedaExpediente.Text = "";
                RTBusquedaExpediente.ForeColor = Color.Black;
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
