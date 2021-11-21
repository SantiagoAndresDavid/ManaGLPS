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
using Entity;

namespace Presentacion
{
    public partial class FrmFormularioExpediente : Form
    {
        HistoriaMedicaService historiaMedicaService;

        public FrmFormularioExpediente()
        {
            InitializeComponent();
            historiaMedicaService = new HistoriaMedicaService(ConfigConnectionString.ConnectionString);
        }


        private void BtnGuarda2_Click(object sender, EventArgs e)
        {
            HistoriaMedica historiaMedica = new HistoriaMedica();
            historiaMedica.Titutlo = TXTTitulo.Text;
            historiaMedica.FechaDeCreacion = Convert.ToDateTime(DTFechaCreacion.Text);
            historiaMedica.UltimaFechaDeEdicion = DateTime.Now;
            historiaMedica.FechaDeFinalizacion = Convert.ToDateTime(DTPFechaFinalizacion.Text);
            historiaMedica.Estado = "Activo";
            string mensaje = historiaMedicaService.Guardar(historiaMedica);
            MessageBox.Show(mensaje, "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}