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
    public partial class FrmFormularioConsultaMedica : Form
    {
        public FrmFormularioConsultaMedica()
        {
            InitializeComponent();
            BtnEditar.Visible = false;
        }  

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImagen = new OpenFileDialog();
            getImagen.InitialDirectory = "C:\\";
            getImagen.Filter = "Archivos de Imagen (*.jgp)(*.jpeg)|*.jpg;*.jpeng|PNG(*.png)|*.png";

            if (getImagen.ShowDialog() == DialogResult.OK)
            {
                /*
                 imagen.ImageLocation == getImage.FileName;
                 txtRutaImahen.Text= getImage.FileName
                 */
            }
            else
            {
                MessageBox.Show("No se seleccionaron Archivos ");
            }

        }


        

        
    }
}
