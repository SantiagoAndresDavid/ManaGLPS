
namespace Presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PctMaximizar = new System.Windows.Forms.PictureBox();
            this.PctMinimizar = new System.Windows.Forms.PictureBox();
            this.PctRestaurar = new System.Windows.Forms.PictureBox();
            this.PctCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.BtnRegistrarUsuarios = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.PnlSubMenuAgregar = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnAgregarDatosConsulta = new System.Windows.Forms.Button();
            this.BtnAgregarExpediente = new System.Windows.Forms.Button();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.PnlSubMenuConsultar = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnConsultarExpediente = new System.Windows.Forms.Button();
            this.BtnConsultarDatosConsulta = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.PnlSubMenuModificar = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnModificarDatosConsulta = new System.Windows.Forms.Button();
            this.BtnModificarExpediente = new System.Windows.Forms.Button();
            this.btnActivarDesactivar = new System.Windows.Forms.Button();
            this.PnlSubMenuActivarDesactivar = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnDescativarDatosConsulta = new System.Windows.Forms.Button();
            this.BtnDescativarExpediente = new System.Windows.Forms.Button();
            this.BtnAcercaDe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PnlSubMenuAgregar.SuspendLayout();
            this.PnlSubMenuConsultar.SuspendLayout();
            this.PnlSubMenuModificar.SuspendLayout();
            this.PnlSubMenuActivarDesactivar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.PctMaximizar);
            this.panel1.Controls.Add(this.PctMinimizar);
            this.panel1.Controls.Add(this.PctRestaurar);
            this.panel1.Controls.Add(this.PctCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(199, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 41);
            this.panel1.TabIndex = 3;
            // 
            // PctMaximizar
            // 
            this.PctMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctMaximizar.Image = global::Presentacion.Properties.Resources.maximizar_menu;
            this.PctMaximizar.Location = new System.Drawing.Point(1217, 0);
            this.PctMaximizar.Name = "PctMaximizar";
            this.PctMaximizar.Size = new System.Drawing.Size(39, 34);
            this.PctMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctMaximizar.TabIndex = 3;
            this.PctMaximizar.TabStop = false;
            this.PctMaximizar.Click += new System.EventHandler(this.PctMaximizar_Click);
            // 
            // PctMinimizar
            // 
            this.PctMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctMinimizar.Image = global::Presentacion.Properties.Resources.Minimizar1;
            this.PctMinimizar.Location = new System.Drawing.Point(1172, 1);
            this.PctMinimizar.Name = "PctMinimizar";
            this.PctMinimizar.Size = new System.Drawing.Size(39, 34);
            this.PctMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctMinimizar.TabIndex = 2;
            this.PctMinimizar.TabStop = false;
            this.PctMinimizar.Click += new System.EventHandler(this.PctMinimizar_Click);
            // 
            // PctRestaurar
            // 
            this.PctRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctRestaurar.Image = global::Presentacion.Properties.Resources.restaurar_menu;
            this.PctRestaurar.Location = new System.Drawing.Point(1217, 0);
            this.PctRestaurar.Name = "PctRestaurar";
            this.PctRestaurar.Size = new System.Drawing.Size(39, 35);
            this.PctRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctRestaurar.TabIndex = 1;
            this.PctRestaurar.TabStop = false;
            this.PctRestaurar.Click += new System.EventHandler(this.PctRestaurar_Click);
            // 
            // PctCerrar
            // 
            this.PctCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctCerrar.Image = global::Presentacion.Properties.Resources.Cerrar1;
            this.PctCerrar.Location = new System.Drawing.Point(1262, 1);
            this.PctCerrar.Name = "PctCerrar";
            this.PctCerrar.Size = new System.Drawing.Size(37, 34);
            this.PctCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctCerrar.TabIndex = 0;
            this.PctCerrar.TabStop = false;
            this.PctCerrar.Click += new System.EventHandler(this.PctCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.Logo_Menu_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(0, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrarSesion.Location = new System.Drawing.Point(0, 823);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(199, 39);
            this.BtnCerrarSesion.TabIndex = 14;
            this.BtnCerrarSesion.Text = "Cerrar Sesion";
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // BtnRegistrarUsuarios
            // 
            this.BtnRegistrarUsuarios.BackColor = System.Drawing.Color.DarkGray;
            this.BtnRegistrarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRegistrarUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.BtnRegistrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRegistrarUsuarios.Location = new System.Drawing.Point(0, 206);
            this.BtnRegistrarUsuarios.Name = "BtnRegistrarUsuarios";
            this.BtnRegistrarUsuarios.Size = new System.Drawing.Size(199, 44);
            this.BtnRegistrarUsuarios.TabIndex = 15;
            this.BtnRegistrarUsuarios.Text = "Registrar Usuario";
            this.BtnRegistrarUsuarios.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.Location = new System.Drawing.Point(0, 250);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(199, 39);
            this.BtnAgregar.TabIndex = 19;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // PnlSubMenuAgregar
            // 
            this.PnlSubMenuAgregar.Controls.Add(this.panel5);
            this.PnlSubMenuAgregar.Controls.Add(this.BtnAgregarDatosConsulta);
            this.PnlSubMenuAgregar.Controls.Add(this.BtnAgregarExpediente);
            this.PnlSubMenuAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSubMenuAgregar.Location = new System.Drawing.Point(0, 289);
            this.PnlSubMenuAgregar.Name = "PnlSubMenuAgregar";
            this.PnlSubMenuAgregar.Size = new System.Drawing.Size(199, 84);
            this.PnlSubMenuAgregar.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(34, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(14, 84);
            this.panel5.TabIndex = 12;
            // 
            // BtnAgregarDatosConsulta
            // 
            this.BtnAgregarDatosConsulta.BackColor = System.Drawing.Color.Silver;
            this.BtnAgregarDatosConsulta.FlatAppearance.BorderSize = 0;
            this.BtnAgregarDatosConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnAgregarDatosConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarDatosConsulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarDatosConsulta.Location = new System.Drawing.Point(45, 42);
            this.BtnAgregarDatosConsulta.Name = "BtnAgregarDatosConsulta";
            this.BtnAgregarDatosConsulta.Size = new System.Drawing.Size(154, 42);
            this.BtnAgregarDatosConsulta.TabIndex = 11;
            this.BtnAgregarDatosConsulta.Text = "Consulta";
            this.BtnAgregarDatosConsulta.UseVisualStyleBackColor = false;
            // 
            // BtnAgregarExpediente
            // 
            this.BtnAgregarExpediente.BackColor = System.Drawing.Color.Silver;
            this.BtnAgregarExpediente.FlatAppearance.BorderSize = 0;
            this.BtnAgregarExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnAgregarExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarExpediente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarExpediente.Location = new System.Drawing.Point(45, 0);
            this.BtnAgregarExpediente.Name = "BtnAgregarExpediente";
            this.BtnAgregarExpediente.Size = new System.Drawing.Size(154, 42);
            this.BtnAgregarExpediente.TabIndex = 10;
            this.BtnAgregarExpediente.Text = "Expediente";
            this.BtnAgregarExpediente.UseVisualStyleBackColor = false;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.BackColor = System.Drawing.Color.DarkGray;
            this.BtnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsulta.FlatAppearance.BorderSize = 0;
            this.BtnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConsulta.Location = new System.Drawing.Point(0, 373);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(199, 44);
            this.BtnConsulta.TabIndex = 21;
            this.BtnConsulta.Text = "Consultar";
            this.BtnConsulta.UseVisualStyleBackColor = false;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // PnlSubMenuConsultar
            // 
            this.PnlSubMenuConsultar.Controls.Add(this.panel4);
            this.PnlSubMenuConsultar.Controls.Add(this.BtnConsultarExpediente);
            this.PnlSubMenuConsultar.Controls.Add(this.BtnConsultarDatosConsulta);
            this.PnlSubMenuConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSubMenuConsultar.Location = new System.Drawing.Point(0, 417);
            this.PnlSubMenuConsultar.Name = "PnlSubMenuConsultar";
            this.PnlSubMenuConsultar.Size = new System.Drawing.Size(199, 82);
            this.PnlSubMenuConsultar.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(34, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 83);
            this.panel4.TabIndex = 6;
            // 
            // BtnConsultarExpediente
            // 
            this.BtnConsultarExpediente.BackColor = System.Drawing.Color.Silver;
            this.BtnConsultarExpediente.FlatAppearance.BorderSize = 0;
            this.BtnConsultarExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnConsultarExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarExpediente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConsultarExpediente.Location = new System.Drawing.Point(45, 0);
            this.BtnConsultarExpediente.Name = "BtnConsultarExpediente";
            this.BtnConsultarExpediente.Size = new System.Drawing.Size(154, 42);
            this.BtnConsultarExpediente.TabIndex = 4;
            this.BtnConsultarExpediente.Text = "Expediente";
            this.BtnConsultarExpediente.UseVisualStyleBackColor = false;
            // 
            // BtnConsultarDatosConsulta
            // 
            this.BtnConsultarDatosConsulta.BackColor = System.Drawing.Color.Silver;
            this.BtnConsultarDatosConsulta.FlatAppearance.BorderSize = 0;
            this.BtnConsultarDatosConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnConsultarDatosConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarDatosConsulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConsultarDatosConsulta.Location = new System.Drawing.Point(45, 41);
            this.BtnConsultarDatosConsulta.Name = "BtnConsultarDatosConsulta";
            this.BtnConsultarDatosConsulta.Size = new System.Drawing.Size(154, 42);
            this.BtnConsultarDatosConsulta.TabIndex = 5;
            this.BtnConsultarDatosConsulta.Text = "Consulta";
            this.BtnConsultarDatosConsulta.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModificar.Location = new System.Drawing.Point(0, 499);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(199, 39);
            this.BtnModificar.TabIndex = 23;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // PnlSubMenuModificar
            // 
            this.PnlSubMenuModificar.Controls.Add(this.panel7);
            this.PnlSubMenuModificar.Controls.Add(this.BtnModificarDatosConsulta);
            this.PnlSubMenuModificar.Controls.Add(this.BtnModificarExpediente);
            this.PnlSubMenuModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSubMenuModificar.Location = new System.Drawing.Point(0, 538);
            this.PnlSubMenuModificar.Name = "PnlSubMenuModificar";
            this.PnlSubMenuModificar.Size = new System.Drawing.Size(199, 82);
            this.PnlSubMenuModificar.TabIndex = 24;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panel7.Location = new System.Drawing.Point(34, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(14, 83);
            this.panel7.TabIndex = 15;
            // 
            // BtnModificarDatosConsulta
            // 
            this.BtnModificarDatosConsulta.BackColor = System.Drawing.Color.Silver;
            this.BtnModificarDatosConsulta.FlatAppearance.BorderSize = 0;
            this.BtnModificarDatosConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnModificarDatosConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarDatosConsulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModificarDatosConsulta.Location = new System.Drawing.Point(45, 41);
            this.BtnModificarDatosConsulta.Name = "BtnModificarDatosConsulta";
            this.BtnModificarDatosConsulta.Size = new System.Drawing.Size(154, 42);
            this.BtnModificarDatosConsulta.TabIndex = 15;
            this.BtnModificarDatosConsulta.Text = "Consulta";
            this.BtnModificarDatosConsulta.UseVisualStyleBackColor = false;
            // 
            // BtnModificarExpediente
            // 
            this.BtnModificarExpediente.BackColor = System.Drawing.Color.Silver;
            this.BtnModificarExpediente.FlatAppearance.BorderSize = 0;
            this.BtnModificarExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnModificarExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarExpediente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModificarExpediente.Location = new System.Drawing.Point(45, 0);
            this.BtnModificarExpediente.Name = "BtnModificarExpediente";
            this.BtnModificarExpediente.Size = new System.Drawing.Size(154, 42);
            this.BtnModificarExpediente.TabIndex = 14;
            this.BtnModificarExpediente.Text = "Expediente";
            this.BtnModificarExpediente.UseVisualStyleBackColor = false;
            // 
            // btnActivarDesactivar
            // 
            this.btnActivarDesactivar.BackColor = System.Drawing.Color.DarkGray;
            this.btnActivarDesactivar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActivarDesactivar.FlatAppearance.BorderSize = 0;
            this.btnActivarDesactivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btnActivarDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarDesactivar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActivarDesactivar.Location = new System.Drawing.Point(0, 620);
            this.btnActivarDesactivar.Name = "btnActivarDesactivar";
            this.btnActivarDesactivar.Size = new System.Drawing.Size(199, 39);
            this.btnActivarDesactivar.TabIndex = 25;
            this.btnActivarDesactivar.Text = "Activar o Desactivar";
            this.btnActivarDesactivar.UseVisualStyleBackColor = false;
            this.btnActivarDesactivar.Click += new System.EventHandler(this.btnActivarDesactivar_Click);
            // 
            // PnlSubMenuActivarDesactivar
            // 
            this.PnlSubMenuActivarDesactivar.Controls.Add(this.panel6);
            this.PnlSubMenuActivarDesactivar.Controls.Add(this.BtnDescativarDatosConsulta);
            this.PnlSubMenuActivarDesactivar.Controls.Add(this.BtnDescativarExpediente);
            this.PnlSubMenuActivarDesactivar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSubMenuActivarDesactivar.Location = new System.Drawing.Point(0, 659);
            this.PnlSubMenuActivarDesactivar.Name = "PnlSubMenuActivarDesactivar";
            this.PnlSubMenuActivarDesactivar.Size = new System.Drawing.Size(199, 83);
            this.PnlSubMenuActivarDesactivar.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panel6.Location = new System.Drawing.Point(34, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(14, 83);
            this.panel6.TabIndex = 14;
            // 
            // BtnDescativarDatosConsulta
            // 
            this.BtnDescativarDatosConsulta.BackColor = System.Drawing.Color.Silver;
            this.BtnDescativarDatosConsulta.FlatAppearance.BorderSize = 0;
            this.BtnDescativarDatosConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnDescativarDatosConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDescativarDatosConsulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDescativarDatosConsulta.Location = new System.Drawing.Point(45, 41);
            this.BtnDescativarDatosConsulta.Name = "BtnDescativarDatosConsulta";
            this.BtnDescativarDatosConsulta.Size = new System.Drawing.Size(154, 42);
            this.BtnDescativarDatosConsulta.TabIndex = 13;
            this.BtnDescativarDatosConsulta.Text = "Consulta";
            this.BtnDescativarDatosConsulta.UseVisualStyleBackColor = false;
            // 
            // BtnDescativarExpediente
            // 
            this.BtnDescativarExpediente.BackColor = System.Drawing.Color.Silver;
            this.BtnDescativarExpediente.FlatAppearance.BorderSize = 0;
            this.BtnDescativarExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnDescativarExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDescativarExpediente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDescativarExpediente.Location = new System.Drawing.Point(45, 0);
            this.BtnDescativarExpediente.Name = "BtnDescativarExpediente";
            this.BtnDescativarExpediente.Size = new System.Drawing.Size(154, 42);
            this.BtnDescativarExpediente.TabIndex = 12;
            this.BtnDescativarExpediente.Text = "Expediente";
            this.BtnDescativarExpediente.UseVisualStyleBackColor = false;
            // 
            // BtnAcercaDe
            // 
            this.BtnAcercaDe.BackColor = System.Drawing.Color.DarkGray;
            this.BtnAcercaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAcercaDe.FlatAppearance.BorderSize = 0;
            this.BtnAcercaDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.BtnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcercaDe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAcercaDe.Location = new System.Drawing.Point(0, 742);
            this.BtnAcercaDe.Name = "BtnAcercaDe";
            this.BtnAcercaDe.Size = new System.Drawing.Size(199, 39);
            this.BtnAcercaDe.TabIndex = 27;
            this.BtnAcercaDe.Text = "Acerca de ";
            this.BtnAcercaDe.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.BtnAcercaDe);
            this.panel2.Controls.Add(this.PnlSubMenuActivarDesactivar);
            this.panel2.Controls.Add(this.btnActivarDesactivar);
            this.panel2.Controls.Add(this.PnlSubMenuModificar);
            this.panel2.Controls.Add(this.BtnModificar);
            this.panel2.Controls.Add(this.PnlSubMenuConsultar);
            this.panel2.Controls.Add(this.BtnConsulta);
            this.panel2.Controls.Add(this.PnlSubMenuAgregar);
            this.panel2.Controls.Add(this.BtnAgregar);
            this.panel2.Controls.Add(this.BtnRegistrarUsuarios);
            this.panel2.Controls.Add(this.BtnCerrarSesion);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 862);
            this.panel2.TabIndex = 2;
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(199, 41);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1302, 821);
            this.PnlContenedor.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 862);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PnlSubMenuAgregar.ResumeLayout(false);
            this.PnlSubMenuConsultar.ResumeLayout(false);
            this.PnlSubMenuModificar.ResumeLayout(false);
            this.PnlSubMenuActivarDesactivar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Button BtnRegistrarUsuarios;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Panel PnlSubMenuAgregar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnAgregarDatosConsulta;
        private System.Windows.Forms.Button BtnAgregarExpediente;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Panel PnlSubMenuConsultar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnConsultarExpediente;
        private System.Windows.Forms.Button BtnConsultarDatosConsulta;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Panel PnlSubMenuModificar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnModificarDatosConsulta;
        private System.Windows.Forms.Button BtnModificarExpediente;
        private System.Windows.Forms.Button btnActivarDesactivar;
        private System.Windows.Forms.Panel PnlSubMenuActivarDesactivar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnDescativarDatosConsulta;
        private System.Windows.Forms.Button BtnDescativarExpediente;
        private System.Windows.Forms.Button BtnAcercaDe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.PictureBox PctMaximizar;
        private System.Windows.Forms.PictureBox PctMinimizar;
        private System.Windows.Forms.PictureBox PctRestaurar;
        private System.Windows.Forms.PictureBox PctCerrar;
    }
}