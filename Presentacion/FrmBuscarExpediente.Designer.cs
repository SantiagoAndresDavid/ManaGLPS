
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarExpediente));
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.RTBusquedaPaciente = new System.Windows.Forms.RichTextBox();
            this.PnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(968, 309);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(84, 69);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Consultar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Controls.Add(this.BtnGuardar);
            this.PnlContenedor.Controls.Add(this.RTBusquedaPaciente);
            this.PnlContenedor.Location = new System.Drawing.Point(12, 29);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1302, 747);
            this.PnlContenedor.TabIndex = 4;
            // 
            // RTBusquedaPaciente
            // 
            this.RTBusquedaPaciente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RTBusquedaPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.RTBusquedaPaciente.Location = new System.Drawing.Point(257, 333);
            this.RTBusquedaPaciente.Name = "RTBusquedaPaciente";
            this.RTBusquedaPaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTBusquedaPaciente.Size = new System.Drawing.Size(705, 35);
            this.RTBusquedaPaciente.TabIndex = 2;
            this.RTBusquedaPaciente.Text = "Ingrese el codigo del paciente";
            this.RTBusquedaPaciente.TextChanged += new System.EventHandler(this.RTBusquedaExpediente_TextChanged);
            this.RTBusquedaPaciente.Enter += new System.EventHandler(this.RTBusquedaExpediente_Enter);
            this.RTBusquedaPaciente.Leave += new System.EventHandler(this.RTBusquedaPaciente_Leave);
            // 
            // FrmBuscarExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 788);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarExpediente";
            this.Text = "FrmBuscarExpediente";
            this.PnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.RichTextBox RTBusquedaPaciente;
    }
}