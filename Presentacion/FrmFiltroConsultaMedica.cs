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
    public partial class FrmFiltroConsultaMedica : Form
    {
        public FrmFiltroConsultaMedica()
        {
            InitializeComponent();
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
        private void RTBusquedaPaciente_Enter(object sender, EventArgs e)
        {
            if (RTBusquedaeExpediente.Text == "Ingrese el codigo del Expediente")
            {
                RTBusquedaeExpediente.Text = "";
                RTBusquedaeExpediente.ForeColor = Color.Black;
                RTBusquedaeExpediente.Font = new Font(RTBusquedaeExpediente.Font, FontStyle.Regular);
            }
        }

        private void RTBusquedaPaciente_Leave(object sender, EventArgs e)
        {
            if (RTBusquedaeExpediente.Text == "")
            {
                RTBusquedaeExpediente.Text = "Ingrese el codigo del Expediente";
                RTBusquedaeExpediente.ForeColor = Color.DimGray;
            }
        }

        private void FrmFiltroConsultaMedica_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            if (RTBusquedaeExpediente.Text == "1234")
            {
                Abrir(new FrmFormularioConsultaMedica());
                RTBusquedaeExpediente.Visible = false;
                BtnGuardar.Visible = false;
                PctPaciente.Visible = false;
            }
            else
            {
                if (!(RTBusquedaeExpediente.Text == "1234") && (!(RTBusquedaeExpediente.Text == "")) && (!(RTBusquedaeExpediente.Text == "Ingrese el codigo de la Consulta")))
                {
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    DialogResult dr = MessageBox.Show("EstaConsulta no se ha encontrado, por favor Intentelo nuevamente", "Mensaje de Informacion", botones, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        RTBusquedaeExpediente.Text = "Ingrese el codigo de la Consulta ";
                        RTBusquedaeExpediente.ForeColor = Color.DimGray;
                        RTBusquedaeExpediente.Font = new Font(RTBusquedaeExpediente.Font, FontStyle.Italic);
                        RTBusquedaeExpediente.Visible = true;
                        RTBusquedaeExpediente.Visible = true;

                    }
                }
            }
        }
    }
}
