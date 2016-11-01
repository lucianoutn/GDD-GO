﻿namespace ClinicaFrba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonABMAfiliado = new System.Windows.Forms.Button();
            this.ButtonCalendar = new System.Windows.Forms.Button();
            this.buttonABMRol = new System.Windows.Forms.Button();
            this.button_RegResultAtenMedica = new System.Windows.Forms.Button();
            this.button_CancelarAtencion = new System.Windows.Forms.Button();
            this.button_ListadoEstadistico = new System.Windows.Forms.Button();
            this.buttonComprarBono = new System.Windows.Forms.Button();
            this.buttonCambiarPlan = new System.Windows.Forms.Button();
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
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Maroon;
            this.labelUser.Location = new System.Drawing.Point(179, 13);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(121, 16);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Nombre Usuario";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // buttonABMRol
            // 
            this.buttonABMRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonABMRol.Location = new System.Drawing.Point(181, 45);
            this.buttonABMRol.Name = "buttonABMRol";
            this.buttonABMRol.Size = new System.Drawing.Size(163, 36);
            this.buttonABMRol.TabIndex = 8;
            this.buttonABMRol.Text = "ABM Rol";
            this.buttonABMRol.UseVisualStyleBackColor = true;
            this.buttonABMRol.Click += new System.EventHandler(this.buttonABMRol_Click);
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
            // buttonComprarBono
            // 
            this.buttonComprarBono.Location = new System.Drawing.Point(182, 171);
            this.buttonComprarBono.Name = "buttonComprarBono";
            this.buttonComprarBono.Size = new System.Drawing.Size(162, 36);
            this.buttonComprarBono.TabIndex = 9;
            this.buttonComprarBono.Text = "Comprar Bono";
            this.buttonComprarBono.UseVisualStyleBackColor = true;
            this.buttonComprarBono.Click += new System.EventHandler(this.buttonComprarBono_Click);
            // 
            // buttonCambiarPlan
            // 
            this.buttonCambiarPlan.Location = new System.Drawing.Point(182, 213);
            this.buttonCambiarPlan.Name = "buttonCambiarPlan";
            this.buttonCambiarPlan.Size = new System.Drawing.Size(162, 36);
            this.buttonCambiarPlan.TabIndex = 10;
            this.buttonCambiarPlan.Text = "Cambiar Plan";
            this.buttonCambiarPlan.UseVisualStyleBackColor = true;
            this.buttonCambiarPlan.Click += new System.EventHandler(this.buttonCambiarPlan_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 361);
            this.Controls.Add(this.buttonCambiarPlan);
            this.Controls.Add(this.buttonComprarBono);
            this.Controls.Add(this.button_ListadoEstadistico);
            this.Controls.Add(this.button_CancelarAtencion);
            this.Controls.Add(this.button_RegResultAtenMedica);
            this.Controls.Add(this.ButtonCalendar);
            this.Controls.Add(this.buttonABMRol);
            this.Controls.Add(this.buttonABMAfiliado);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonABMAfiliado;
        private System.Windows.Forms.Button ButtonCalendar;
        private System.Windows.Forms.Button buttonABMRol;
        private System.Windows.Forms.Button button_RegResultAtenMedica;
        private System.Windows.Forms.Button button_CancelarAtencion;
        private System.Windows.Forms.Button button_ListadoEstadistico;
        private System.Windows.Forms.Button buttonComprarBono;
        private System.Windows.Forms.Button buttonCambiarPlan;

    }
}