﻿
namespace Presentacion
{
    partial class FrmRegistrarUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblConfirmarContrseña = new System.Windows.Forms.Label();
            this.LblTipoUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.TextConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.TextContraseña = new System.Windows.Forms.TextBox();
            this.TextCorreoElectronico = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CmbTipoDeUsuario = new System.Windows.Forms.ComboBox();
            this.TextNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUsuario.Location = new System.Drawing.Point(43, 105);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(193, 23);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Nombre de Usuario:";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblContraseña.Location = new System.Drawing.Point(117, 230);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(122, 23);
            this.LblContraseña.TabIndex = 1;
            this.LblContraseña.Text = "Contraseña:";
            // 
            // LblConfirmarContrseña
            // 
            this.LblConfirmarContrseña.AutoSize = true;
            this.LblConfirmarContrseña.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblConfirmarContrseña.Location = new System.Drawing.Point(18, 283);
            this.LblConfirmarContrseña.Name = "LblConfirmarContrseña";
            this.LblConfirmarContrseña.Size = new System.Drawing.Size(218, 23);
            this.LblConfirmarContrseña.TabIndex = 2;
            this.LblConfirmarContrseña.Text = "Confirmar Contraseña:";
            // 
            // LblTipoUsuario
            // 
            this.LblTipoUsuario.AutoSize = true;
            this.LblTipoUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTipoUsuario.Location = new System.Drawing.Point(86, 165);
            this.LblTipoUsuario.Name = "LblTipoUsuario";
            this.LblTipoUsuario.Size = new System.Drawing.Size(154, 23);
            this.LblTipoUsuario.TabIndex = 4;
            this.LblTipoUsuario.Text = "Tipo de usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.TextConfirmarContraseña);
            this.groupBox1.Controls.Add(this.TextContraseña);
            this.groupBox1.Controls.Add(this.TextCorreoElectronico);
            this.groupBox1.Controls.Add(this.LblEmail);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.CmbTipoDeUsuario);
            this.groupBox1.Controls.Add(this.TextNombreDeUsuario);
            this.groupBox1.Controls.Add(this.LblUsuario);
            this.groupBox1.Controls.Add(this.LblTipoUsuario);
            this.groupBox1.Controls.Add(this.LblConfirmarContrseña);
            this.groupBox1.Controls.Add(this.LblContraseña);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(341, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 334);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de Registro";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Presentacion.Properties.Resources.Buscar_32;
            this.button4.Location = new System.Drawing.Point(761, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 33);
            this.button4.TabIndex = 14;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // TextConfirmarContraseña
            // 
            this.TextConfirmarContraseña.BackColor = System.Drawing.Color.White;
            this.TextConfirmarContraseña.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TextConfirmarContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.TextConfirmarContraseña.Location = new System.Drawing.Point(246, 279);
            this.TextConfirmarContraseña.Name = "TextConfirmarContraseña";
            this.TextConfirmarContraseña.Size = new System.Drawing.Size(315, 33);
            this.TextConfirmarContraseña.TabIndex = 13;
            this.TextConfirmarContraseña.TabStop = false;
            this.TextConfirmarContraseña.Text = "Confirma tu contraseña";
            this.TextConfirmarContraseña.Enter += new System.EventHandler(this.TextConfirmarContraseña_Enter);
            this.TextConfirmarContraseña.Leave += new System.EventHandler(this.TextConfirmarContraseña_Leave);
            // 
            // TextContraseña
            // 
            this.TextContraseña.BackColor = System.Drawing.Color.White;
            this.TextContraseña.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TextContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.TextContraseña.Location = new System.Drawing.Point(246, 226);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(315, 33);
            this.TextContraseña.TabIndex = 12;
            this.TextContraseña.TabStop = false;
            this.TextContraseña.Text = "Ingresa tu contraseña";
            this.TextContraseña.Enter += new System.EventHandler(this.TextContraseña_Enter);
            this.TextContraseña.Leave += new System.EventHandler(this.TextContraseña_Leave);
            // 
            // TextCorreoElectronico
            // 
            this.TextCorreoElectronico.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TextCorreoElectronico.ForeColor = System.Drawing.Color.DimGray;
            this.TextCorreoElectronico.Location = new System.Drawing.Point(246, 41);
            this.TextCorreoElectronico.Name = "TextCorreoElectronico";
            this.TextCorreoElectronico.Size = new System.Drawing.Size(472, 33);
            this.TextCorreoElectronico.TabIndex = 11;
            this.TextCorreoElectronico.Text = "usuario@ejemplo.com";
            this.TextCorreoElectronico.Enter += new System.EventHandler(this.TextCorreoElectronico_Enter);
            this.TextCorreoElectronico.Leave += new System.EventHandler(this.TextCorreoElectronico_Leave);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEmail.Location = new System.Drawing.Point(53, 44);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(186, 23);
            this.LblEmail.TabIndex = 10;
            this.LblEmail.Text = "Correo Electronico:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.RegistrarUsuario;
            this.pictureBox1.Location = new System.Drawing.Point(602, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // CmbTipoDeUsuario
            // 
            this.CmbTipoDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDeUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbTipoDeUsuario.FormattingEnabled = true;
            this.CmbTipoDeUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Personal Medico",
            "Personal de apoyo(Secretaria)"});
            this.CmbTipoDeUsuario.Location = new System.Drawing.Point(246, 162);
            this.CmbTipoDeUsuario.Name = "CmbTipoDeUsuario";
            this.CmbTipoDeUsuario.Size = new System.Drawing.Size(316, 32);
            this.CmbTipoDeUsuario.TabIndex = 9;
            // 
            // TextNombreDeUsuario
            // 
            this.TextNombreDeUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TextNombreDeUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.TextNombreDeUsuario.Location = new System.Drawing.Point(246, 101);
            this.TextNombreDeUsuario.Name = "TextNombreDeUsuario";
            this.TextNombreDeUsuario.Size = new System.Drawing.Size(316, 33);
            this.TextNombreDeUsuario.TabIndex = 5;
            this.TextNombreDeUsuario.Text = "Nombre de usuario";
            this.TextNombreDeUsuario.Enter += new System.EventHandler(this.TextNombreDeUsuario_Enter);
            this.TextNombreDeUsuario.Leave += new System.EventHandler(this.TextNombreDeUsuario_Leave);
            this.TextNombreDeUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TextNombreDeUsuario_Validating);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.email,
            this.Usuario,
            this.TipoUsuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(73, 473);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(733, 219);
            this.dataGridView1.TabIndex = 7;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.email.HeaderText = "              Correo Electronico              ";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 345;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Nombre de Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 212;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.HeaderText = "Tipo de usuario";
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.ReadOnly = true;
            this.TipoUsuario.Width = 173;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.Usuario;
            this.pictureBox2.Location = new System.Drawing.Point(73, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 334);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.BtnGuardar);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(815, 505);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 186);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones Posibles";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Presentacion.Properties.Resources.Eliminar_48;
            this.button3.Location = new System.Drawing.Point(317, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 90);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Presentacion.Properties.Resources.Editar_48;
            this.button2.Location = new System.Drawing.Point(184, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 90);
            this.button2.TabIndex = 1;
            this.button2.Text = "Editar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Image = global::Presentacion.Properties.Resources.Guardar_48;
            this.BtnGuardar.Location = new System.Drawing.Point(46, 50);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(87, 90);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 788);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarUsuario";
            this.Text = "RegistrarUsuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Label LblConfirmarContrseña;
        private System.Windows.Forms.Label LblTipoUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.ComboBox CmbTipoDeUsuario;
        private System.Windows.Forms.TextBox TextNombreDeUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TextConfirmarContraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.TextBox TextContraseña;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TextCorreoElectronico;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}