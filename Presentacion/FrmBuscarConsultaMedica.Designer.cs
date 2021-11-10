
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
            this.components = new System.ComponentModel.Container();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PctConsulta = new System.Windows.Forms.PictureBox();
            this.BtnGuardarConsultaExpediente = new System.Windows.Forms.Button();
            this.BtnBuscarConsulta = new System.Windows.Forms.Button();
            this.PctExpediente = new System.Windows.Forms.PictureBox();
            this.RTBuscarConsulta = new System.Windows.Forms.RichTextBox();
            this.RTBusquedaExpediente = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExpediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Controls.Add(this.PctConsulta);
            this.PnlContenedor.Controls.Add(this.BtnGuardarConsultaExpediente);
            this.PnlContenedor.Controls.Add(this.BtnBuscarConsulta);
            this.PnlContenedor.Controls.Add(this.PctExpediente);
            this.PnlContenedor.Controls.Add(this.RTBuscarConsulta);
            this.PnlContenedor.Controls.Add(this.RTBusquedaExpediente);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1167, 727);
            this.PnlContenedor.TabIndex = 8;
            this.PnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlContenedor_Paint);
            // 
            // PctConsulta
            // 
            this.PctConsulta.Image = global::Presentacion.Properties.Resources.Usuario;
            this.PctConsulta.Location = new System.Drawing.Point(901, 322);
            this.PctConsulta.Name = "PctConsulta";
            this.PctConsulta.Size = new System.Drawing.Size(55, 36);
            this.PctConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctConsulta.TabIndex = 15;
            this.PctConsulta.TabStop = false;
            // 
            // BtnGuardarConsultaExpediente
            // 
            this.BtnGuardarConsultaExpediente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuardarConsultaExpediente.FlatAppearance.BorderSize = 0;
            this.BtnGuardarConsultaExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnGuardarConsultaExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarConsultaExpediente.Image = global::Presentacion.Properties.Resources.Buscar_321;
            this.BtnGuardarConsultaExpediente.Location = new System.Drawing.Point(962, 308);
            this.BtnGuardarConsultaExpediente.Name = "BtnGuardarConsultaExpediente";
            this.BtnGuardarConsultaExpediente.Size = new System.Drawing.Size(70, 68);
            this.BtnGuardarConsultaExpediente.TabIndex = 12;
            this.BtnGuardarConsultaExpediente.Text = "Consultar";
            this.BtnGuardarConsultaExpediente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardarConsultaExpediente.UseVisualStyleBackColor = true;
            this.BtnGuardarConsultaExpediente.Click += new System.EventHandler(this.BtnGuardarConsultaExpediente_Click);
            // 
            // BtnBuscarConsulta
            // 
            this.BtnBuscarConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBuscarConsulta.FlatAppearance.BorderSize = 0;
            this.BtnBuscarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnBuscarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarConsulta.Image = global::Presentacion.Properties.Resources.Buscar_321;
            this.BtnBuscarConsulta.Location = new System.Drawing.Point(962, 308);
            this.BtnBuscarConsulta.Name = "BtnBuscarConsulta";
            this.BtnBuscarConsulta.Size = new System.Drawing.Size(70, 68);
            this.BtnBuscarConsulta.TabIndex = 14;
            this.BtnBuscarConsulta.Text = "Consultar";
            this.BtnBuscarConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarConsulta.UseVisualStyleBackColor = true;
            this.BtnBuscarConsulta.Click += new System.EventHandler(this.BtnGuardarConsultaPaciente_Click);
            // 
            // PctExpediente
            // 
            this.PctExpediente.Image = global::Presentacion.Properties.Resources.Expediente;
            this.PctExpediente.Location = new System.Drawing.Point(901, 322);
            this.PctExpediente.Name = "PctExpediente";
            this.PctExpediente.Size = new System.Drawing.Size(55, 36);
            this.PctExpediente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctExpediente.TabIndex = 17;
            this.PctExpediente.TabStop = false;
            // 
            // RTBuscarConsulta
            // 
            this.RTBuscarConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTBuscarConsulta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RTBuscarConsulta.ForeColor = System.Drawing.Color.DimGray;
            this.RTBuscarConsulta.Location = new System.Drawing.Point(233, 322);
            this.RTBuscarConsulta.Name = "RTBuscarConsulta";
            this.RTBuscarConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTBuscarConsulta.Size = new System.Drawing.Size(644, 36);
            this.RTBuscarConsulta.TabIndex = 13;
            this.RTBuscarConsulta.Text = "Ingrese el codigo de la Consulta";
            this.RTBuscarConsulta.Enter += new System.EventHandler(this.RTBuscarPaciente_Enter);
            this.RTBuscarConsulta.Leave += new System.EventHandler(this.RTBuscarPaciente_Leave);
            // 
            // RTBusquedaExpediente
            // 
            this.RTBusquedaExpediente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTBusquedaExpediente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RTBusquedaExpediente.ForeColor = System.Drawing.Color.DimGray;
            this.RTBusquedaExpediente.Location = new System.Drawing.Point(233, 322);
            this.RTBusquedaExpediente.Name = "RTBusquedaExpediente";
            this.RTBusquedaExpediente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTBusquedaExpediente.Size = new System.Drawing.Size(644, 36);
            this.RTBusquedaExpediente.TabIndex = 11;
            this.RTBusquedaExpediente.Text = "Ingrese el codigo del Expediente";
            this.RTBusquedaExpediente.Enter += new System.EventHandler(this.RTBusquedaExpediente_Enter);
            this.RTBusquedaExpediente.Leave += new System.EventHandler(this.RTBusquedaExpediente_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuscarConsultaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 727);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarConsultaMedica";
            this.Text = "FrmBuscarConsultaMedica";
            this.PnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExpediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtnBuscarConsulta;
        private System.Windows.Forms.RichTextBox RTBuscarConsulta;
        private System.Windows.Forms.RichTextBox RTBusquedaExpediente;
        private System.Windows.Forms.Button BtnGuardarConsultaExpediente;
        private System.Windows.Forms.PictureBox PctExpediente;
        private System.Windows.Forms.PictureBox PctConsulta;
    }
}