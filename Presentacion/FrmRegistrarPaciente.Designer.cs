﻿
namespace Presentacion
{
    partial class FrmRegistrarPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTIdentidad = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources._00c537bdf08547f031540521892e5aa7;
            this.pictureBox1.Location = new System.Drawing.Point(7, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox3.Controls.Add(this.BtnEditar);
            this.groupBox3.Controls.Add(this.BtnGuardar);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(680, 431);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 162);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones Posibles ";
            // 
            // BtnEditar
            // 
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Image = global::Presentacion.Properties.Resources.Editar_481;
            this.BtnEditar.Location = new System.Drawing.Point(251, 42);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(143, 93);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Image = global::Presentacion.Properties.Resources.Guardar_481;
            this.BtnGuardar.Location = new System.Drawing.Point(98, 42);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(143, 93);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.email,
            this.Usuario,
            this.TipoUsuario,
            this.Edad,
            this.Telefono,
            this.Direccion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(139, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 184);
            this.dataGridView1.TabIndex = 13;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.email.HeaderText = "              Identidad              ";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 265;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Nombre";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 109;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.HeaderText = "Apellido";
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.ReadOnly = true;
            this.TipoUsuario.Width = 113;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 83;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 111;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 122;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.TXTDireccion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TXTTelefono);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(731, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 131);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de contacto";
            // 
            // TXTDireccion
            // 
            this.TXTDireccion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TXTDireccion.ForeColor = System.Drawing.Color.DimGray;
            this.TXTDireccion.Location = new System.Drawing.Point(179, 76);
            this.TXTDireccion.Name = "TXTDireccion";
            this.TXTDireccion.Size = new System.Drawing.Size(206, 33);
            this.TXTDireccion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Direccion:";
            // 
            // TXTTelefono
            // 
            this.TXTTelefono.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TXTTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.TXTTelefono.Location = new System.Drawing.Point(179, 28);
            this.TXTTelefono.Name = "TXTTelefono";
            this.TXTTelefono.Size = new System.Drawing.Size(206, 33);
            this.TXTTelefono.TabIndex = 8;
            this.TXTTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.TextTelefono_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TXTEdad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXTApellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXTNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXTIdentidad);
            this.groupBox1.Controls.Add(this.LblUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(202, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 222);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion basica del cliente";
            // 
            // TXTEdad
            // 
            this.TXTEdad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TXTEdad.ForeColor = System.Drawing.Color.DimGray;
            this.TXTEdad.Location = new System.Drawing.Point(157, 180);
            this.TXTEdad.Name = "TXTEdad";
            this.TXTEdad.Size = new System.Drawing.Size(91, 33);
            this.TXTEdad.TabIndex = 12;
            this.TXTEdad.Validating += new System.ComponentModel.CancelEventHandler(this.TextEdad_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Edad:";
            // 
            // TXTApellido
            // 
            this.TXTApellido.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TXTApellido.ForeColor = System.Drawing.Color.DimGray;
            this.TXTApellido.Location = new System.Drawing.Point(157, 131);
            this.TXTApellido.Name = "TXTApellido";
            this.TXTApellido.Size = new System.Drawing.Size(316, 33);
            this.TXTApellido.TabIndex = 10;
            this.TXTApellido.Validating += new System.ComponentModel.CancelEventHandler(this.TextApellido_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido:";
            // 
            // TXTNombre
            // 
            this.TXTNombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TXTNombre.ForeColor = System.Drawing.Color.DimGray;
            this.TXTNombre.Location = new System.Drawing.Point(157, 82);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.Size = new System.Drawing.Size(316, 33);
            this.TXTNombre.TabIndex = 8;
            this.TXTNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TextNombre_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // TXTIdentidad
            // 
            this.TXTIdentidad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TXTIdentidad.ForeColor = System.Drawing.Color.DimGray;
            this.TXTIdentidad.Location = new System.Drawing.Point(157, 33);
            this.TXTIdentidad.Name = "TXTIdentidad";
            this.TXTIdentidad.Size = new System.Drawing.Size(316, 33);
            this.TXTIdentidad.TabIndex = 6;
            this.TXTIdentidad.Validating += new System.ComponentModel.CancelEventHandler(this.TextIdentificacion_Validating);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUsuario.Location = new System.Drawing.Point(20, 37);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(106, 23);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Identidad:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmRegistrarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 727);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarPaciente";
            this.Text = "FrmRegistrarPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXTEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTIdentidad;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}