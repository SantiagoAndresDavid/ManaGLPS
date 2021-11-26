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
    public partial class FrmMostrarConsultaMedica : Form
    {
        

        public FrmMostrarConsultaMedica(ConsultaMedica consultaMedica)
        {
            InitializeComponent();
            llenarCampos(consultaMedica);
            llenarTabla(consultaMedica.Diagnostico.CIE); 

        }

        public void llenarCampos(ConsultaMedica consulta)
        {
            TXTDiagnosticoRemision.Text = consulta.ValoracionIngreso.DiagnosticoRemision;
            DTPFechaCreacion.Value = consulta.FechaCreada;
            TRDeportividad.Text = consulta.ValoracionIngreso.Deportiva;
            TRAntecedentes.Text = consulta.ValoracionIngreso.Lesion.Antecedentes;
            PBImagen.Image = Image.FromFile(consulta.ValoracionIngreso.ImagenDiagnostico);
            TXTInformeIndividual.Text = consulta.ValoracionMultiDiciplinar.InformeIndividual;
            TXTInformeGrupal.Text = consulta.ValoracionMultiDiciplinar.InformeGrupal;
            TXTLocalizacion.Text = consulta.ValoracionMultiDiciplinar.CategoriaEvaluacion.Localizacion;
            Escala(consulta.ValoracionMultiDiciplinar.CategoriaEvaluacion.EscalaDolor);
            FrecuenciaAumento(consulta.ValoracionMultiDiciplinar.CategoriaEvaluacion.FrecuenciaAumento);
            FrecuenciaDisminucion(consulta.ValoracionMultiDiciplinar.CategoriaEvaluacion.FrecuenciaDisminucion);
            Antecedentes(consulta.ValoracionIngreso.Lesion.Antecedentes);
            TXTCaracteristicas.Text = consulta.ValoracionIngreso.Lesion.Caracteristicas;
            TextObservacionesExtra.Text = consulta.Diagnostico.ObservacionesExtra;
            llenarTabla(consulta.Diagnostico.CIE);
            NMFaseTratamiento.Value = consulta.FaseTratamiento;
            TXTPrescripcion.Text = consulta.Medicacion.Prescripcion;
            TXTRehabilitacion.Text = consulta.Medicacion.Rehabilitacion;
        }

        public void Antecedentes(string antecedente)
        {
            switch(antecedente){

                case "Ninguno":
                    CLHAntecedentes.SetItemChecked(0, true);
                    break;
                case "Diabetes":
                    CLHAntecedentes.SetItemChecked(1, true);
                    break;
                case "Alergias":
                    CLHAntecedentes.SetItemChecked(2, true);
                    break;
                case "HTA":
                    CLHAntecedentes.SetItemChecked(3, true);
                    break;
                case "Transfuciones":
                    CLHAntecedentes.SetItemChecked(4, true);
                    break;
                case "Accidente":
                    CLHAntecedentes.SetItemChecked(5, true);
                    break;
                case "Cancer":
                    CLHAntecedentes.SetItemChecked(6, true);
                    break;
                case "Enf.Reumat.":
                    CLHAntecedentes.SetItemChecked(7, true);
                    break;
                case "Fracturas":
                    CLHAntecedentes.SetItemChecked(8, true);
                    break;
                case "Cardiopatias":
                    CLHAntecedentes.SetItemChecked(9, true);
                    break;
                case "Cirugias":
                    CLHAntecedentes.SetItemChecked(10, true);
                    break;
            }          
        }

        public void Escala(int escala)
        {
            switch (escala)
            {
                case 0:
                    RBESinDolor.Checked = true;
                    break;
                case 1:
                    RBELeve.Checked = true;
                    break;
                case 2:
                    RBEModerado.Checked = true;
                    break;
                case 3:
                    RBESevero.Checked = true;
                    break;
                case 4:
                    RBEMuySevero.Checked = true;
                    break;
                 case 5:
                    RBEMaximo.Checked = true;
                    break;

            }
        }

        public void FrecuenciaAumento(int escala)
        {

            switch (escala)
            {
                case 0:
                    RDANada.Checked = true;
                    break;
                case 1:
                    RDAUnPoco.Checked = true;
                    break;
                case 2:
                    RDAUnPoco.Checked = true;
                    break;
                case 3:
                    RDAPoco.Checked = true;
                    break;
                case 4:
                    RDAMedio.Checked = true;
                    break;
                case 5:
                    RDAEnExeso.Checked = true;
                    break;

            }
        }

        public void FrecuenciaDisminucion(int escala)
        {
            switch (escala)
            {
                case 0:
                    RDDNada.Checked = true;
                    break;
                case 1:
                    RDDUnPoco.Checked = true; 
                    break;
                case 2:
                    RDDPoco.Checked = true;
                    break;
                case 3:
                    RDDMedio.Checked = true;
                    break;
                case 4:
                    RDDMucho.Checked = true;
                    break;
                case 5:
                    RDDEnExeso.Checked = true;
                    break;

            }
            
        }


        public void llenarTabla(IList<CIE> CIE)
        {
            DTGCIE.DataSource = CIE;
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
