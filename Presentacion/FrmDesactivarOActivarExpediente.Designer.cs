
namespace Presentacion
{
    partial class FrmDesactivarOActivarExpediente
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
            this.BtnBuscarExpediente = new System.Windows.Forms.Button();
            this.RTBuscarExpediente = new System.Windows.Forms.RichTextBox();
            this.PnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Controls.Add(this.BtnBuscarExpediente);
            this.PnlContenedor.Controls.Add(this.RTBuscarExpediente);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1167, 727);
            this.PnlContenedor.TabIndex = 0;
            this.PnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlContenedor_Paint);
            // 
            // BtnBuscarExpediente
            // 
            this.BtnBuscarExpediente.FlatAppearance.BorderSize = 0;
            this.BtnBuscarExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnBuscarExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarExpediente.Image = global::Presentacion.Properties.Resources.Buscar_321;
            this.BtnBuscarExpediente.Location = new System.Drawing.Point(954, 319);
            this.BtnBuscarExpediente.Name = "BtnBuscarExpediente";
            this.BtnBuscarExpediente.Size = new System.Drawing.Size(76, 68);
            this.BtnBuscarExpediente.TabIndex = 19;
            this.BtnBuscarExpediente.Text = "Consultar";
            this.BtnBuscarExpediente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarExpediente.UseVisualStyleBackColor = true;
            this.BtnBuscarExpediente.Click += new System.EventHandler(this.BtnBuscarExpediente_Click);
            // 
            // RTBuscarExpediente
            // 
            this.RTBuscarExpediente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.RTBuscarExpediente.ForeColor = System.Drawing.Color.DimGray;
            this.RTBuscarExpediente.Location = new System.Drawing.Point(197, 338);
            this.RTBuscarExpediente.Name = "RTBuscarExpediente";
            this.RTBuscarExpediente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RTBuscarExpediente.Size = new System.Drawing.Size(711, 36);
            this.RTBuscarExpediente.TabIndex = 18;
            this.RTBuscarExpediente.Text = "Ingrese el codigo del Expediente";
            this.RTBuscarExpediente.Enter += new System.EventHandler(this.RTBuscarExpediente_Enter);
            this.RTBuscarExpediente.Leave += new System.EventHandler(this.RTBuscarExpediente_Leave);
            // 
            // FrmDesactivarOActivarExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 727);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDesactivarOActivarExpediente";
            this.Text = "FrmDesactivarOActivarExpediente";
            this.PnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.Button BtnBuscarExpediente;
        private System.Windows.Forms.RichTextBox RTBuscarExpediente;
    }
}