
namespace Presentacion
{
    partial class FrmFiltroConsultaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltroConsultaMedica));
            this.PctPaciente = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.RTBusquedaeExpediente = new System.Windows.Forms.RichTextBox();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PctPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // PctPaciente
            // 
            this.PctPaciente.BackColor = System.Drawing.Color.White;
            this.PctPaciente.Image = global::Presentacion.Properties.Resources.Usuario;
            this.PctPaciente.Location = new System.Drawing.Point(839, 347);
            this.PctPaciente.Name = "PctPaciente";
            this.PctPaciente.Size = new System.Drawing.Size(55, 36);
            this.PctPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctPaciente.TabIndex = 17;
            this.PctPaciente.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(911, 329);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(84, 69);
            this.BtnGuardar.TabIndex = 16;
            this.BtnGuardar.Text = "Consultar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // RTBusquedaeExpediente
            // 
            this.RTBusquedaeExpediente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RTBusquedaeExpediente.ForeColor = System.Drawing.Color.DimGray;
            this.RTBusquedaeExpediente.Location = new System.Drawing.Point(171, 347);
            this.RTBusquedaeExpediente.Name = "RTBusquedaeExpediente";
            this.RTBusquedaeExpediente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTBusquedaeExpediente.Size = new System.Drawing.Size(644, 36);
            this.RTBusquedaeExpediente.TabIndex = 15;
            this.RTBusquedaeExpediente.Text = "Ingrese el codigo del Expediente";
            this.RTBusquedaeExpediente.Enter += new System.EventHandler(this.RTBusquedaPaciente_Enter);
            this.RTBusquedaeExpediente.Leave += new System.EventHandler(this.RTBusquedaPaciente_Leave);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.BackColor = System.Drawing.Color.White;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 2);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1166, 725);
            this.PnlContenedor.TabIndex = 18;
            // 
            // FrmFiltroConsultaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 727);
            this.Controls.Add(this.PctPaciente);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.RTBusquedaeExpediente);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFiltroConsultaMedica";
            this.Text = "FrmFiltroConsultaMedica";
            this.Load += new System.EventHandler(this.FrmFiltroConsultaMedica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PctPaciente;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.RichTextBox RTBusquedaeExpediente;
        private System.Windows.Forms.Panel PnlContenedor;
    }
}