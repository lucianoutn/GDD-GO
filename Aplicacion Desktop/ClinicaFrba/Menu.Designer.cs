namespace ClinicaFrba
{
    partial class Menu
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
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonABMAfiliado = new System.Windows.Forms.Button();
            this.ButtonCalendar = new System.Windows.Forms.Button();
            this.button_RegResultAtenMedica = new System.Windows.Forms.Button();
            this.button_CancelarAtencion = new System.Windows.Forms.Button();
            this.button_ListadoEstadistico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.Maroon;
            this.labelFecha.Location = new System.Drawing.Point(12, 13);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(51, 16);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Maroon;
            this.labelUser.Location = new System.Drawing.Point(231, 13);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(41, 16);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSalir.Location = new System.Drawing.Point(269, 313);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 36);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonABMAfiliado
            // 
            this.buttonABMAfiliado.Location = new System.Drawing.Point(12, 45);
            this.buttonABMAfiliado.Name = "buttonABMAfiliado";
            this.buttonABMAfiliado.Size = new System.Drawing.Size(163, 36);
            this.buttonABMAfiliado.TabIndex = 3;
            this.buttonABMAfiliado.Text = "ABM Afiliado";
            this.buttonABMAfiliado.UseVisualStyleBackColor = true;
            this.buttonABMAfiliado.Click += new System.EventHandler(this.buttonABMAfiliado_Click);
            // 
            // ButtonCalendar
            // 
            this.ButtonCalendar.Location = new System.Drawing.Point(12, 87);
            this.ButtonCalendar.Name = "ButtonCalendar";
            this.ButtonCalendar.Size = new System.Drawing.Size(163, 36);
            this.ButtonCalendar.TabIndex = 4;
            this.ButtonCalendar.Text = "Calendario";
            this.ButtonCalendar.UseVisualStyleBackColor = true;
            this.ButtonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // button_RegResultAtenMedica
            // 
            this.button_RegResultAtenMedica.Location = new System.Drawing.Point(12, 171);
            this.button_RegResultAtenMedica.Name = "button_RegResultAtenMedica";
            this.button_RegResultAtenMedica.Size = new System.Drawing.Size(163, 36);
            this.button_RegResultAtenMedica.TabIndex = 5;
            this.button_RegResultAtenMedica.Text = "Registrar Resultado de\r\nAtención Médica\r\n\r\n";
            this.button_RegResultAtenMedica.UseVisualStyleBackColor = true;
            this.button_RegResultAtenMedica.Click += new System.EventHandler(this.button_RegResultAtenMedica_Click_1);
            // 
            // button_CancelarAtencion
            // 
            this.button_CancelarAtencion.Location = new System.Drawing.Point(12, 213);
            this.button_CancelarAtencion.Name = "button_CancelarAtencion";
            this.button_CancelarAtencion.Size = new System.Drawing.Size(163, 36);
            this.button_CancelarAtencion.TabIndex = 6;
            this.button_CancelarAtencion.Text = "Cancelar Atención Médica";
            this.button_CancelarAtencion.UseVisualStyleBackColor = true;
            this.button_CancelarAtencion.Click += new System.EventHandler(this.button_CancelarAtencion_Click);
            // 
            // button_ListadoEstadistico
            // 
            this.button_ListadoEstadistico.Location = new System.Drawing.Point(12, 255);
            this.button_ListadoEstadistico.Name = "button_ListadoEstadistico";
            this.button_ListadoEstadistico.Size = new System.Drawing.Size(163, 36);
            this.button_ListadoEstadistico.TabIndex = 7;
            this.button_ListadoEstadistico.Text = "Listado Estadístico";
            this.button_ListadoEstadistico.UseVisualStyleBackColor = true;
            this.button_ListadoEstadistico.Click += new System.EventHandler(this.button_ListadoEstadistico_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 361);
            this.Controls.Add(this.button_ListadoEstadistico);
            this.Controls.Add(this.button_CancelarAtencion);
            this.Controls.Add(this.button_RegResultAtenMedica);
            this.Controls.Add(this.ButtonCalendar);
            this.Controls.Add(this.buttonABMAfiliado);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelFecha);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonABMAfiliado;
        private System.Windows.Forms.Button ButtonCalendar;
        private System.Windows.Forms.Button button_RegResultAtenMedica;
        private System.Windows.Forms.Button button_CancelarAtencion;
        private System.Windows.Forms.Button button_ListadoEstadistico;
    }
}