using Entity;
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
    public partial class FrmMostrarExpediente : Form
    {
        HistoriaMedica HistoriaMedica;
        public FrmMostrarExpediente(HistoriaMedica historiaMedica)
        {
            InitializeComponent();
            HistoriaMedica = historiaMedica;
            llenarCampos();
        }

        public void llenarCampos()
        {
            TXTTitulo.Text = HistoriaMedica.Titutlo;
            TXTEstado.Text = HistoriaMedica.Estado;
            DTFechaCreacion.Value = HistoriaMedica.FechaDeCreacion;
            DTPFechaFinalizacion.Value = HistoriaMedica.FechaDeFinalizacion;
            DTPUlitmaEdicion.Value = HistoriaMedica.UltimaFechaDeEdicion;
        }





    }
}
