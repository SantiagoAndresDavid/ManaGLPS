using System;
using System.Windows.Forms;
using Entity;

namespace Presentacion
{
    public partial class FrmMostrarPaciente : Form
    {
        public  Paciente Paciente;
        public FrmMostrarPaciente()
        {
            InitializeComponent();
            
        }

        public FrmMostrarPaciente(Paciente paciente)
        {
            InitializeComponent();
            Paciente = paciente;
            llenarCampos();
        }

        public void llenarCampos()
        {
            TXTNombre.Text = Paciente.Nombre;
            TXTApellido.Text = Paciente.Apellido;
            TXTIdentidad.Text = Convert.ToString(Paciente.Identificacion);
            TXTTelefono.Text = Convert.ToString(Paciente.Telefono);
            TXTAfiliacion.Text = Paciente.Afiliacion;
            TXTEdad.Text = Convert.ToString(Paciente.Edad);
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
