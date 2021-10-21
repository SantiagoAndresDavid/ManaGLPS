
namespace Presentacion
{
    partial class FrmBuscarExpediente
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.RTBusquedaExpediente = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Image = global::Presentacion.Properties.Resources.Guardar_48;
            this.BtnGuardar.Location = new System.Drawing.Point(1025, 296);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(70, 68);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Consultar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // RTBusquedaExpediente
            // 
            this.RTBusquedaExpediente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RTBusquedaExpediente.ForeColor = System.Drawing.Color.DimGray;
            this.RTBusquedaExpediente.Location = new System.Drawing.Point(263, 310);
            this.RTBusquedaExpediente.Name = "RTBusquedaExpediente";
            this.RTBusquedaExpediente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTBusquedaExpediente.Size = new System.Drawing.Size(705, 44);
            this.RTBusquedaExpediente.TabIndex = 2;
            this.RTBusquedaExpediente.Text = "Ingrese el numero de codigo del expediente";
            // 
            // FrmBuscarExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 788);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.RTBusquedaExpediente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarExpediente";
            this.Text = "FrmBuscarExpediente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.RichTextBox RTBusquedaExpediente;
    }
}