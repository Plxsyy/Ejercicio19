namespace Ejercicio19
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Fuentes = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAzulFormulario = new System.Windows.Forms.Button();
            this.btnVerdeFormulario = new System.Windows.Forms.Button();
            this.btnRojoFormulario = new System.Windows.Forms.Button();
            this.btnReducir = new System.Windows.Forms.Button();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRojoTexto = new System.Windows.Forms.Button();
            this.btnAzulTexto = new System.Windows.Forms.Button();
            this.btnVerdeTexto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.checkBoxNegrita = new System.Windows.Forms.CheckBox();
            this.checkBoxCursiva = new System.Windows.Forms.CheckBox();
            this.checkBoxSubrayado = new System.Windows.Forms.CheckBox();
            this.textBoxTexto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fuentes
            // 
            this.Fuentes.FormattingEnabled = true;
            this.Fuentes.ItemHeight = 16;
            this.Fuentes.Items.AddRange(new object[] {
            "Aharoni",
            "Andalus",
            "Angansa New",
            "Angansa UPC",
            "Aparajita",
            "Arabic Typesetting",
            "Arial",
            "Arial Black",
            "Batang",
            "BatangChe",
            "Browallia New",
            "Browalia UPC",
            "Buxton Sketch",
            "Calibri",
            "Calibri Light",
            "Cambria",
            "Cambria Math",
            "Candara",
            "Comic Sans MS",
            "Consolas",
            "Constatia",
            "Corbel",
            "Cordia New",
            "Cordia UPC",
            "Courier New",
            "Daun Penh",
            "Comfortaa",
            "Georgia",
            "Impact",
            "Lato",
            "Lexend",
            "Lobster",
            "Lora",
            "Merriweather",
            "Monstserrat"});
            this.Fuentes.Location = new System.Drawing.Point(605, 28);
            this.Fuentes.Name = "Fuentes";
            this.Fuentes.Size = new System.Drawing.Size(147, 404);
            this.Fuentes.TabIndex = 0;
            this.Fuentes.SelectedIndexChanged += new System.EventHandler(this.Fuentes_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAzulFormulario);
            this.panel1.Controls.Add(this.btnVerdeFormulario);
            this.panel1.Controls.Add(this.btnRojoFormulario);
            this.panel1.Controls.Add(this.btnReducir);
            this.panel1.Controls.Add(this.btnAumentar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 133);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color del fomulario";
            // 
            // btnAzulFormulario
            // 
            this.btnAzulFormulario.BackColor = System.Drawing.Color.Blue;
            this.btnAzulFormulario.Location = new System.Drawing.Point(74, 99);
            this.btnAzulFormulario.Name = "btnAzulFormulario";
            this.btnAzulFormulario.Size = new System.Drawing.Size(21, 23);
            this.btnAzulFormulario.TabIndex = 5;
            this.btnAzulFormulario.UseVisualStyleBackColor = false;
            this.btnAzulFormulario.Click += new System.EventHandler(this.btnAzulFormulario_Click);
            // 
            // btnVerdeFormulario
            // 
            this.btnVerdeFormulario.BackColor = System.Drawing.Color.LawnGreen;
            this.btnVerdeFormulario.Location = new System.Drawing.Point(45, 99);
            this.btnVerdeFormulario.Name = "btnVerdeFormulario";
            this.btnVerdeFormulario.Size = new System.Drawing.Size(23, 23);
            this.btnVerdeFormulario.TabIndex = 4;
            this.btnVerdeFormulario.UseVisualStyleBackColor = false;
            this.btnVerdeFormulario.Click += new System.EventHandler(this.btnVerdeFormulario_Click_1);
            // 
            // btnRojoFormulario
            // 
            this.btnRojoFormulario.BackColor = System.Drawing.Color.Red;
            this.btnRojoFormulario.Location = new System.Drawing.Point(101, 99);
            this.btnRojoFormulario.Name = "btnRojoFormulario";
            this.btnRojoFormulario.Size = new System.Drawing.Size(22, 23);
            this.btnRojoFormulario.TabIndex = 3;
            this.btnRojoFormulario.UseVisualStyleBackColor = false;
            this.btnRojoFormulario.Click += new System.EventHandler(this.btnRojoFormulario_Click);
            // 
            // btnReducir
            // 
            this.btnReducir.Location = new System.Drawing.Point(140, 31);
            this.btnReducir.Name = "btnReducir";
            this.btnReducir.Size = new System.Drawing.Size(75, 23);
            this.btnReducir.TabIndex = 2;
            this.btnReducir.Text = "Reducir";
            this.btnReducir.UseVisualStyleBackColor = true;
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(20, 31);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(75, 23);
            this.btnAumentar.TabIndex = 1;
            this.btnAumentar.Text = "Aumentar";
            this.btnAumentar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Propiedades del form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamaño del texto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRojoTexto);
            this.panel2.Controls.Add(this.btnAzulTexto);
            this.panel2.Controls.Add(this.btnVerdeTexto);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(59, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 137);
            this.panel2.TabIndex = 3;
            // 
            // btnRojoTexto
            // 
            this.btnRojoTexto.BackColor = System.Drawing.Color.Red;
            this.btnRojoTexto.Location = new System.Drawing.Point(79, 99);
            this.btnRojoTexto.Name = "btnRojoTexto";
            this.btnRojoTexto.Size = new System.Drawing.Size(22, 23);
            this.btnRojoTexto.TabIndex = 7;
            this.btnRojoTexto.UseVisualStyleBackColor = false;
            this.btnRojoTexto.Click += new System.EventHandler(this.btnRojoTexto_Click);
            // 
            // btnAzulTexto
            // 
            this.btnAzulTexto.BackColor = System.Drawing.Color.Blue;
            this.btnAzulTexto.Location = new System.Drawing.Point(52, 99);
            this.btnAzulTexto.Name = "btnAzulTexto";
            this.btnAzulTexto.Size = new System.Drawing.Size(21, 23);
            this.btnAzulTexto.TabIndex = 6;
            this.btnAzulTexto.UseVisualStyleBackColor = false;
            this.btnAzulTexto.Click += new System.EventHandler(this.btnAzulTexto_Click);
            // 
            // btnVerdeTexto
            // 
            this.btnVerdeTexto.BackColor = System.Drawing.Color.LawnGreen;
            this.btnVerdeTexto.Location = new System.Drawing.Point(23, 99);
            this.btnVerdeTexto.Name = "btnVerdeTexto";
            this.btnVerdeTexto.Size = new System.Drawing.Size(23, 23);
            this.btnVerdeTexto.TabIndex = 5;
            this.btnVerdeTexto.UseVisualStyleBackColor = false;
            this.btnVerdeTexto.Click += new System.EventHandler(this.btnVerdeTexto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color Texto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "22",
            "24"});
            this.comboBox1.Location = new System.Drawing.Point(20, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(79, 365);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(103, 23);
            this.btnOcultar.TabIndex = 4;
            this.btnOcultar.Text = "Ocultar Texto";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(225, 366);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(98, 23);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar Texto";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(394, 364);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // checkBoxNegrita
            // 
            this.checkBoxNegrita.AutoSize = true;
            this.checkBoxNegrita.Location = new System.Drawing.Point(79, 395);
            this.checkBoxNegrita.Name = "checkBoxNegrita";
            this.checkBoxNegrita.Size = new System.Drawing.Size(73, 20);
            this.checkBoxNegrita.TabIndex = 7;
            this.checkBoxNegrita.Text = "Negrita";
            this.checkBoxNegrita.UseVisualStyleBackColor = true;
            this.checkBoxNegrita.CheckedChanged += new System.EventHandler(this.checkBoxNegrita_CheckedChanged);
            // 
            // checkBoxCursiva
            // 
            this.checkBoxCursiva.AutoSize = true;
            this.checkBoxCursiva.Location = new System.Drawing.Point(228, 395);
            this.checkBoxCursiva.Name = "checkBoxCursiva";
            this.checkBoxCursiva.Size = new System.Drawing.Size(74, 20);
            this.checkBoxCursiva.TabIndex = 8;
            this.checkBoxCursiva.Text = "Cursiva";
            this.checkBoxCursiva.UseVisualStyleBackColor = true;
            this.checkBoxCursiva.CheckedChanged += new System.EventHandler(this.checkBoxCursiva_CheckedChanged);
            // 
            // checkBoxSubrayado
            // 
            this.checkBoxSubrayado.AutoSize = true;
            this.checkBoxSubrayado.Location = new System.Drawing.Point(394, 395);
            this.checkBoxSubrayado.Name = "checkBoxSubrayado";
            this.checkBoxSubrayado.Size = new System.Drawing.Size(96, 20);
            this.checkBoxSubrayado.TabIndex = 9;
            this.checkBoxSubrayado.Text = "Subrayado";
            this.checkBoxSubrayado.UseVisualStyleBackColor = true;
            this.checkBoxSubrayado.CheckedChanged += new System.EventHandler(this.checkBoxSubrayado_CheckedChanged);
            // 
            // textBoxTexto
            // 
            this.textBoxTexto.Location = new System.Drawing.Point(382, 59);
            this.textBoxTexto.Multiline = true;
            this.textBoxTexto.Name = "textBoxTexto";
            this.textBoxTexto.Size = new System.Drawing.Size(135, 267);
            this.textBoxTexto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Texto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTexto);
            this.Controls.Add(this.checkBoxSubrayado);
            this.Controls.Add(this.checkBoxCursiva);
            this.Controls.Add(this.checkBoxNegrita);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Fuentes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Fuentes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAzulFormulario;
        private System.Windows.Forms.Button btnVerdeFormulario;
        private System.Windows.Forms.Button btnRojoFormulario;
        private System.Windows.Forms.Button btnReducir;
        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRojoTexto;
        private System.Windows.Forms.Button btnAzulTexto;
        private System.Windows.Forms.Button btnVerdeTexto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.CheckBox checkBoxNegrita;
        private System.Windows.Forms.CheckBox checkBoxCursiva;
        private System.Windows.Forms.CheckBox checkBoxSubrayado;
        private System.Windows.Forms.TextBox textBoxTexto;
        private System.Windows.Forms.Label label5;
    }
}

