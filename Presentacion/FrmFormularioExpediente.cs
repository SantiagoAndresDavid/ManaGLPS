using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
namespace Presentacion
{
    public partial class FrmFormularioExpediente : Form
    {
        public FrmFormularioExpediente()
        {
            InitializeComponent();
            BtnEditar.Visible = false;
        }

        
        private void BtnGuardar1_Click(object sender, EventArgs e)
        {
            
        }

        private HistoriaMedica MapearHistoriaMedica()
        {
            HistoriaMedica mapearHistoriaMedica = new HistoriaMedica();
            

            return null;
        }
    }
}
