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
    public partial class FrmDesactivarOActivarPaciente : Form
    {
        HistoriaMedicaService _historiaMedicaService;
        PacienteService _PacienteService;
        public FrmDesactivarOActivarPaciente()
        {
            InitializeComponent();
            _historiaMedicaService = new HistoriaMedicaService(ConfigConnectionString.ConnectionString);
            _PacienteService = new PacienteService(ConfigConnectionString.ConnectionString);
        }


        private void BtnBuscarExpediente_Click(object sender, EventArgs e)
        {
            int codigo = _historiaMedicaService.BuscarIdPersona(Convert.ToInt32(RTBuscarExpediente.Text));
            string mensaje = _PacienteService.Modificar(codigo);
            MessageBox.Show(mensaje, "Se modifico con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
