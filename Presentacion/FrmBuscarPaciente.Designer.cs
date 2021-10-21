
namespace Presentacion
{
    partial class FrmBuscarPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RTBusquedaPaciente = new System.Windows.Forms.RichTextBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTBusquedaPaciente
            // 
            this.RTBusquedaPaciente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RTBusquedaPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.RTBusquedaPaciente.Location = new System.Drawing.Point(233, 304);
            this.RTBusquedaPaciente.Name = "RTBusquedaPaciente";
            this.RTBusquedaPaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTBusquedaPaciente.Size = new System.Drawing.Size(705, 44);
            this.RTBusquedaPaciente.TabIndex = 0;
            this.RTBusquedaPaciente.Text = "Ingrese el numero de identificacion del paciente";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Image = global::Presentacion.Properties.Resources.Guardar_48;
            this.BtnConsultar.Location = new System.Drawing.Point(995, 290);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(70, 68);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // FrmBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 788);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.RTBusquedaPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarPaciente";
            this.Text = "FrmBuscarPaciente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBusquedaPaciente;
        private System.Windows.Forms.Button BtnConsultar;
    }
}