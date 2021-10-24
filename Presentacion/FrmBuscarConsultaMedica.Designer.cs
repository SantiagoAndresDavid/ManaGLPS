
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
            this.PctPaciente = new System.Windows.Forms.PictureBox();
            this.BtnGuardarConsultaExpediente = new System.Windows.Forms.Button();
            this.BtnGuardarConsultaPaciente = new System.Windows.Forms.Button();
            this.PctExpediente = new System.Windows.Forms.PictureBox();
            this.RTBuscarPaciente = new System.Windows.Forms.RichTextBox();
            this.RTBusquedaExpediente = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblLetrero = new System.Windows.Forms.Label();
            this.PnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExpediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Controls.Add(this.PctPaciente);
            this.PnlContenedor.Controls.Add(this.BtnGuardarConsultaExpediente);
            this.PnlContenedor.Controls.Add(this.BtnGuardarConsultaPaciente);
            this.PnlContenedor.Controls.Add(this.PctExpediente);
            this.PnlContenedor.Controls.Add(this.RTBuscarPaciente);
            this.PnlContenedor.Controls.Add(this.RTBusquedaExpediente);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1167, 727);
            this.PnlContenedor.TabIndex = 8;
            this.PnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlContenedor_Paint);
            // 
            // PctPaciente
            // 
            this.PctPaciente.Image = global::Presentacion.Properties.Resources.Usuario;
            this.PctPaciente.Location = new System.Drawing.Point(852, 355);
            this.PctPaciente.Name = "PctPaciente";
            this.PctPaciente.Size = new System.Drawing.Size(55, 36);
            this.PctPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctPaciente.TabIndex = 15;
            this.PctPaciente.TabStop = false;
            // 
            // BtnGuardarConsultaExpediente
            // 
            this.BtnGuardarConsultaExpediente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuardarConsultaExpediente.FlatAppearance.BorderSize = 0;
            this.BtnGuardarConsultaExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnGuardarConsultaExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarConsultaExpediente.Image = global::Presentacion.Properties.Resources.Buscar_321;
            this.BtnGuardarConsultaExpediente.Location = new System.Drawing.Point(929, 338);
            this.BtnGuardarConsultaExpediente.Name = "BtnGuardarConsultaExpediente";
            this.BtnGuardarConsultaExpediente.Size = new System.Drawing.Size(70, 68);
            this.BtnGuardarConsultaExpediente.TabIndex = 12;
            this.BtnGuardarConsultaExpediente.Text = "Consultar";
            this.BtnGuardarConsultaExpediente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardarConsultaExpediente.UseVisualStyleBackColor = true;
            this.BtnGuardarConsultaExpediente.Click += new System.EventHandler(this.BtnGuardarConsultaExpediente_Click);
            // 
            // BtnGuardarConsultaPaciente
            // 
            this.BtnGuardarConsultaPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuardarConsultaPaciente.FlatAppearance.BorderSize = 0;
            this.BtnGuardarConsultaPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnGuardarConsultaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarConsultaPaciente.Image = global::Presentacion.Properties.Resources.Buscar_321;
            this.BtnGuardarConsultaPaciente.Location = new System.Drawing.Point(929, 338);
            this.BtnGuardarConsultaPaciente.Name = "BtnGuardarConsultaPaciente";
            this.BtnGuardarConsultaPaciente.Size = new System.Drawing.Size(70, 68);
            this.BtnGuardarConsultaPaciente.TabIndex = 14;
            this.BtnGuardarConsultaPaciente.Text = "Consultar";
            this.BtnGuardarConsultaPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardarConsultaPaciente.UseVisualStyleBackColor = true;
            this.BtnGuardarConsultaPaciente.Click += new System.EventHandler(this.BtnGuardarConsultaPaciente_Click);
            // 
            // PctExpediente
            // 
            this.PctExpediente.Image = global::Presentacion.Properties.Resources.Expediente;
            this.PctExpediente.Location = new System.Drawing.Point(852, 355);
            this.PctExpediente.Name = "PctExpediente";
            this.PctExpediente.Size = new System.Drawing.Size(55, 36);
            this.PctExpediente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctExpediente.TabIndex = 17;
            this.PctExpediente.TabStop = false;
            // 
            // RTBuscarPaciente
            // 
            this.RTBuscarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTBuscarPaciente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RTBuscarPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.RTBuscarPaciente.Location = new System.Drawing.Point(184, 355);
            this.RTBuscarPaciente.Name = "RTBuscarPaciente";
            this.RTBuscarPaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTBuscarPaciente.Size = new System.Drawing.Size(644, 36);
            this.RTBuscarPaciente.TabIndex = 13;
            this.RTBuscarPaciente.Text = "Ingrese el codigo del Paciente";
            this.RTBuscarPaciente.Enter += new System.EventHandler(this.RTBuscarPaciente_Enter);
            this.RTBuscarPaciente.Leave += new System.EventHandler(this.RTBuscarPaciente_Leave);
            // 
            // RTBusquedaExpediente
            // 
            this.RTBusquedaExpediente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTBusquedaExpediente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RTBusquedaExpediente.ForeColor = System.Drawing.Color.DimGray;
            this.RTBusquedaExpediente.Location = new System.Drawing.Point(184, 355);
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
            // LblLetrero
            // 
            this.LblLetrero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblLetrero.AutoSize = true;
            this.LblLetrero.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLetrero.Location = new System.Drawing.Point(400, 323);
            this.LblLetrero.Name = "LblLetrero";
            this.LblLetrero.Size = new System.Drawing.Size(289, 22);
            this.LblLetrero.TabIndex = 16;
            this.LblLetrero.Text = "Ingrese el codigo del paciente";
            // 
            // FrmBuscarConsultaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 727);
            this.Controls.Add(this.LblLetrero);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarConsultaMedica";
            this.Text = "FrmBuscarConsultaMedica";
            this.PnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctExpediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox PctPaciente;
        private System.Windows.Forms.Label LblLetrero;
        private System.Windows.Forms.Button BtnGuardarConsultaPaciente;
        private System.Windows.Forms.RichTextBox RTBuscarPaciente;
        private System.Windows.Forms.RichTextBox RTBusquedaExpediente;
        private System.Windows.Forms.Button BtnGuardarConsultaExpediente;
        private System.Windows.Forms.PictureBox PctExpediente;
    }
}