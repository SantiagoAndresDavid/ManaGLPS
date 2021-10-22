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
        public FrmBuscarExpediente()
        {
            InitializeComponent();

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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (RTBusquedaPaciente.Text == "1234")
            {
                Abrir(new FrmRegistrarPaciente());
                RTBusquedaPaciente.Visible = false;
                BtnGuardar.Visible = false;
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("Este paciente no se ha encontrado, por favor Intentelo nuevamente","Mensaje de Informacion", botones, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    RTBusquedaPaciente.Text = "";
                    RTBusquedaPaciente.Visible = true;
                    BtnGuardar.Visible = true;
                }
            }
        }
 
        private void RTBusquedaExpediente_Enter(object sender, EventArgs e)
        {
            if (RTBusquedaPaciente.Text == "Ingrese el codigo del paciente")
            {
                RTBusquedaPaciente.Text = "";
                RTBusquedaPaciente.ForeColor = Color.Black;
            }
        }

        private void RTBusquedaPaciente_Leave(object sender, EventArgs e)
        {
            if (RTBusquedaPaciente.Text == "")
            {
                RTBusquedaPaciente.Text = "Ingrese el codigo del paciente";
                RTBusquedaPaciente.ForeColor = Color.DimGray;
            }
        }
    }
}
