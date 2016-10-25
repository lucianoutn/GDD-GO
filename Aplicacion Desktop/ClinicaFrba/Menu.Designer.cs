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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonABMAfiliado = new System.Windows.Forms.Button();
            this.ButtonCalendar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonABMRol = new System.Windows.Forms.Button();
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
            this.labelUser.Location = new System.Drawing.Point(303, 13);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar Resultado de\r\nAtención Médica\r\n\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar Atención Médica";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Listado Estadístico";
            this.button3.UseVisualStyleBackColor = true;
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonABMRol;
    }
}