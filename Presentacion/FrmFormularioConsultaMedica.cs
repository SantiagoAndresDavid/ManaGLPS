using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class FrmFormularioConsultaMedica : Form
    {
        ConsultaMedica consulta = new ConsultaMedica();
        ConsultaService _consultaService;
        int CodigoHistoriaMedica;
        string ruta = "";
        IList<CIE> ListCIE { get; set; }

        public FrmFormularioConsultaMedica(int codigoHistoriaMedica)
        {
            InitializeComponent();
            _consultaService = new ConsultaService(ConfigConnectionString.ConnectionString);
            CodigoHistoriaMedica = codigoHistoriaMedica;
            ListCIE = new List<CIE>();
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
        }

        private void BtnGuarda2_Click(object sender, EventArgs e)
        {
            string estado = "Activo";
            int fase = ((int) NMFaseTratamiento.Value);
            DateTime fechaCreada = DTPFechaCreada.Value.Date;
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
            consulta.FechaCreada = fechaCreada;
            consulta.Medicacion = new Medicacion(prescripcion, rehabilitacion);
            consulta.ValoracionMultiDiciplinar = new ValoracionMultiDiciplinar(informeIndividual, informeGrupal, escala,
                localizacion, aumento, disminucion);
            consulta.ValoracionIngreso = new ValoracionIngreso(deportiva, diagnosticoRemision, imagenDiagnostico,
                caracteristicas, antecedentes);

            string observacionesExtra = TextObservacionesExtra.Text;
            consulta.Diagnostico = new Diagnostico(observacionesExtra);
            foreach (CIE cie in ListCIE)
            {
                consulta.Diagnostico.AgregarCIE(cie);
            }

            string mensaje = _consultaService.Guardar(consulta, CodigoHistoriaMedica);


            MessageBox.Show(mensaje, "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuardarCIE_Click(object sender, EventArgs e)
        {
            string codigoCIE = TXTCodigo.Text;
            string descripcionCIE = TXTDescripcionCIE.Text;
            CIE cie = new CIE(codigoCIE, descripcionCIE);
            ListCIE.Add(cie);
            TXTCodigo.Text = "";
            TXTDescripcionCIE.Text = "";
        }

        public int Escala()
        {
            if (RBESinDolor.Checked)
            {
                return 0;
            }

            if (RBELeve.Checked)
            {
                return 1;
            }

            if (RBEModerado.Checked)
            {
                return 2;
            }

            if (RBESevero.Checked)
            {
                return 3;
            }

            if (RBEMuySevero.Checked)
            {
                return 4;
            }

            if (RBEMaximo.Checked)
            {
                return 5;
            }

            return 0;
        }

        public int FrecuenciaAumento()
        {
            if (RDANada.Checked)
            {
                return 0;
            }

            if (RDAUnPoco.Checked)
            {
                return 1;
            }

            if (RDAPoco.Checked)
            {
                return 2;
            }

            if (RDAMedio.Checked)
            {
                return 3;
            }

            if (RDAMucho.Checked)
            {
                return 4;
            }

            if (RDAEnExeso.Checked)
            {
                return 5;
            }

            return 0;
        }

        public int FrecuenciaDisminucion()
        {
            if (RDDNada.Checked)
            {
                return 0;
            }

            if (RDDUnPoco.Checked)
            {
                return 1;
            }

            if (RDDPoco.Checked)
            {
                return 2;
            }

            if (RDDMedio.Checked)
            {
                return 3;
            }

            if (RDDMucho.Checked)
            {
                return 4;
            }

            if (RDDEnExeso.Checked)
            {
                return 5;
            }

            return 0;
        }


        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Imagen = new OpenFileDialog();
            if (Imagen.ShowDialog() == DialogResult.OK)
            {
                ruta = Imagen.FileName;
            }
        }
    }
}