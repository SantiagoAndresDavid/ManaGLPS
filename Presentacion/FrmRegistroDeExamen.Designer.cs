﻿
namespace Presentacion
{
    partial class FrmRegistroDeExamen
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
            this.tab = new System.Windows.Forms.TabControl();
            this.pagina1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LblFechaModificada = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblFechaCreacion = new System.Windows.Forms.Label();
            this.TimerFechaCreada = new System.Windows.Forms.DateTimePicker();
            this.pagina2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tab.SuspendLayout();
            this.pagina1.SuspendLayout();
            this.pagina2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.pagina1);
            this.tab.Controls.Add(this.pagina2);
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Location = new System.Drawing.Point(0, 2);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1365, 774);
            this.tab.TabIndex = 0;
            // 
            // pagina1
            // 
            this.pagina1.Controls.Add(this.label2);
            this.pagina1.Controls.Add(this.BtnExaminar);
            this.pagina1.Controls.Add(this.label1);
            this.pagina1.Controls.Add(this.richTextBox1);
            this.pagina1.Controls.Add(this.LblFechaModificada);
            this.pagina1.Controls.Add(this.dateTimePicker1);
            this.pagina1.Controls.Add(this.LblFechaCreacion);
            this.pagina1.Controls.Add(this.TimerFechaCreada);
            this.pagina1.Location = new System.Drawing.Point(4, 24);
            this.pagina1.Name = "pagina1";
            this.pagina1.Padding = new System.Windows.Forms.Padding(3);
            this.pagina1.Size = new System.Drawing.Size(1295, 746);
            this.pagina1.TabIndex = 0;
            this.pagina1.Text = "Pagina 1 ";
            this.pagina1.UseVisualStyleBackColor = true;
            this.pagina1.Click += new System.EventHandler(this.pagina1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(869, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Agregar imagenes diagnosticas ";
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnExaminar.Location = new System.Drawing.Point(904, 486);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(244, 37);
            this.BtnExaminar.TabIndex = 21;
            this.BtnExaminar.Text = "Examinar";
            this.BtnExaminar.UseVisualStyleBackColor = true;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(280, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Diagnostico de Remision";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(760, 532);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // LblFechaModificada
            // 
            this.LblFechaModificada.AutoSize = true;
            this.LblFechaModificada.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFechaModificada.Location = new System.Drawing.Point(930, 332);
            this.LblFechaModificada.Name = "LblFechaModificada";
            this.LblFechaModificada.Size = new System.Drawing.Size(197, 23);
            this.LblFechaModificada.TabIndex = 18;
            this.LblFechaModificada.Text = "Ultima Modificacion";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(904, 367);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 23);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // LblFechaCreacion
            // 
            this.LblFechaCreacion.AutoSize = true;
            this.LblFechaCreacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFechaCreacion.Location = new System.Drawing.Point(930, 213);
            this.LblFechaCreacion.Name = "LblFechaCreacion";
            this.LblFechaCreacion.Size = new System.Drawing.Size(188, 23);
            this.LblFechaCreacion.TabIndex = 16;
            this.LblFechaCreacion.Text = "Fecha de Creacion";
            // 
            // TimerFechaCreada
            // 
            this.TimerFechaCreada.Location = new System.Drawing.Point(904, 248);
            this.TimerFechaCreada.Name = "TimerFechaCreada";
            this.TimerFechaCreada.Size = new System.Drawing.Size(244, 23);
            this.TimerFechaCreada.TabIndex = 14;
            // 
            // pagina2
            // 
            this.pagina2.Controls.Add(this.label4);
            this.pagina2.Controls.Add(this.richTextBox3);
            this.pagina2.Controls.Add(this.label3);
            this.pagina2.Controls.Add(this.richTextBox2);
            this.pagina2.Location = new System.Drawing.Point(4, 24);
            this.pagina2.Name = "pagina2";
            this.pagina2.Padding = new System.Windows.Forms.Padding(3);
            this.pagina2.Size = new System.Drawing.Size(1295, 746);
            this.pagina2.TabIndex = 1;
            this.pagina2.Text = "Pagina 2 ";
            this.pagina2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(898, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Informe Grupal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(687, 54);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(529, 626);
            this.richTextBox3.TabIndex = 23;
            this.richTextBox3.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(177, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Informe Individual ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(27, 54);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(520, 626);
            this.richTextBox2.TabIndex = 21;
            this.richTextBox2.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.richTextBox5);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.richTextBox4);
            this.tabPage1.Controls.Add(this.checkedListBox3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.checkedListBox2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.TextCorreoElectronico);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1357, 746);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Page 3";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(792, 575);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 145);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones Posibles";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Presentacion.Properties.Resources.Guardar_48;
            this.button2.Location = new System.Drawing.Point(171, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 93);
            this.button2.TabIndex = 1;
            this.button2.Text = "Limpiar Campos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Presentacion.Properties.Resources.Guardar_48;
            this.button1.Location = new System.Drawing.Point(54, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(420, 628);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 33);
            this.textBox2.TabIndex = 45;
            this.textBox2.Text = "Descipcion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(510, 593);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 23);
            this.label13.TabIndex = 44;
            this.label13.Text = "Descipcion";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(91, 628);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 33);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = "Codigo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(160, 593);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 23);
            this.label12.TabIndex = 40;
            this.label12.Text = "Codigo";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(503, 122);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(470, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 23);
            this.label11.TabIndex = 38;
            this.label11.Text = "Fase de tratamiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(434, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 23);
            this.label10.TabIndex = 37;
            this.label10.Text = "Caracteristicas de la lesion";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(438, 208);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(257, 162);
            this.richTextBox5.TabIndex = 36;
            this.richTextBox5.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(825, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "Caracteristicas de la lesion";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(817, 99);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(269, 440);
            this.richTextBox4.TabIndex = 34;
            this.richTextBox4.Text = "";
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.CheckOnClick = true;
            this.checkedListBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "0. Nada",
            "1. Un Poco",
            "2. Poco",
            "3. Medio",
            "4. Mucho",
            "5. En Exeso "});
            this.checkedListBox3.Location = new System.Drawing.Point(459, 415);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(193, 124);
            this.checkedListBox3.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(438, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Frecuencia de disminucion";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "0. Nada",
            "1. Un Poco",
            "2. Poco",
            "3. Medio",
            "4. Mucho",
            "5. En Exeso "});
            this.checkedListBox2.Location = new System.Drawing.Point(108, 411);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(193, 124);
            this.checkedListBox2.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(91, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Frecuencia de aumento";
            // 
            // TextCorreoElectronico
            // 
            this.TextCorreoElectronico.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TextCorreoElectronico.ForeColor = System.Drawing.Color.DimGray;
            this.TextCorreoElectronico.Location = new System.Drawing.Point(108, 302);
            this.TextCorreoElectronico.Name = "TextCorreoElectronico";
            this.TextCorreoElectronico.Size = new System.Drawing.Size(193, 33);
            this.TextCorreoElectronico.TabIndex = 29;
            this.TextCorreoElectronico.Text = "Localizacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(133, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Localizacion";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "0. Sin dolor",
            "1. Dolor leve",
            "2. Dolor moderado",
            "3. Dolor severo",
            "4. Dolor muy severo",
            "5. Dolor maximo "});
            this.checkedListBox1.Location = new System.Drawing.Point(108, 99);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(193, 124);
            this.checkedListBox1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(123, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Escala de dolor ";
            // 
            // FrmRegistroDeExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 788);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroDeExamen";
            this.Text = "FrmRegistroDeExamen";
            this.Load += new System.EventHandler(this.FrmRegistroDeExamen_Load);
            this.tab.ResumeLayout(false);
            this.pagina1.ResumeLayout(false);
            this.pagina1.PerformLayout();
            this.pagina2.ResumeLayout(false);
            this.pagina2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage pagina1;
        private System.Windows.Forms.TabPage pagina2;
        private System.Windows.Forms.DateTimePicker TimerFechaCreada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnExaminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LblFechaModificada;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LblFechaCreacion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextCorreoElectronico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}