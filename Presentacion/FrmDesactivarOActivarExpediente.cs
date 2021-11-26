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
    public partial class FrmDesactivarOActivarExpediente : Form
    {
        HistoriaMedicaService _historiaMedicaService;


        public FrmDesactivarOActivarExpediente()
        {
            InitializeComponent();
            OcultarSubMenuIniciar();
            _historiaMedicaService = new HistoriaMedicaService(ConfigConnectionString.ConnectionString);
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
        }

        private void BtnBuscarExpediente_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(RTBuscarExpediente.Text);
                string mensaje = _historiaMedicaService.Modificar(codigo);
                MessageBox.Show(mensaje, "Se modifico con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                DialogResult dr = MessageBox.Show("Este Expediente no se ha encontrado, por favor Intentelo nuevamente", "Mensaje de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void Editar()
        {
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


        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void RTBuscarPaciente_TextChanged(object sender, EventArgs e)
        {
        }
    }
}