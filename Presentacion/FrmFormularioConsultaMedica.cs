using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class FrmFormularioConsultaMedica : Form
    {
        ConsultaMedica consulta = new ConsultaMedica(); 
        ConsultaService _consultaService;
        string ruta = ""; 
        public FrmFormularioConsultaMedica()
        {
            InitializeComponent();
            
            _consultaService = new ConsultaService(ConfigConnectionString.ConnectionString);
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Imagen = new OpenFileDialog();
            if (Imagen.ShowDialog() == DialogResult.OK)
            {
                ruta = Imagen.FileName;
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuarda2_Click(object sender, EventArgs e)
        {
            
            string estado = "Activo";
            int fase = ((int)NMFaseTratamiento.Value);
            DateTime fechaCreada = DTPFechaCreada.Value.Date;
            DateTime ultimaModificacion = DTPUltimaModificacion.Value.Date;
            string prescripcion = TXTPrescripcion.Text;
            string rehabilitacion = TXTRehabilitacion.Text;
            string informeIndividual = TXTInformeIndividual.Text;
            string informeGrupal = TXTInformeGrupal.Text;
            int escala = Escala();
            int aumento = FrecuenciaAumento();
            string localizacion = TXTLocalizacion.Text;
            int disminucion = FrecuenciaDisminucion();
            string deportiva = TXTDeportividad.Text;
            string diagnosticoRemision = TXTDiagnostico.Text;
            string imagenDiagnostico = ruta;
            string caracteristicas = TXTCaracteristicas.Text;
            string antecedentes = TXTAntecedentes.Text;
            consulta.Estado = estado;
            consulta.FaseTratamiento = fase;
            consulta.Temporalidad = new Temporalidad(fechaCreada, ultimaModificacion);
            consulta.Medicacion = new Medicacion(prescripcion, rehabilitacion);
            consulta.ValoracionMultiDiciplinar = new ValoracionMultiDiciplinar(informeIndividual, informeGrupal, escala,
                localizacion, aumento, disminucion);
            consulta.ValoracionIngreso = new ValoracionIngreso(deportiva, diagnosticoRemision, imagenDiagnostico,
                caracteristicas, antecedentes);
            
            string mensaje = _consultaService.Guardar(consulta);
            MessageBox.Show(mensaje, "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
        
        private void BtnGuardarCIE_Click(object sender, EventArgs e)
        {
            string codigoCIE = TXTCodigo.Text;
            string descripcionCIE = TXTDescripcionCIE.Text;
            CIE cie = new CIE(codigoCIE,descripcionCIE);
            string observacionesExtra = TextObservacionesExtra.Text;
            consulta.Diagnostico = new Diagnostico(observacionesExtra);
            consulta.Diagnostico.AgregarCIE(cie);
        }

        public int Escala()
        {
            if (RBESinDolor.Checked == true)
            {
                return 0;
            }
            else if (RBELeve.Checked == true)
            {
                return 1;
            }
            else if (RBEModerado.Checked == true)
            {
                return 2;
            }
            else if (RBESevero.Checked == true)
            {
                return 3;
            }
            else if (RBEMuySevero.Checked == true)
            {
                return 4;
            }
            else if (RBEMaximo.Checked == true)
            {
                return 5;
            }
            return 0;
        }

        public int FrecuenciaAumento()
        {
            if (RDANada.Checked == true)
            {
                return 0;
            }
            else if (RDAUnPoco.Checked == true)
            {
                return 1;
            }
            else if (RDAPoco.Checked == true)
            {
                return 2;
            }
            else if (RDAMedio.Checked == true)
            {
                return 3;
            }else if (RDAMucho.Checked == true)
            {
                return 4;
            }else if(RDAEnExeso.Checked == true)
            {
                return 5;
            }
            return 0;
        }

        public int FrecuenciaDisminucion()
        {
            if (RDDNada.Checked == true)
            {
                return 0;
            }
            else if (RDDUnPoco.Checked == true)
            {
                return 1;
            }
            else if (RDDPoco.Checked == true)
            {
                return 2;
            }
            else if (RDDMedio.Checked == true)
            {
                return 3;
            }
            else if (RDDMucho.Checked == true)
            {
                return 4;
            }
            else if (RDDEnExeso.Checked == true)
            {
                return 5;
            }
            return 0;
        }

        private void TXTDiagnostico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
