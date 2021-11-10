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
using Entity;

namespace Presentacion
{
    public partial class FrmFormularioConsultaMedica : Form
    {
        OpenFileDialog Imagen = new OpenFileDialog();
        ConsultaMedica Consulta = new ConsultaMedica();

        public FrmFormularioConsultaMedica()
        {
            InitializeComponent();
            BtnEditar.Visible = false;
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        { 
            Imagen.InitialDirectory = "C:\\";
            Imagen.Filter = "Archivos de Imagen (*.jgp)(*.jpeg)|*.jpg;*.jpeng|PNG(*.png)|*.png";
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuarda2_Click(object sender, EventArgs e)
        {

        } 

        public ConsultaMedica Mapear()
        {
            Random random = new Random();
            int codigo = random.Next(1, 9999);
            string estado = "Activo";
            int fase = ((int)NMFaseTratamiento.Value);
            string diagnostico = TXTDiagnostico.Text;

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
            string imagenDiagnostico = this.Imagen.FileName;
            string caracteristicas = TXTCaracteristicas.Text;
            string antecedentes = TXTAntecedentes.Text;

            Consulta.Codigo = codigo;
            Consulta.Estado = estado;
            Consulta.FaseTratamiento = fase;
            Consulta.Temporalidad = new Temporalidad(fechaCreada, ultimaModificacion);
            Consulta.Medicacion = new Medicacion(prescripcion, rehabilitacion);
            Consulta.ValoracionMultiDiciplinar = new ValoracionMultiDiciplinar(informeIndividual, informeGrupal, escala,
                localizacion, aumento, disminucion);
            Consulta.ValoracionIngreso = new ValoracionIngreso(deportiva, diagnosticoRemision, imagenDiagnostico,
                caracteristicas, antecedentes);
            return null;
        }


        private void BtnGuardarCIE_Click(object sender, EventArgs e)
        {
            string codigoCIE = TXTCodigo.Text;
            string descripcionCIE = TXTDescripcionCIE.Text;
            CIE cie = new CIE(codigoCIE,descripcionCIE);
            Consulta.Diagnostico.AgregarCIE(cie);
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

    }
}
