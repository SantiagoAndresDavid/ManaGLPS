
namespace Presentacion
{
    partial class FrmBuscarConsultaMedica
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
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.RTBuscarPaciente = new System.Windows.Forms.RichTextBox();
            this.RTBusquedaExpediente = new System.Windows.Forms.RichTextBox();
            this.BtnGuardarConsultaPaciente = new System.Windows.Forms.Button();
            this.BtnGuardarConsultaExpediente = new System.Windows.Forms.Button();
            this.PnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Controls.Add(this.BtnGuardarConsultaExpediente);
            this.PnlContenedor.Controls.Add(this.BtnGuardarConsultaPaciente);
            this.PnlContenedor.Controls.Add(this.RTBusquedaExpediente);
            this.PnlContenedor.Controls.Add(this.RTBuscarPaciente);
            this.PnlContenedor.Location = new System.Drawing.Point(1, 2);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1302, 747);
            this.PnlContenedor.TabIndex = 8;
            this.PnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlContenedor_Paint);
            // 
            // RTBuscarPaciente
            // 
            this.RTBuscarPaciente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RTBuscarPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.RTBuscarPaciente.Location = new System.Drawing.Point(237, 322);
            this.RTBuscarPaciente.Name = "RTBuscarPaciente";
            this.RTBuscarPaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTBuscarPaciente.Size = new System.Drawing.Size(705, 36);
            this.RTBuscarPaciente.TabIndex = 6;
            this.RTBuscarPaciente.Text = "Ingrese el codigo del Paciente";
            this.RTBuscarPaciente.TextChanged += new System.EventHandler(this.RTBuscarPaciente_TextChanged);
            this.RTBuscarPaciente.Enter += new System.EventHandler(this.RTBuscarPaciente_Enter);
            this.RTBuscarPaciente.Leave += new System.EventHandler(this.RTBuscarPaciente_Leave);
            // 
            // RTBusquedaExpediente
            // 
            this.RTBusquedaExpediente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RTBusquedaExpediente.ForeColor = System.Drawing.Color.DimGray;
            this.RTBusquedaExpediente.Location = new System.Drawing.Point(237, 322);
            this.RTBusquedaExpediente.Name = "RTBusquedaExpediente";
            this.RTBusquedaExpediente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTBusquedaExpediente.Size = new System.Drawing.Size(705, 36);
            this.RTBusquedaExpediente.TabIndex = 4;
            this.RTBusquedaExpediente.Text = "Ingrese el codigo del Expediente";
            this.RTBusquedaExpediente.TextChanged += new System.EventHandler(this.RTBusquedaExpediente_TextChanged);
            this.RTBusquedaExpediente.Enter += new System.EventHandler(this.RTBusquedaExpediente_Enter);
            this.RTBusquedaExpediente.Leave += new System.EventHandler(this.RTBusquedaExpediente_Leave);
            // 
            // BtnGuardarConsultaPaciente
            // 
            this.BtnGuardarConsultaPaciente.FlatAppearance.BorderSize = 0;
            this.BtnGuardarConsultaPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnGuardarConsultaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarConsultaPaciente.Image = global::Presentacion.Properties.Resources.Buscar_321;
            this.BtnGuardarConsultaPaciente.Location = new System.Drawing.Point(966, 290);
            this.BtnGuardarConsultaPaciente.Name = "BtnGuardarConsultaPaciente";
            this.BtnGuardarConsultaPaciente.Size = new System.Drawing.Size(70, 68);
            this.BtnGuardarConsultaPaciente.TabIndex = 7;
            this.BtnGuardarConsultaPaciente.Text = "Consultar";
            this.BtnGuardarConsultaPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardarConsultaPaciente.UseVisualStyleBackColor = true;
            this.BtnGuardarConsultaPaciente.Click += new System.EventHandler(this.BtnGuardarConsultaPaciente_Click);
            // 
            // BtnGuardarConsultaExpediente
            // 
            this.BtnGuardarConsultaExpediente.FlatAppearance.BorderSize = 0;
            this.BtnGuardarConsultaExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnGuardarConsultaExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarConsultaExpediente.Image = global::Presentacion.Properties.Resources.Buscar_321;
            this.BtnGuardarConsultaExpediente.Location = new System.Drawing.Point(966, 290);
            this.BtnGuardarConsultaExpediente.Name = "BtnGuardarConsultaExpediente";
            this.BtnGuardarConsultaExpediente.Size = new System.Drawing.Size(70, 68);
            this.BtnGuardarConsultaExpediente.TabIndex = 5;
            this.BtnGuardarConsultaExpediente.Text = "Consultar";
            this.BtnGuardarConsultaExpediente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardarConsultaExpediente.UseVisualStyleBackColor = true;
            this.BtnGuardarConsultaExpediente.Click += new System.EventHandler(this.BtnGuardarConsultaExpediente_Click);
            // 
            // FrmBuscarConsultaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 788);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarConsultaMedica";
            this.Text = "FrmBuscarConsultaMedica";
            this.PnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.Button BtnGuardarConsultaExpediente;
        private System.Windows.Forms.Button BtnGuardarConsultaPaciente;
        private System.Windows.Forms.RichTextBox RTBusquedaExpediente;
        private System.Windows.Forms.RichTextBox RTBuscarPaciente;
    }
}