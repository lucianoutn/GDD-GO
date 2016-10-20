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
            this.buttonSalir.Location = new System.Drawing.Point(197, 226);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonABMAfiliado
            // 
            this.buttonABMAfiliado.Location = new System.Drawing.Point(197, 180);
            this.buttonABMAfiliado.Name = "buttonABMAfiliado";
            this.buttonABMAfiliado.Size = new System.Drawing.Size(75, 23);
            this.buttonABMAfiliado.TabIndex = 3;
            this.buttonABMAfiliado.Text = "ABM Afiliado";
            this.buttonABMAfiliado.UseVisualStyleBackColor = true;
            this.buttonABMAfiliado.Click += new System.EventHandler(this.buttonABMAfiliado_Click);
            // 
            // ButtonCalendar
            // 
            this.ButtonCalendar.Location = new System.Drawing.Point(197, 151);
            this.ButtonCalendar.Name = "ButtonCalendar";
            this.ButtonCalendar.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalendar.TabIndex = 4;
            this.ButtonCalendar.Text = "Calendario";
            this.ButtonCalendar.UseVisualStyleBackColor = true;
            this.ButtonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(197, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "BOTONAZO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaFrba.Properties.Resources.utnBA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonCalendar);
            this.Controls.Add(this.buttonABMAfiliado);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelFecha);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
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
    }
}