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

        private void RTBuscarPaciente_Leave(object sender, EventArgs e)
        {
            if (RTBuscarPaciente.Text == "")
            {
                RTBuscarPaciente.Text = "Ingrese el codigo del Paciente";
                RTBuscarPaciente.ForeColor = Color.DimGray;
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

        private void BtnBuscarExpediente_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OK;
            if (RTBuscarPaciente.Text == "1234")
            {
                DialogResult dr = MessageBox.Show("Se ha Desactivado Correctamente la Cita medica correctamente", "Mensaje de Informacion", botones, MessageBoxIcon.Information);
            }
            else
            {

                DialogResult dr = MessageBox.Show("Este paciente no se ha encontrado, por favor Intentelo nuevamente", "Mensaje de Informacion", botones, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    RTBuscarPaciente.Text = ""; 
                }
            }
        }
    }
}
