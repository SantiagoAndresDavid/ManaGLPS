using System;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class FrmFormularioExpediente : Form
    {
        HistoriaMedicaService _historiaMedicaService;
        PacienteService _PacienteServices;
        Paciente paciente;


        public FrmFormularioExpediente()
        {
            InitializeComponent();
            _historiaMedicaService = new HistoriaMedicaService(ConfigConnectionString.ConnectionString);
            _PacienteServices = new PacienteService(ConfigConnectionString.ConnectionString);
        }
        
        private void BtnGuarda2_Click(object sender, EventArgs e)
        {
            HistoriaMedica historiaMedica = new HistoriaMedica();
            historiaMedica.Titutlo = TXTTitulo.Text;
            historiaMedica.FechaDeCreacion = Convert.ToDateTime(DTFechaCreacion.Text);
            historiaMedica.UltimaFechaDeEdicion = DateTime.Now;
            historiaMedica.FechaDeFinalizacion = Convert.ToDateTime(DTPFechaFinalizacion.Text);
            historiaMedica.Estado = "Activo";
            historiaMedica.Paciente = new Paciente();
            historiaMedica.Paciente.Identificacion = paciente.Identificacion;
            string mensaje = _historiaMedicaService.Guardar(historiaMedica);
            MessageBox.Show(mensaje, "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
           paciente =  _PacienteServices.buscarPaciente(Convert.ToInt32(TXTIdentificacionPaciente.Text));
           TXTNombrePaciente.Text =  paciente.Nombre;
      
        }
    }
}