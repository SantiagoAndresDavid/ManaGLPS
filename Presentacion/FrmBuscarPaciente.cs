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
    public partial class FrmBuscarPaciente : Form
    {
        public FrmBuscarPaciente()
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



        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (RTBusquedaExpediente.Text == "1234")
            {
                
                RTBusquedaExpediente.Visible = false;
                BtnGuardar.Visible = false;
                PctPaciente.Visible = false;
                Abrir(new FrmRegistrarPaciente());
            }
            else
            {
                if (!(RTBusquedaExpediente.Text == "1234") && (!(RTBusquedaExpediente.Text == "")) && (!(RTBusquedaExpediente.Text == "Ingrese el codigo del Expediente")))
                {
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    DialogResult dr = MessageBox.Show("Este Expediente no se ha encontrado, por favor Intentelo nuevamente", "Mensaje de Informacion", botones, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        RTBusquedaExpediente.Text = "Ingrese el codigo del Expediente";
                        RTBusquedaExpediente.ForeColor = Color.DimGray;
                        RTBusquedaExpediente.Font = new Font(RTBusquedaExpediente.Font, FontStyle.Italic);
                        RTBusquedaExpediente.Visible = true;
                        BtnGuardar.Visible = true;
                    }
                }

            }
        }

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

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
                RTBusquedaExpediente.Font = new Font(RTBusquedaExpediente.Font, FontStyle.Italic);
            }
        }
    }
}
