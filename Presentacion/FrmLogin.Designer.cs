
namespace Presentacion
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PctFondo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PctMinimizar = new System.Windows.Forms.PictureBox();
            this.PctCerrar = new System.Windows.Forms.PictureBox();
            this.PctNombre = new System.Windows.Forms.PictureBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.linkdeRecuperaacion = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PctFondo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // PctFondo
            // 
            this.PctFondo.Image = global::Presentacion.Properties.Resources.Login;
            this.PctFondo.Location = new System.Drawing.Point(0, 0);
            this.PctFondo.Name = "PctFondo";
            this.PctFondo.Size = new System.Drawing.Size(676, 445);
            this.PctFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctFondo.TabIndex = 0;
            this.PctFondo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.PctMinimizar);
            this.panel1.Controls.Add(this.PctCerrar);
            this.panel1.Controls.Add(this.PctNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 32);
            this.panel1.TabIndex = 1;
            // 
            // PctMinimizar
            // 
            this.PctMinimizar.Image = global::Presentacion.Properties.Resources.Minimizar2;
            this.PctMinimizar.Location = new System.Drawing.Point(606, 0);
            this.PctMinimizar.Name = "PctMinimizar";
            this.PctMinimizar.Size = new System.Drawing.Size(32, 31);
            this.PctMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctMinimizar.TabIndex = 2;
            this.PctMinimizar.TabStop = false;
            this.PctMinimizar.Click += new System.EventHandler(this.PctMinimizar_Click);
            // 
            // PctCerrar
            // 
            this.PctCerrar.Image = global::Presentacion.Properties.Resources.Cerrar2;
            this.PctCerrar.Location = new System.Drawing.Point(644, 0);
            this.PctCerrar.Name = "PctCerrar";
            this.PctCerrar.Size = new System.Drawing.Size(32, 31);
            this.PctCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctCerrar.TabIndex = 1;
            this.PctCerrar.TabStop = false;
            this.PctCerrar.Click += new System.EventHandler(this.PctCerrar_Click);
            // 
            // PctNombre
            // 
            this.PctNombre.Image = global::Presentacion.Properties.Resources.LOGO0;
            this.PctNombre.Location = new System.Drawing.Point(2, 0);
            this.PctNombre.Name = "PctNombre";
            this.PctNombre.Size = new System.Drawing.Size(135, 31);
            this.PctNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctNombre.TabIndex = 0;
            this.PctNombre.TabStop = false;
            // 
            // textUsuario
            // 
            this.textUsuario.BackColor = System.Drawing.Color.White;
            this.textUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.textUsuario.Location = new System.Drawing.Point(68, 110);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(315, 31);
            this.textUsuario.TabIndex = 1;
            this.textUsuario.TabStop = false;
            this.textUsuario.Text = "USUARIO";
            this.textUsuario.Enter += new System.EventHandler(this.textUsuario_Enter);
            this.textUsuario.Leave += new System.EventHandler(this.textUsuario_Leave);
            // 
            // textContraseña
            // 
            this.textContraseña.BackColor = System.Drawing.Color.White;
            this.textContraseña.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.textContraseña.Location = new System.Drawing.Point(68, 182);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(315, 31);
            this.textContraseña.TabIndex = 3;
            this.textContraseña.TabStop = false;
            this.textContraseña.Text = "CONTRASEÑA";
            this.textContraseña.Enter += new System.EventHandler(this.textContraseña_Enter);
            this.textContraseña.Leave += new System.EventHandler(this.textContraseña_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(116)))), ((int)(((byte)(180)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(116)))), ((int)(((byte)(50)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.Location = new System.Drawing.Point(68, 239);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(316, 38);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // linkdeRecuperaacion
            // 
            this.linkdeRecuperaacion.AutoSize = true;
            this.linkdeRecuperaacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.linkdeRecuperaacion.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.linkdeRecuperaacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkdeRecuperaacion.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.linkdeRecuperaacion.Location = new System.Drawing.Point(134, 296);
            this.linkdeRecuperaacion.Name = "linkdeRecuperaacion";
            this.linkdeRecuperaacion.Size = new System.Drawing.Size(179, 17);
            this.linkdeRecuperaacion.TabIndex = 5;
            this.linkdeRecuperaacion.TabStop = true;
            this.linkdeRecuperaacion.Text = "¿Olvidaste tu contraseña?";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 430);
            this.Controls.Add(this.linkdeRecuperaacion);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PctFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            ((System.ComponentModel.ISupportInitialize)(this.PctFondo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctFondo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PctNombre;
        private System.Windows.Forms.PictureBox PctMinimizar;
        private System.Windows.Forms.PictureBox PctCerrar;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel linkdeRecuperaacion;
    }
}

