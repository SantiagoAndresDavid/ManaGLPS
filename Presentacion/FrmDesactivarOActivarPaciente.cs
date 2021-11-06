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
    public partial class FrmDesactivarOActivarPaciente : Form
    {
        public FrmDesactivarOActivarPaciente()
        {
            InitializeComponent();
        }


        private void BtnBuscarExpediente_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OK;
            if (RTBuscarExpediente.Text == "1234")
            {
                DialogResult dr = MessageBox.Show("Se ha Desactivado Correctamente el paciente correctamente", "Mensaje de Informacion", botones, MessageBoxIcon.Information);
            }
            else
            {

                DialogResult dr = MessageBox.Show("Este paciente no se ha encontrado, por favor Intentelo nuevamente", "Mensaje de Informacion", botones, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    RTBuscarExpediente.Text = ""; 
                }
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

        private void RTBuscarExpediente_Enter(object sender, EventArgs e)
        {
            if (RTBuscarExpediente.Text == "Ingrese el codigo del Expediente")
            {
                RTBuscarExpediente.Text = "";
                RTBuscarExpediente.ForeColor = Color.Black;
            }
        }
    }
}
