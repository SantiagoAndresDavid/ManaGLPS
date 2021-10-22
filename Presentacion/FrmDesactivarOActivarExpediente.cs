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
    public partial class FrmDesactivarOActivarExpediente : Form
    {
        public FrmDesactivarOActivarExpediente()
        {
            InitializeComponent();
            OcultarSubMenuIniciar();
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
            RTBuscarPaciente.Visible = true;
            BtnBuscarPaciente.Visible = true;
            RTBuscarExpediente.Visible = false;
            BtnBuscarExpediente.Visible = false;
        }

        private void BtnBuscarExpediente_Click(object sender, EventArgs e)
        {

            MessageBoxButtons botones = MessageBoxButtons.OK;

            if (RTBuscarExpediente.Text == "1234")
            {
                DialogResult a = MessageBox.Show("Se ha eliminado la Expediente medica", "Mensaje de informacion", botones, MessageBoxIcon.Information);
                if (a == DialogResult.OK)
                {
                    RTBuscarPaciente.Text = "";
                    RTBuscarPaciente.Visible = true;
                    BtnBuscarPaciente.Visible = true;
                    RTBuscarExpediente.Visible = false;
                    BtnBuscarExpediente.Visible = false;
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Este Expediente no se ha encontrado, por favor Intentelo nuevamente", "Mensaje de Informacion", botones, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    RTBuscarPaciente.Text = "";
                    RTBuscarPaciente.Visible = true;
                    BtnBuscarPaciente.Visible = true;
                }
            }
        }

        private void BtnBuscarPaciente_Click_1(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OK;

            if (RTBuscarPaciente.Text == "1234")
            {
                RTBuscarPaciente.Text = "";
                RTBuscarPaciente.Visible = false;
                BtnBuscarPaciente.Visible = false;
                RTBuscarExpediente.Visible = true;
                BtnBuscarExpediente.Visible = true;
            }
            else
            {

                DialogResult dr = MessageBox.Show("Este paciente no se ha encontrado, por favor Intentelo nuevamente", "Mensaje de Informacion", botones, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    RTBuscarPaciente.Text = "";
                    RTBuscarPaciente.Visible = true;
                    BtnBuscarPaciente.Visible = true;
                }
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

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RTBuscarPaciente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
